using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeInfoForm {
    public partial class Form1 : Form {
        private StreamReader reader; // reads data from a text file
        private StreamWriter writer; // writes data to text file
        private FileStream outStream; // dedicated ouput stream
        private FileStream inStream; // dedicated input stream
        string fileName; // name of file containing data

        public Form1() {
            InitializeComponent();
        }

        // handler for 'Save As' button click
        private void saveAsButton_Click(object sender, EventArgs e) {
            DialogResult result; // result of SaveFileDialog
            using (var fileChooser = new SaveFileDialog()) {
                fileChooser.CheckFileExists = false; // let user create file
                result = fileChooser.ShowDialog();
                fileName = fileChooser.FileName; // name of file to save data
            }
            if (result == DialogResult.OK) { // ensure that user clicked 'OK'
                if (string.IsNullOrEmpty(fileName)) { // show error if user specified invalid file
                    MessageBox.Show("Invalid File Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else { // save file via FileStream
                    try { // open file with write access
                        using (outStream = new FileStream(fileName, FileMode.Append, FileAccess.Write, FileShare.Read)) {
                            using (writer = new StreamWriter(outStream)) {
                                insertRecord(); // call insert record method
                                saveAsButton.Enabled = false; // disable saveAs button for time being
                                enterButton.Enabled = true; // enable Enter button so user can write to file
                                statusLabel.Text = "Record saved. Enter more records and press \n'Enter' to " +
                                    "append to file or Load a new File"; // change status on label
                                ClearTextBoxes(); // clear all textboxes
                            }
                        }
                    } catch (IOException) { // catch error and notify user file does not exist
                        MessageBox.Show("Error opening file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    readFromFile(); // call reader method
                }
            }
        }

        // handler 'Load' button click
        private void loadButton_Click(object sender, EventArgs e) {
            DialogResult result; // result of OpenFileDialog
            using (OpenFileDialog fileChooser = new OpenFileDialog()) {
                result = fileChooser.ShowDialog();
                fileName = fileChooser.FileName; // get specified name
            }
            if (result == DialogResult.OK) { // ensure that user clicked 'OK'
                ClearTextBoxes();// clear all textboxes
                if (string.IsNullOrEmpty(fileName)) { // show error if user specified invalid file
                    MessageBox.Show("Invalid File Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else {
                    try {
                        readFromFile(); // call reader method
                        saveAsButton.Enabled = true; // user may want to load one file, then begin a new file
                        enterButton.Enabled = true; // enable Enter button so user can write to file
                        statusLabel.Text = "File loaded"; // change status on label
                    } catch (IOException) {
                        MessageBox.Show("Error reading from file", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // handler for 'Enter' button click
        private void enterButton_Click(object sender, EventArgs e) {
            if (!File.Exists(fileName)) {
                MessageBox.Show("Please save as a new document or load a file to work with.", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                enterButton.Enabled = false; // remove this option so user can move forward
                saveAsButton.Focus(); // apply focus to save button
            } else if (string.IsNullOrEmpty(lastNameTextBox.Text) || string.IsNullOrEmpty(firstNameTextBox.Text) ||
                    string.IsNullOrEmpty(idTextBox.Text) || string.IsNullOrEmpty(classTextBox.Text) ||
                    string.IsNullOrEmpty(gradeTextBox.Text)) {
                MessageBox.Show("One or more textboxes were left blank", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else {
                try {
                    using (outStream = new FileStream(fileName, FileMode.Append, FileAccess.Write, FileShare.Read)) {
                        using (writer = new StreamWriter(outStream)) {
                            insertRecord(); // call insert record method
                            saveAsButton.Enabled = true; // user may want to load one file, then begin a new file
                            enterButton.Enabled = true; // enable Enter button so user can write to file
                            statusLabel.Text = "Writing to " + Path.GetFileName(fileName); // change status on label
                            ClearTextBoxes(); // clear textboxes
                        }
                    }
                } catch (IOException) {
                    MessageBox.Show("Error writing to file", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } catch (FormatException) {
                    MessageBox.Show("Invalid Format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                readFromFile(); // populate status box with data from file
            }
        }

        // method for reading from file
        private void readFromFile() {
            try {
                using (inStream = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)) {
                    using (reader = new StreamReader(inStream)) {
                        string getRecords = null;
                        List<Grades> gradeObjs = new List<Grades>(); // create List for Grades objects
                        while ((getRecords = reader.ReadLine()) != null) { 
                            getRecords = getRecords.Trim(); // trim excess white space
                            string[] getFields = getRecords.Split(',');
                            gradeObjs.Add(new Grades() {
                                LastName = getFields[0],
                                FirstName = getFields[1],
                                StudentID = Convert.ToInt32(getFields[2]),
                                ClassName = getFields[3],
                                Grade = getFields[4]
                            });
                        }
                        foreach (Grades grade in gradeObjs) {
                            gradeOutputTextBox.AppendText(grade.ToString()); // write Grades to grade output box
                        }
                    }
                }
            } catch (IOException) {
                MessageBox.Show("Error reading from file", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Create a new Grades object and write it to file
        private void insertRecord() {
            Grades gradeRecord = new Grades(lastNameTextBox.Text, firstNameTextBox.Text,
                    Convert.ToInt32(idTextBox.Text), classTextBox.Text, gradeTextBox.Text);
            writer.WriteLine($"{gradeRecord.LastName}, {gradeRecord.FirstName}, " +
                    $"{gradeRecord.StudentID}, {gradeRecord.ClassName}, {gradeRecord.Grade}");
        }

        // method to clear text boxes
        private void ClearTextBoxes() {
            foreach (Control guiControl in Controls) {
                (guiControl as TextBox)?.Clear();
            }
        }

        // ensure streams are closed even though we used 'using' statements and they should be disposed, flushed and closed already
        private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
            try {
                reader?.Close();
                writer?.Close();
            } catch (IOException) {
                MessageBox.Show("Cannot close file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

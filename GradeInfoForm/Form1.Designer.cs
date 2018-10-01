namespace GradeInfoForm {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.classLabel = new System.Windows.Forms.Label();
            this.classTextBox = new System.Windows.Forms.TextBox();
            this.gradeLabel = new System.Windows.Forms.Label();
            this.gradeTextBox = new System.Windows.Forms.TextBox();
            this.saveAsButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.enterButton = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.gradeOutputTextBox = new System.Windows.Forms.TextBox();
            this.gradeOutputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(189, 44);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(148, 20);
            this.lastNameTextBox.TabIndex = 0;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(76, 47);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(61, 13);
            this.lastNameLabel.TabIndex = 1;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(76, 84);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(60, 13);
            this.firstNameLabel.TabIndex = 3;
            this.firstNameLabel.Text = "First Name:";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(189, 81);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(148, 20);
            this.firstNameTextBox.TabIndex = 2;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(76, 121);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(25, 13);
            this.idLabel.TabIndex = 5;
            this.idLabel.Text = "ID#";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(189, 118);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(148, 20);
            this.idTextBox.TabIndex = 4;
            // 
            // classLabel
            // 
            this.classLabel.AutoSize = true;
            this.classLabel.Location = new System.Drawing.Point(76, 158);
            this.classLabel.Name = "classLabel";
            this.classLabel.Size = new System.Drawing.Size(32, 13);
            this.classLabel.TabIndex = 7;
            this.classLabel.Text = "Class";
            // 
            // classTextBox
            // 
            this.classTextBox.Location = new System.Drawing.Point(189, 155);
            this.classTextBox.Name = "classTextBox";
            this.classTextBox.Size = new System.Drawing.Size(148, 20);
            this.classTextBox.TabIndex = 6;
            // 
            // gradeLabel
            // 
            this.gradeLabel.AutoSize = true;
            this.gradeLabel.Location = new System.Drawing.Point(76, 199);
            this.gradeLabel.Name = "gradeLabel";
            this.gradeLabel.Size = new System.Drawing.Size(36, 13);
            this.gradeLabel.TabIndex = 9;
            this.gradeLabel.Text = "Grade";
            // 
            // gradeTextBox
            // 
            this.gradeTextBox.Location = new System.Drawing.Point(189, 192);
            this.gradeTextBox.Name = "gradeTextBox";
            this.gradeTextBox.Size = new System.Drawing.Size(148, 20);
            this.gradeTextBox.TabIndex = 8;
            // 
            // saveAsButton
            // 
            this.saveAsButton.Location = new System.Drawing.Point(79, 244);
            this.saveAsButton.Name = "saveAsButton";
            this.saveAsButton.Size = new System.Drawing.Size(75, 23);
            this.saveAsButton.TabIndex = 10;
            this.saveAsButton.Text = "Save As";
            this.saveAsButton.UseVisualStyleBackColor = true;
            this.saveAsButton.Click += new System.EventHandler(this.saveAsButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(172, 244);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(75, 23);
            this.loadButton.TabIndex = 11;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(262, 244);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(75, 23);
            this.enterButton.TabIndex = 12;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(101, 296);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(66, 13);
            this.statusLabel.TabIndex = 13;
            this.statusLabel.Text = "Status Label";
            // 
            // gradeOutputTextBox
            // 
            this.gradeOutputTextBox.Location = new System.Drawing.Point(67, 349);
            this.gradeOutputTextBox.Multiline = true;
            this.gradeOutputTextBox.Name = "gradeOutputTextBox";
            this.gradeOutputTextBox.ReadOnly = true;
            this.gradeOutputTextBox.Size = new System.Drawing.Size(347, 171);
            this.gradeOutputTextBox.TabIndex = 14;
            // 
            // gradeOutputLabel
            // 
            this.gradeOutputLabel.AutoSize = true;
            this.gradeOutputLabel.Location = new System.Drawing.Point(12, 365);
            this.gradeOutputLabel.Name = "gradeOutputLabel";
            this.gradeOutputLabel.Size = new System.Drawing.Size(41, 13);
            this.gradeOutputLabel.TabIndex = 15;
            this.gradeOutputLabel.Text = "Grades";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 532);
            this.Controls.Add(this.gradeOutputLabel);
            this.Controls.Add(this.gradeOutputTextBox);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.saveAsButton);
            this.Controls.Add(this.gradeLabel);
            this.Controls.Add(this.gradeTextBox);
            this.Controls.Add(this.classLabel);
            this.Controls.Add(this.classTextBox);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label classLabel;
        private System.Windows.Forms.TextBox classTextBox;
        private System.Windows.Forms.Label gradeLabel;
        private System.Windows.Forms.TextBox gradeTextBox;
        private System.Windows.Forms.Button saveAsButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.TextBox gradeOutputTextBox;
        private System.Windows.Forms.Label gradeOutputLabel;
    }
}


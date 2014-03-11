namespace DirectoryLister.src
{
    partial class DirectoryListerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DirectoryListerForm));
            this.actionButton = new System.Windows.Forms.Button();
            this.targetDirectoryField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.targetDirectoryButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.outputField = new System.Windows.Forms.TextBox();
            this.outputButton = new System.Windows.Forms.Button();
            this.listSubDirsCb = new System.Windows.Forms.CheckBox();
            this.listSubFilesCb = new System.Windows.Forms.CheckBox();
            this.listFilesCb = new System.Windows.Forms.CheckBox();
            this.showFullPathCb = new System.Windows.Forms.CheckBox();
            this.showFullFilesCb = new System.Windows.Forms.CheckBox();
            this.showTopDirCb = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.indentField = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.filePostfixField = new System.Windows.Forms.TextBox();
            this.directoryPostfixField = new System.Windows.Forms.TextBox();
            this.directoryPrefixField = new System.Windows.Forms.TextBox();
            this.filePrefixField = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.excludeExtensionsField = new System.Windows.Forms.TextBox();
            this.includeExtensionsField = new System.Windows.Forms.TextBox();
            this.excludeExtensionsRadio = new System.Windows.Forms.RadioButton();
            this.includeExtensionsRadio = new System.Windows.Forms.RadioButton();
            this.allExtensionsRadio = new System.Windows.Forms.RadioButton();
            this.instructionsField = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.maxDepthField = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // actionButton
            // 
            this.actionButton.Location = new System.Drawing.Point(187, 496);
            this.actionButton.Name = "actionButton";
            this.actionButton.Size = new System.Drawing.Size(169, 23);
            this.actionButton.TabIndex = 0;
            this.actionButton.Text = "List Directory Structure";
            this.actionButton.UseVisualStyleBackColor = true;
            this.actionButton.Click += new System.EventHandler(this.actionButton_Click);
            // 
            // targetDirectoryField
            // 
            this.targetDirectoryField.Location = new System.Drawing.Point(104, 127);
            this.targetDirectoryField.Name = "targetDirectoryField";
            this.targetDirectoryField.Size = new System.Drawing.Size(345, 20);
            this.targetDirectoryField.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Target Directory:";
            // 
            // targetDirectoryButton
            // 
            this.targetDirectoryButton.Location = new System.Drawing.Point(455, 127);
            this.targetDirectoryButton.Name = "targetDirectoryButton";
            this.targetDirectoryButton.Size = new System.Drawing.Size(75, 23);
            this.targetDirectoryButton.TabIndex = 3;
            this.targetDirectoryButton.Text = "Browse";
            this.targetDirectoryButton.UseVisualStyleBackColor = true;
            this.targetDirectoryButton.Click += new System.EventHandler(this.targetDirectoryButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "- Options -";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Output File:";
            // 
            // outputField
            // 
            this.outputField.Location = new System.Drawing.Point(104, 164);
            this.outputField.Name = "outputField";
            this.outputField.Size = new System.Drawing.Size(345, 20);
            this.outputField.TabIndex = 6;
            // 
            // outputButton
            // 
            this.outputButton.Location = new System.Drawing.Point(455, 164);
            this.outputButton.Name = "outputButton";
            this.outputButton.Size = new System.Drawing.Size(75, 23);
            this.outputButton.TabIndex = 7;
            this.outputButton.Text = "Browse";
            this.outputButton.UseVisualStyleBackColor = true;
            this.outputButton.Click += new System.EventHandler(this.outputButton_Click);
            // 
            // listSubDirsCb
            // 
            this.listSubDirsCb.AutoSize = true;
            this.listSubDirsCb.Checked = true;
            this.listSubDirsCb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.listSubDirsCb.Location = new System.Drawing.Point(94, 222);
            this.listSubDirsCb.Name = "listSubDirsCb";
            this.listSubDirsCb.Size = new System.Drawing.Size(112, 17);
            this.listSubDirsCb.TabIndex = 8;
            this.listSubDirsCb.Text = "List Subdirectories";
            this.listSubDirsCb.UseVisualStyleBackColor = true;
            // 
            // listSubFilesCb
            // 
            this.listSubFilesCb.AutoSize = true;
            this.listSubFilesCb.Checked = true;
            this.listSubFilesCb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.listSubFilesCb.Location = new System.Drawing.Point(94, 245);
            this.listSubFilesCb.Name = "listSubFilesCb";
            this.listSubFilesCb.Size = new System.Drawing.Size(128, 17);
            this.listSubFilesCb.TabIndex = 9;
            this.listSubFilesCb.Text = "List Subdirectory Files";
            this.listSubFilesCb.UseVisualStyleBackColor = true;
            // 
            // listFilesCb
            // 
            this.listFilesCb.AutoSize = true;
            this.listFilesCb.Checked = true;
            this.listFilesCb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.listFilesCb.Location = new System.Drawing.Point(94, 268);
            this.listFilesCb.Name = "listFilesCb";
            this.listFilesCb.Size = new System.Drawing.Size(66, 17);
            this.listFilesCb.TabIndex = 10;
            this.listFilesCb.Text = "List Files";
            this.listFilesCb.UseVisualStyleBackColor = true;
            // 
            // showFullPathCb
            // 
            this.showFullPathCb.AutoSize = true;
            this.showFullPathCb.Checked = true;
            this.showFullPathCb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showFullPathCb.Location = new System.Drawing.Point(258, 222);
            this.showFullPathCb.Name = "showFullPathCb";
            this.showFullPathCb.Size = new System.Drawing.Size(168, 17);
            this.showFullPathCb.TabIndex = 11;
            this.showFullPathCb.Text = "Show Full Path For Directories";
            this.showFullPathCb.UseVisualStyleBackColor = true;
            // 
            // showFullFilesCb
            // 
            this.showFullFilesCb.AutoSize = true;
            this.showFullFilesCb.Checked = true;
            this.showFullFilesCb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showFullFilesCb.Location = new System.Drawing.Point(258, 245);
            this.showFullFilesCb.Name = "showFullFilesCb";
            this.showFullFilesCb.Size = new System.Drawing.Size(139, 17);
            this.showFullFilesCb.TabIndex = 12;
            this.showFullFilesCb.Text = "Show Full Path For Files";
            this.showFullFilesCb.UseVisualStyleBackColor = true;
            // 
            // showTopDirCb
            // 
            this.showTopDirCb.AutoSize = true;
            this.showTopDirCb.Checked = true;
            this.showTopDirCb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showTopDirCb.Location = new System.Drawing.Point(258, 268);
            this.showTopDirCb.Name = "showTopDirCb";
            this.showTopDirCb.Size = new System.Drawing.Size(149, 17);
            this.showTopDirCb.TabIndex = 13;
            this.showTopDirCb.Text = "Show Top Level Directory";
            this.showTopDirCb.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Number of Spaces for Indent:";
            // 
            // indentField
            // 
            this.indentField.Location = new System.Drawing.Point(164, 295);
            this.indentField.Name = "indentField";
            this.indentField.Size = new System.Drawing.Size(79, 20);
            this.indentField.TabIndex = 15;
            this.indentField.Text = "2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Directory Prefix:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(243, 329);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Directory Postfix:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 361);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "File Prefix:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(243, 361);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "File Postfix:";
            // 
            // filePostfixField
            // 
            this.filePostfixField.Location = new System.Drawing.Point(335, 361);
            this.filePostfixField.Name = "filePostfixField";
            this.filePostfixField.Size = new System.Drawing.Size(100, 20);
            this.filePostfixField.TabIndex = 20;
            // 
            // directoryPostfixField
            // 
            this.directoryPostfixField.Location = new System.Drawing.Point(335, 326);
            this.directoryPostfixField.Name = "directoryPostfixField";
            this.directoryPostfixField.Size = new System.Drawing.Size(100, 20);
            this.directoryPostfixField.TabIndex = 21;
            this.directoryPostfixField.Text = "]";
            // 
            // directoryPrefixField
            // 
            this.directoryPrefixField.Location = new System.Drawing.Point(104, 326);
            this.directoryPrefixField.Name = "directoryPrefixField";
            this.directoryPrefixField.Size = new System.Drawing.Size(100, 20);
            this.directoryPrefixField.TabIndex = 22;
            this.directoryPrefixField.Text = "- [";
            // 
            // filePrefixField
            // 
            this.filePrefixField.Location = new System.Drawing.Point(104, 358);
            this.filePrefixField.Name = "filePrefixField";
            this.filePrefixField.Size = new System.Drawing.Size(100, 20);
            this.filePrefixField.TabIndex = 23;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.excludeExtensionsField);
            this.groupBox1.Controls.Add(this.includeExtensionsField);
            this.groupBox1.Controls.Add(this.excludeExtensionsRadio);
            this.groupBox1.Controls.Add(this.includeExtensionsRadio);
            this.groupBox1.Controls.Add(this.allExtensionsRadio);
            this.groupBox1.Location = new System.Drawing.Point(15, 387);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(515, 93);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File Extension Rules";
            // 
            // excludeExtensionsField
            // 
            this.excludeExtensionsField.Location = new System.Drawing.Point(276, 67);
            this.excludeExtensionsField.Name = "excludeExtensionsField";
            this.excludeExtensionsField.Size = new System.Drawing.Size(233, 20);
            this.excludeExtensionsField.TabIndex = 4;
            // 
            // includeExtensionsField
            // 
            this.includeExtensionsField.Location = new System.Drawing.Point(289, 39);
            this.includeExtensionsField.Name = "includeExtensionsField";
            this.includeExtensionsField.Size = new System.Drawing.Size(220, 20);
            this.includeExtensionsField.TabIndex = 3;
            // 
            // excludeExtensionsRadio
            // 
            this.excludeExtensionsRadio.AutoSize = true;
            this.excludeExtensionsRadio.Location = new System.Drawing.Point(29, 67);
            this.excludeExtensionsRadio.Name = "excludeExtensionsRadio";
            this.excludeExtensionsRadio.Size = new System.Drawing.Size(241, 17);
            this.excludeExtensionsRadio.TabIndex = 2;
            this.excludeExtensionsRadio.Text = "Exclude the following extensions (ie: .jpg, .txt):";
            this.excludeExtensionsRadio.UseVisualStyleBackColor = true;
            // 
            // includeExtensionsRadio
            // 
            this.includeExtensionsRadio.AutoSize = true;
            this.includeExtensionsRadio.Location = new System.Drawing.Point(29, 42);
            this.includeExtensionsRadio.Name = "includeExtensionsRadio";
            this.includeExtensionsRadio.Size = new System.Drawing.Size(260, 17);
            this.includeExtensionsRadio.TabIndex = 1;
            this.includeExtensionsRadio.Text = "Include only the following extensions (ie: .jpg, .txt):";
            this.includeExtensionsRadio.UseVisualStyleBackColor = true;
            // 
            // allExtensionsRadio
            // 
            this.allExtensionsRadio.AutoSize = true;
            this.allExtensionsRadio.Checked = true;
            this.allExtensionsRadio.Location = new System.Drawing.Point(29, 19);
            this.allExtensionsRadio.Name = "allExtensionsRadio";
            this.allExtensionsRadio.Size = new System.Drawing.Size(129, 17);
            this.allExtensionsRadio.TabIndex = 0;
            this.allExtensionsRadio.TabStop = true;
            this.allExtensionsRadio.Text = "Include all extensions.";
            this.allExtensionsRadio.UseVisualStyleBackColor = true;
            // 
            // instructionsField
            // 
            this.instructionsField.BackColor = System.Drawing.SystemColors.Control;
            this.instructionsField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.instructionsField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionsField.Location = new System.Drawing.Point(12, 12);
            this.instructionsField.Multiline = true;
            this.instructionsField.Name = "instructionsField";
            this.instructionsField.ReadOnly = true;
            this.instructionsField.Size = new System.Drawing.Size(516, 109);
            this.instructionsField.TabIndex = 25;
            this.instructionsField.Text = resources.GetString("instructionsField.Text");
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(317, 298);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Maximum Folder Depth:";
            // 
            // maxDepthField
            // 
            this.maxDepthField.Location = new System.Drawing.Point(441, 295);
            this.maxDepthField.Name = "maxDepthField";
            this.maxDepthField.Size = new System.Drawing.Size(81, 20);
            this.maxDepthField.TabIndex = 27;
            this.maxDepthField.Text = "None";
            // 
            // DirectoryListerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 532);
            this.Controls.Add(this.maxDepthField);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.instructionsField);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.filePrefixField);
            this.Controls.Add(this.directoryPrefixField);
            this.Controls.Add(this.directoryPostfixField);
            this.Controls.Add(this.filePostfixField);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.indentField);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.showTopDirCb);
            this.Controls.Add(this.showFullFilesCb);
            this.Controls.Add(this.showFullPathCb);
            this.Controls.Add(this.listFilesCb);
            this.Controls.Add(this.listSubFilesCb);
            this.Controls.Add(this.listSubDirsCb);
            this.Controls.Add(this.outputButton);
            this.Controls.Add(this.outputField);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.targetDirectoryButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.targetDirectoryField);
            this.Controls.Add(this.actionButton);
            this.MaximumSize = new System.Drawing.Size(556, 566);
            this.MinimumSize = new System.Drawing.Size(556, 566);
            this.Name = "DirectoryListerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Directory Lister 19";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DirectoryListerForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button actionButton;
        private System.Windows.Forms.TextBox targetDirectoryField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button targetDirectoryButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox outputField;
        private System.Windows.Forms.Button outputButton;
        private System.Windows.Forms.CheckBox listSubDirsCb;
        private System.Windows.Forms.CheckBox listSubFilesCb;
        private System.Windows.Forms.CheckBox listFilesCb;
        private System.Windows.Forms.CheckBox showFullPathCb;
        private System.Windows.Forms.CheckBox showFullFilesCb;
        private System.Windows.Forms.CheckBox showTopDirCb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox indentField;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox filePostfixField;
        private System.Windows.Forms.TextBox directoryPostfixField;
        private System.Windows.Forms.TextBox directoryPrefixField;
        private System.Windows.Forms.TextBox filePrefixField;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox excludeExtensionsField;
        private System.Windows.Forms.TextBox includeExtensionsField;
        private System.Windows.Forms.RadioButton excludeExtensionsRadio;
        private System.Windows.Forms.RadioButton includeExtensionsRadio;
        private System.Windows.Forms.RadioButton allExtensionsRadio;
        private System.Windows.Forms.TextBox instructionsField;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox maxDepthField;
    }
}


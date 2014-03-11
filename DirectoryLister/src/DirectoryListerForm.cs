using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using DirectoryLister.Properties;

namespace DirectoryLister.src
{
    public partial class DirectoryListerForm : Form
    {
        private DirectoryListerLogic directoryLister;

        public DirectoryListerForm()
        {
            InitializeComponent();                        
            loadSettings();
            directoryLister = new DirectoryListerLogic();
        }

        private void DirectoryListerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            saveSettings();
        }

        private void loadSettings()
        {
            targetDirectoryField.Text = Settings.Default.TargetDirectory;
            if (targetDirectoryField.Text == "")
                targetDirectoryField.Text = System.IO.Directory.GetCurrentDirectory();

            outputField.Text = Settings.Default.OutputFile;
            if( outputField.Text == "" )
                outputField.Text = System.IO.Directory.GetCurrentDirectory() + "/results.txt";

            listSubDirsCb.Checked = Settings.Default.ListSubdirectories;
            showFullPathCb.Checked = Settings.Default.ShowFullPathForDirectories;
            listSubFilesCb.Checked = Settings.Default.ListSubdirectoryFiles;
            showFullFilesCb.Checked = Settings.Default.ShowFullPathForFiles;
            listFilesCb.Checked = Settings.Default.ListFiles;
            showTopDirCb.Checked = Settings.Default.ShowTopLevelDirectory;
            indentField.Text = Settings.Default.NumberOfSpacesForIndent;
            maxDepthField.Text = Settings.Default.MaximumFolderDepth;
            directoryPrefixField.Text = Settings.Default.DirectoryPrefix;
            directoryPostfixField.Text = Settings.Default.DirectoryPostfix;
            filePrefixField.Text = Settings.Default.FilePrefix;
            filePostfixField.Text = Settings.Default.FilePostfix;

            int fileExtensionRadio = Settings.Default.FileExtensionRule;
            if (fileExtensionRadio==0)
                 allExtensionsRadio.Checked = true;
            else if (fileExtensionRadio==1)
                includeExtensionsRadio.Checked = true;
            else
                excludeExtensionsRadio.Checked = true;
            includeExtensionsField.Text = Settings.Default.IncludedExtensions;
            excludeExtensionsField.Text = Settings.Default.ExcludedExtensions;
        }

        private void saveSettings()
        {
            Settings.Default.TargetDirectory = targetDirectoryField.Text;
            Settings.Default.OutputFile = outputField.Text;
            Settings.Default.ListSubdirectories = listSubDirsCb.Checked;
            Settings.Default.ShowFullPathForDirectories = showFullPathCb.Checked;
            Settings.Default.ListSubdirectoryFiles = listSubFilesCb.Checked;
            Settings.Default.ShowFullPathForFiles = showFullFilesCb.Checked;
            Settings.Default.ListFiles = listFilesCb.Checked;
            Settings.Default.ShowTopLevelDirectory = showTopDirCb.Checked;
            Settings.Default.NumberOfSpacesForIndent = indentField.Text;
            Settings.Default.MaximumFolderDepth = maxDepthField.Text;
            Settings.Default.DirectoryPrefix = directoryPrefixField.Text;
            Settings.Default.DirectoryPostfix = directoryPostfixField.Text;
            Settings.Default.FilePrefix = filePrefixField.Text;
            Settings.Default.FilePostfix = filePostfixField.Text;

            if( includeExtensionsRadio.Checked )
                Settings.Default.FileExtensionRule = 1;
            else if( excludeExtensionsRadio.Checked )
                Settings.Default.FileExtensionRule = 2;
            else
                Settings.Default.FileExtensionRule = 0;
            Settings.Default.IncludedExtensions = includeExtensionsField.Text;
            Settings.Default.ExcludedExtensions = excludeExtensionsField.Text;

            Settings.Default.Save();
        }

        private void targetDirectoryButton_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog dlg = new FolderBrowserDialog();
                dlg.SelectedPath = System.IO.Directory.GetCurrentDirectory();
                dlg.Description = @"Choose folder of Images:";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    targetDirectoryField.Text = dlg.SelectedPath;
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Serious Error trying to open directory.  You should consider restarting the program.  " + ex);
            }
        }

        private void outputButton_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Title = "Open Txt";
                openFileDialog.Filter = "All Files | *.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.FileName = "";
                openFileDialog.CheckFileExists = false;
                openFileDialog.CheckPathExists = true;

                openFileDialog.InitialDirectory = System.IO.Directory.GetCurrentDirectory();

                if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                {
                    return;
                }

                if (openFileDialog.FileName == "")
                {
                    return;
                }

                outputField.Text = openFileDialog.FileName.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Serious Error trying to open file.  You should consider restarting the program.  " + ex);
            }
        }

        private bool validateSettings()
        {
            //Validation
            if (!Directory.Exists(targetDirectoryField.Text))
            {
                MessageBox.Show("Specified Target Directory Does Not Exist.");
                return false;
            }
            if (outputField.Text.Equals(""))
            {
                MessageBox.Show("Output File Not Specified.");
                return false;
            }
            if (File.Exists(outputField.Text))
            {
                if( MessageBox.Show("Output File Already Exists.  Do you wish to overwrite?","Overwrite?",MessageBoxButtons.YesNo) == DialogResult.No )
                    return false;
            }
            try
            {
                System.Int32.Parse(indentField.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Could not parse indent field.");
                return false;
            }
            try
            {
                if( !maxDepthField.Text.ToLower().Equals("none") )
                    System.Int32.Parse(maxDepthField.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Could not parse maximum depth field.");
                return false;
            }
            return true;
        }

        private ArrayList extractExtensions( String tagText, char delimeter)
        {
            ArrayList extensions = new ArrayList();
            //Do a primary explosion based on commas
            String[] tagStringsComma = tagText.Split(new Char[] { delimeter });
            foreach (String tagStringComma in tagStringsComma)
            {
                if (!tagStringComma.Trim().Equals(""))
                {
                    if (!extensions.Contains(tagStringComma.Trim()))
                    {
                        extensions.Add(tagStringComma.Trim());
                    }
                }
            }
            return extensions;
        }

        private void actionButton_Click(object sender, EventArgs e)
        {
            //Validation
            if (!validateSettings())
                return;

            //Get the settings
            string targetDirectory = targetDirectoryField.Text;
            string outputFile = outputField.Text;
            bool listSubdirectories = listSubDirsCb.Checked;
            bool listFiles = listFilesCb.Checked;
            bool listSubDirectoryFiles = listSubFilesCb.Checked;
            bool showDirectoryFullPath = showFullPathCb.Checked;
            bool showFileFullPath = showFullFilesCb.Checked;
            bool showTopLevelDirectory = showTopDirCb.Checked;
            int indentSpaces =  System.Int32.Parse(indentField.Text);
            int maximumDepth = -1;
            if (!maxDepthField.Text.ToLower().Equals("none"))
                maximumDepth = System.Int32.Parse(maxDepthField.Text);
            string directoryPrefix = directoryPrefixField.Text;
            string directoryPostfix = directoryPostfixField.Text;
            string filePrefix = filePrefixField.Text;
            string filePostfix = filePostfixField.Text;
            int extensionsAction = DirectoryListerLogic.ALL;
            ArrayList extensions = new ArrayList();
            if (includeExtensionsRadio.Checked)
            {
                extensionsAction = DirectoryListerLogic.INCLUDE;
                extensions = extractExtensions(includeExtensionsField.Text, ',');
            }
            else if (excludeExtensionsRadio.Checked)
            {
                extensionsAction = DirectoryListerLogic.EXCLUDE;
                extensions = extractExtensions(excludeExtensionsField.Text, ',');
            }

            //Call directory list    
            try
            {
                directoryLister.listDirectories(listSubdirectories, listFiles, listSubDirectoryFiles, showDirectoryFullPath,
                    showFileFullPath, indentSpaces, directoryPrefix, directoryPostfix, filePrefix, filePostfix,
                    outputFile, maximumDepth, targetDirectory, extensionsAction, extensions, showTopLevelDirectory);
                MessageBox.Show("Successfully listed directories to the specified file.");
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to List Directories!");
            }
        }
    }
}
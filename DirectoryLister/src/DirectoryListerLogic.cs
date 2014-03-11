using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Collections;

namespace DirectoryLister.src
{
    class DirectoryListerLogic
    {
        private bool listSubdirectories;
        private bool listFiles;
        private bool listSubDirectoryFiles;
        private bool showDirectoryFullPath;
        private bool showFileFullPath;
        private bool showTopLevelDirectory;
        private string indentSpaces;
        private string directoryPrefix;
        private string directoryPostfix;
        private string filePrefix;
        private string filePostfix;
        private string topDirectory;
        private int maximumDepth;
        private int currentDepth;
        private int extensionsAction;
        private ArrayList extensions;

        public static int ALL = 0;
        public static int INCLUDE = 1;
        public static int EXCLUDE = 2;

        public DirectoryListerLogic()
        {
            listSubdirectories = true;
            listFiles = true;
            listSubDirectoryFiles = true;
            showDirectoryFullPath = true;
            showFileFullPath = false;
            indentSpaces = "  ";
            directoryPrefix = "- [ ";
            directoryPostfix = " ]";
            filePrefix = "";
            filePostfix = "";
            maximumDepth = -1;
            this.extensionsAction = ALL;
            extensions = new ArrayList();
            this.showTopLevelDirectory = true;
        }

        // TODO: This method has too many parameters, probably want to use a Builder
        public void listDirectories(bool listSubdirectories, bool listFiles, bool listSubDirectoryFiles, 
            bool showDirectoryFullPath, bool showFileFullPath, int indents, string directoryPrefix,
            string directoryPostfix, string filePrefix, string filePostfix, string outputFile, 
            int maximumDepth, string targetDirectory, int extensionsAction, ArrayList extensions, 
            bool showTopLevelDirectory)
        {
            this.listSubdirectories = listSubdirectories;
            this.listFiles = listFiles;
            this.listSubDirectoryFiles = listSubDirectoryFiles;
            this.showDirectoryFullPath = showDirectoryFullPath;
            this.showFileFullPath = showFileFullPath;
            this.indentSpaces = "";
            while (indents-- > 0)
                this.indentSpaces += " ";
            this.directoryPrefix = directoryPrefix;
            this.directoryPostfix = directoryPostfix;
            this.filePrefix = filePrefix;
            this.filePostfix = filePostfix;
            this.maximumDepth = maximumDepth;
            this.topDirectory = targetDirectory;
            currentDepth = 0;
            this.extensionsAction = extensionsAction;
            this.extensions = extensions;
            this.showTopLevelDirectory = showTopLevelDirectory;

            TextWriter output = new StreamWriter(outputFile);
            try
            {
                listDirectories(output, targetDirectory, "");
            } catch( Exception ) {
                output.Close();
                throw new Exception("Error While Listing Directories!!!");
            }
            output.Close();
        }

        public void listDirectories(TextWriter output, string targetDirectory, string indent)
        {
            try
            {
                DirectoryInfo dir = new DirectoryInfo(targetDirectory);
                if (showTopLevelDirectory || (!showTopLevelDirectory && !dir.FullName.Equals(topDirectory)))
                {
                    if (showDirectoryFullPath)
                        output.WriteLine(indent + directoryPrefix + dir.FullName + directoryPostfix);
                    else
                        output.WriteLine(indent + directoryPrefix + dir.Name + directoryPostfix);
                    indent = indent + indentSpaces;
                }                
                if (dir.GetDirectories().Length != 0)
                {
                    if (listSubdirectories)
                    {
                        if (dir.GetDirectories().Length > 0)
                        {
                            if (maximumDepth >= 0 && currentDepth >= maximumDepth)
                                return;
                            currentDepth++;
                        }
                        foreach (DirectoryInfo subDir in dir.GetDirectories())
                        {
                            listDirectories(output, subDir.FullName, indent);
                        }
                    }
                }
                if (dir.GetFiles().Length != 0)
                {
                    if (listFiles && 
                        (listSubDirectoryFiles || (!listSubDirectoryFiles && this.topDirectory.Equals(dir.FullName)) ) )
                    {
                        foreach (FileInfo finfo in dir.GetFiles())
                        {
                            if( extensionsAction == ALL
                                || (extensionsAction == INCLUDE && extensions.Contains(finfo.Extension) )
                                || (extensionsAction == EXCLUDE && !extensions.Contains(finfo.Extension) ) )
                            {
                                if( showFileFullPath )
                                    output.WriteLine(indent + filePrefix + finfo.FullName + filePostfix);
                                else
                                    output.WriteLine(indent + filePrefix + finfo.Name + filePostfix);
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw new Exception("Error While Listing Directories!!!");
            }
        }
    }
}

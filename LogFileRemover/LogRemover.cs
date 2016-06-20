using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;

namespace LogFileRemover
{
    /// <summary>
    /// Removes log files asynchronously.
    /// </summary>
    class LogRemover : BackgroundWorker
    {
        private readonly List<string> removedFilePaths = new List<string>();
        private readonly List<string> unremovableFilePaths = new List<string>();
        private bool useStrictDeletion;

        protected override void OnDoWork(DoWorkEventArgs e)
        {
            base.OnDoWork(e);
            useStrictDeletion = (bool)e.Argument;
            DirectoryInfo dirInfo = BootDriveInfo;
            WalkDirectoryTree(dirInfo);
        }

        protected override void OnRunWorkerCompleted(RunWorkerCompletedEventArgs e)
        {
            string[][] filePaths = { removedFilePaths.ToArray(), unremovableFilePaths.ToArray() };
            e = new RunWorkerCompletedEventArgs(filePaths, e.Error, false);
            base.OnRunWorkerCompleted(e);
        }

        private static DirectoryInfo BootDriveInfo
        {
            get
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.Windows);
                string root = Path.GetPathRoot(path);
                return new DirectoryInfo(root);
            }
        }

        private void WalkDirectoryTree(DirectoryInfo root)
        {
            if (CancellationPending) return;

            FileInfo[] files = null;

            try
            {
                files = root.GetFiles();
            }
            catch { }

            if (files != null)
            {
                for (int i = 0; i < files.Length; i++)
                {
                    string fullPath = files[i].FullName.ToLowerInvariant();
                    bool isTextFile = Path.GetExtension(fullPath).Equals(".txt");
                    bool isLogFile = Path.GetExtension(fullPath).Equals(".log");
                    bool isLogRelated = Path.GetFileNameWithoutExtension(fullPath).Contains("log");

                    // If .log file or is using loose deletion and is a text file that is log related
                    if (isLogFile || !useStrictDeletion && isTextFile && isLogRelated)
                    {
                        try
                        {
                            files[i].Delete();
                            removedFilePaths.Add(fullPath);
                        }
                        catch
                        {
                            unremovableFilePaths.Add(fullPath);
                        }
                    }
                }

                 DirectoryInfo[] subDirectories = root.GetDirectories();

                for (int i = 0; i < subDirectories.LongLength; i++) 
                {
                    WalkDirectoryTree(subDirectories[i]);
                }
            }
        }
    }
}

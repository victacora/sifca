﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Threading;

namespace SetAccessRights
{
    public class AccessRightsProvider
    {
        public void SetRightsToAll()
        {
            string folder = GetExecutionFolder();
            List<string> files = GetAllFiles(folder);
            System.Console.WriteLine("Modificando permisos.");
            foreach (string file in files)
            {
                try
                {
                    System.Console.WriteLine("Modificando permisos. "+file);
                    SetAccessRights(file);
                }
                catch
                {
                    // Discard
                }
            }
        }

        private string GetExecutionFolder()
        {
            return Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
        }

        /// <summary>
        /// Returns all files in folder recursively
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        private List<string> GetAllFiles(string path)
        {
            List<string> files = new List<string>();
            Stack<string> directoryStack = new Stack<string>();

            directoryStack.Push(path);
            while (directoryStack.Count > 0)
            {
                string dir = directoryStack.Pop();

                try
                {
                    files.AddRange(Directory.GetFiles(dir, "*.*"));

                    foreach (string directory in Directory.GetDirectories(dir))
                    {
                        directoryStack.Push(directory);
                    }
                }
                catch
                {
                    // Discard
                }
            }

            return files;
        }

        /// <summary>
        /// Set full access rights for specified file
        /// </summary>
        /// <param name="file"></param>
        private void SetAccessRights(string file)
        {
            FileSecurity fileSecurity = File.GetAccessControl(file);
            AuthorizationRuleCollection rules = fileSecurity.GetAccessRules(true, true, typeof(NTAccount));

            foreach (FileSystemAccessRule rule in rules)
            {
                string name = rule.IdentityReference.Value;

                if (rule.FileSystemRights != FileSystemRights.FullControl)
                {
                    System.Console.WriteLine("Estableciendo permiso: " + name);
                    Thread.Sleep(500);
                    FileSecurity newFileSecurity = File.GetAccessControl(file);
                    FileSystemAccessRule newRule = new FileSystemAccessRule(name, FileSystemRights.FullControl, AccessControlType.Allow);
                    newFileSecurity.AddAccessRule(newRule);
                    File.SetAccessControl(file, newFileSecurity);
                }
            }
        }
    }
}

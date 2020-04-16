using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Tranfer
{
    public class ProgramCopy
    {
        public static void ProgramCopyFunction()
        {
            
            string fileName = "Neudesic_Rishi_Parikh_CAD.docx";
            string sourcePath = @"D:\Test";
            string targetPath = @"D:\Test1";

            // Use Path class to manipulate file and directory paths.
            string sourceFile = System.IO.Path.Combine(sourcePath, fileName);
            string destFile = System.IO.Path.Combine(targetPath, fileName);

            // To copy a folder's contents to a new location:
            // Create a new target folder. 
            // If the directory already exists, this method does not create a new directory.
            System.IO.Directory.CreateDirectory(targetPath);

            // To copy a file to another location and 
            // overwrite the destination file if it already exists.
            System.IO.File.Copy(sourceFile, destFile, true);
            DateTime localDate = DateTime.Now;
            File.SetLastWriteTime(destFile, localDate);
        }
    }
}


using System;
using System.IO;
using Tranfer;

public class Program
{
    public static void Main()
    {
        ProgramMove();
        ProgramCopy.ProgramCopyFunction();
        ProgramDelete.ProgramDeleteFunction();
    }



    public static void ProgramMove()
    {

        string sourceFile = @"D:\Test\Holiday Calendar 2020.pdf";
        string destinationFile = @"D:\Test1\Holiday Calendar 2020.pdf";

        // To move a file or folder to a new location:
        System.IO.File.Move(sourceFile, destinationFile);
        DateTime localDate = DateTime.Now;
        File.SetLastWriteTime(destinationFile, localDate);

    }
}

  
        
       
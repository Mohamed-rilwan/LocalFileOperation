using System;
using System.Collections.Generic;
using System.Text;

namespace Tranfer
{
    public class ProgramDelete
    {
        public static void ProgramDeleteFunction()
        {
            // Delete a file by using File class static method...
            if (System.IO.File.Exists(@"D:\Test\Holiday Calendar 2020 - Copy.pdf"))
            {
               
                try
                {
                    System.IO.File.Delete(@"D:\Test\Holiday Calendar 2020 - Copy.pdf");
                }
                catch (System.IO.IOException e)
                {
                    Console.WriteLine(e.Message);
                    return;
                }
            }
        }
    }
}

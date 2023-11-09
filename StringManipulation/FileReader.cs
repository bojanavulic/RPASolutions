using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulation
{
    public class FileReader
    {
       public void ReadFile()
        {
            string filePath = @"C:\Users\LENOVO\Downloads\task2_invoice.txt";

            if (File.Exists(filePath))
            {
                string fileContents = File.ReadAllText(filePath);
                Console.WriteLine("File Content:");
                Console.WriteLine(fileContents);
                Invoice invoice = new Invoice();
                invoice.LoadFromString(fileContents);

            }
            else
            {
                Console.WriteLine("The file does not exist.");
            }
        }



    }
}

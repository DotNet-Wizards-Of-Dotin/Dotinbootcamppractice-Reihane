using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace FileQueryExplorer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string directoryPath = @"C:\Users\Raihaneh Shakiba\source\repos\Dotinbootcamppractice-Reihane\FileQueryExplorer\Test_Folder";

            #region [Get all file paths in the directory]
            string[] filePaths = Directory.GetFiles(directoryPath);
            //find by size
            var largeFiles = filePaths.Where(path => new FileInfo(path).Length > 1024);
            #endregion

           #region [Display all files in the directory]

            //Console.WriteLine("All Files in the Directory:");
            //foreach (var file in filePaths)
            //{
            //    string fileName = Path.GetFileName(file);
            //    Console.WriteLine(fileName);
            //}

            //// Check if there are any files
            //if (filePaths.Length == 0)
            //{
            //    Console.WriteLine("No files found in the directory.");
            //}
            #endregion
            //Order Files by Name
            var order_by_size = filePaths.OrderBy(path => new FileInfo(path).Length);
            Showing_Result(order_by_size);
        }
        //method for showing the result
        public static void Showing_Result(IEnumerable<string> result)
        {
            Console.WriteLine($"The result is : ");
            foreach (var r in result)
            {
                string fileName = Path.GetFileName(r);
                Console.WriteLine(fileName);
            }

        }
    }
}

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
            Contain4();
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

            #region[Order Files by Name]
            var order_by_size = filePaths.OrderBy(path => new FileInfo(path).Length);
            Showing_Result(order_by_size);
            #endregion
        }
        #region[method for showing the result of Getting File Query ]
        public static void Showing_Result(IEnumerable<string> result)
        {
            Console.WriteLine($"\nThe result of Filenames sorted by the size is : \n");
            foreach (var r in result)
            {
                string fileName = Path.GetFileName(r);
                Console.WriteLine(fileName);
            }
            Console.WriteLine("\n");

        }
        #endregion

        #region[Find numbers not starting or ending with 4, but containing 4]
        public static void Contain4()
         {
            var numbers = new int[] { 25648, 488884, 25684, 14, 141, 45962896, 24441,21, 53464, 42424 };
            var linq01 = (from n in numbers
                          let str = n.ToString()
                          where str[0] !='4' && str[str.Length-1] !='4' && str.Contains("4")
                          select n ).ToList();

            // Show the results:
            Console.WriteLine("Numbers containing '4' after removing first and last character:");
            foreach (var n in linq01)
            {
                Console.WriteLine(n);
            }
         }
        #endregion


    }
}

using System;
using System.IO;

namespace monday
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootPath = @"C:\Users\martv\Desktop\samples";
            
            Getdirectories(rootPath);
            getFiles(rootPath);
        }
        public static void Getdirectories(string path)
        {
            string[] allDirectories = Directory.GetDirectories(path, "*", SearchOption.AllDirectories);
            string filePath = @"C:\Users\martv\Desktop\Monady\directoriesData.txt";

            File.WriteAllLines(filePath, allDirectories);

        }
        public static void getFiles(string path)
        {
            string[] allFiles = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories);
            string filePath = @"C:\Users\martv\Desktop\Monady\filesData.txt";
            File.WriteAllLines(filePath, allFiles);
        }
    }
}

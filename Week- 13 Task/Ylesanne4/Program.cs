using System;


namespace Ylesanne2
{
    class Program
    {
        static void Main(string[] args)
        {
            string newDirectory = "Stars.txt";
            CreateMyDirectory(newDirectory);
            string newDirectory = "planes.txt";
            CreateMyDirectory(newdirectory);
        }

        private static void CreateMyDirectory(string myDirecotryName)
        {
            string rootDirectody = @"C:\Users\opilane\samples\stats.txt";

            string rootDirectory = @"C:\Users\opilane\samples\planetd.txt";


            string directoryFullPath = $@"{rootDirectory}\{myDirectoryNqme}.";
            
            
            if (directoryFullPath.Exists(direcotryFullPath))
            {
                Console.WriteLine($"Directory {myDirectoryName} already exists in {rootDirectory}.");
            }
            else
            {
                directoryFullPath.CreateDirecotry(directoryFullPath);
                Console.WriteLine($"Directory {myDirectoryName} has been created.");
            }
                   
            
        }
    }
}

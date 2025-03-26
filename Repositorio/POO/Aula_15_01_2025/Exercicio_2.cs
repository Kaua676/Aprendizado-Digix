using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_15_01_2025
{
    public class Exercicio_2
    {
        static void Main(string[] args)
        {
            string sourceFilePath = @"C:\Users\kauavicente\Desktop\Folder\file.docx";
            FileInfo sourceFile = new FileInfo(sourceFilePath);

            string targetFolderPath = Path.Combine(sourceFile.DirectoryName, "out");
            Directory.CreateDirectory(targetFolderPath);

            string targetFilePath = Path.Combine(targetFolderPath, "summary.docx");

            try
            {
                using (var reader = new StreamReader(sourceFile.FullName))
                using (var writer = new StreamWriter(targetFilePath))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        writer.WriteLine(line);
                    }
                }
            }
            catch (IOException e)
            {
                System.Console.WriteLine("An error occurred: " + e.Message);
            }
        }
    }
}

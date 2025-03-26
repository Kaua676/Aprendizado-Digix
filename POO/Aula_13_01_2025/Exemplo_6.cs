using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_13_01_2025
{
    public class Exemplo_6
    {
        static void Main(string[] args)
        {
            string inicio_path = @"C:\Users\kauavicente\Desktop\filereader 1.txt";
            System.Console.WriteLine("Directory Separator Char: " + Path.DirectorySeparatorChar);
            System.Console.WriteLine("Path Separator Char: " + Path.PathSeparator);
            System.Console.WriteLine("Retorna o diretorio do arquivo: " + Path.GetDirectoryName(inicio_path));
            System.Console.WriteLine("Retorna o nome do arquivo: " + Path.GetFileName(inicio_path));
            System.Console.WriteLine("Retorna a extensão do arquivo: " + Path.GetExtension(inicio_path));
            System.Console.WriteLine("Retorna o nome do arquivo sem extensão: " + Path.GetFileNameWithoutExtension(inicio_path));
        }
    }
}
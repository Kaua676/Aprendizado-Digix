using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio_1
{
    public class Executar
    {
        static void Main(string[] args)
        {
            Crud crud = new Crud();
            // Chamando usuario
            crud.ListarUsuario();
            System.Console.WriteLine("------------------");

            System.Console.WriteLine("Inserindo um novo usuário");
            crud.InserirUsuario(1, "12345", "Kauã", 239, "Gerente");
            crud.ListarUsuario();
            System.Console.WriteLine("-------------------");

            System.Console.WriteLine("Atualizando um usuário");
            crud.AtualizarUsuario(1, "Kauã Vicente");

            crud.ListarUsuario();
            System.Console.WriteLine("-------------------");

            System.Console.WriteLine("Deletando um usuário");
            crud.DeletarUsuario(1);
            crud.ListarUsuario();
            System.Console.WriteLine("-------------------");


            // Chamando maquina
            crud.ListarMaquina();
            System.Console.WriteLine("------------------");

            System.Console.WriteLine("Inserindo uma nova maquina");
            crud.InserirMaquina(1, "Desktop", 2, 500, 1, 4, 1);
            crud.ListarMaquina();
            System.Console.WriteLine("-------------------");

            System.Console.WriteLine("Atualizando uma maquina");
            crud.AtualizarMaquina(1, "Notebook");

            crud.ListarMaquina();
            System.Console.WriteLine("-------------------");

            System.Console.WriteLine("Deletando uma maquina");
            crud.DeletarMaquina(1);
            crud.ListarMaquina();
            System.Console.WriteLine("-------------------");

            // Chamando software
            crud.ListarSoftware();
            System.Console.WriteLine("------------------");

            System.Console.WriteLine("Inserindo um novo software");
            crud.InserirSoftware(1, "Windows", 100, 2, 1);
            crud.ListarSoftware();
            System.Console.WriteLine("-------------------");

            System.Console.WriteLine("Atualizando um software");
            crud.AtualizarSoftware(1, "Linux");

            crud.ListarSoftware();
            System.Console.WriteLine("-------------------");

            System.Console.WriteLine("Deletando um software");
            crud.DeletarSoftware(1);
            crud.ListarSoftware();
            System.Console.WriteLine("-------------------");
        }
    }
}
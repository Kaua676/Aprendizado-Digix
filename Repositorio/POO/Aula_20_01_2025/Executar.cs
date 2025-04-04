using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio4
{

    public class Executar
    {
        static void Main(string[] args)
        {
            string filePath = "usuarios.csv"; // Caminho do arquivo CSV
            bool isLoggedIn = false;

            while (!isLoggedIn)
            {
                Console.WriteLine("=== Sistema de Login ===");
                Console.Write("Digite seu nome: ");
                string inputNome = Console.ReadLine();

                Console.Write("Digite sua senha: ");
                string inputSenha = Console.ReadLine();

                (string cargo, string nome) = VerificarLogin(filePath, inputNome, inputSenha);

                if (cargo != null)
                {
                    isLoggedIn = true;
                    Console.WriteLine($"\nBem-vindo, {nome}!");

                    Usuario menu = cargo == "admin" ? new Administrador(nome) : new Eleitor(inputNome, inputSenha, cargo);
                    if (cargo == "admin")
                    {
                        menu.ExibirMenu();

                        // menu.ExibirMenu();
                    }
                    else
                    {
                        Console.WriteLine("\nCredenciais inválidas. Tente novamente.\n");
                    }
                }
            }

            static (string cargo, string nome) VerificarLogin(string filePath, string nome, string senha)
            {
                try
                {
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        string header = reader.ReadLine(); // Ignorar o cabeçalho
                        while (!reader.EndOfStream)
                        {
                            string line = reader.ReadLine();
                            string[] values = line.Split(',');

                            string csvNome = values[1];   // Nome na segunda coluna
                            string csvSenha = values[3]; // Senha na quarta coluna
                            string csvCargo = values[2]; // Cargo na terceira coluna

                            return (csvCargo, csvNome);

                            // if (csvNome.Equals(nome, StringComparison.OrdinalIgnoreCase) && csvSenha == senha)
                            // {
                            //     return (csvCargo, csvNome);
                            // }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro: {ex.Message}");
                    Environment.Exit(1);
                }

                return (null, null);
            }
        }
    }
}
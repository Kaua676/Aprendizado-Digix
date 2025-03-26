using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;

namespace Aula_15_01_2025
{
    public class Exercicio_1
    {
        static void Main(string[] args)
        {
            // Caminho do arquivo de origem e de destino
            string sourceFilePath = @"C:\Users\kauavicente\Desktop\Folder\file.csv";
            FileInfo sourceFile = new FileInfo(sourceFilePath);

            string targetFolderPath = Path.Combine(sourceFile.DirectoryName, "out");
            Directory.CreateDirectory(targetFolderPath);

            string targetFilePath = Path.Combine(targetFolderPath, "summary.csv");

            try
            {
                using (var reader = new StreamReader(sourceFile.FullName))
                using (var csvReader = new CsvReader(reader, CultureInfo.InvariantCulture))
                using (var writer = new StreamWriter(targetFilePath))
                using (var csvWriter = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    // Escrever cabeçalho do CSV
                    csvWriter.WriteHeader<Summary>();
                    csvWriter.NextRecord();

                    while (csvReader.Read())
                    {
                        string name = csvReader.GetField(0);
                        double price = csvReader.GetField<double>(1);
                        int quantity = csvReader.GetField<int>(2);
                        double total = price * quantity;

                        // Escrever os registros no arquivo de saída
                        csvWriter.WriteRecord(new Summary { Name = name, Total = total });
                        csvWriter.NextRecord();
                    }
                }

                Console.WriteLine($"Arquivo gerado com sucesso em: {targetFilePath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }

            try
            {
                string encryptedFile = @"C:\Users\kauavicente\Desktop\Folder\arquivo_encriptado.csv";
                string decryptedFile = @"C:\Users\kauavicente\Desktop\Folder\arquivo_desencriptado.csv";

                string password = "1234"; // Senha para encriptação

                // Encriptar o arquivo
                // EncryptFile é um método que criamos para encriptar um arquivo
                EncryptFile(sourceFilePath, encryptedFile, password); // Encripta o arquivo
                Console.WriteLine("Arquivo encriptado criado."); // Mensagem de confirmação

                // Desencriptar o arquivo
                DecryptFile(encryptedFile, decryptedFile, password);
                Console.WriteLine("Arquivo desencriptado criado.");
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Erro: " + ex.Message);
            }
        }

        static void EncryptFile(string sourceFilePath, string outputFilePath, string password)
        {
            // Encoding.UTF8.GetBytes converte a senha em bytes
            // password.PadRight(32) garante que a senha tenha pelo menos 32 caracteres
            // Substring(0, 32) garante que a senha tenha no máximo 32 caracteres
            // Gera uma chave de 256 bits
            byte[] key = Encoding.UTF8.GetBytes(password.PadRight(32).Substring(0, 32)); // Gera uma chave de 256 bits
            // iv é referente ao vetor de inicialização
            // Gera um IV de 128 bits
            byte[] iv = Encoding.UTF8.GetBytes(password.PadRight(16).Substring(0, 16)); // Gera um IV de 128 bits

            using (Aes aes = Aes.Create()) // Cria uma instância de AES
            {
                aes.Key = key; // Define a chave
                aes.IV = iv; // Define o IV

                // Abre o arquivo de entrada
                using (FileStream inputFileStream = new FileStream(sourceFilePath, FileMode.Open)) // Abre o arquivo de entrada
                using (FileStream outputFileStream = new FileStream(outputFilePath, FileMode.Create)) // Abre o arquivo de saída
                using (CryptoStream cryptoStream = new CryptoStream(outputFileStream, aes.CreateEncryptor(), CryptoStreamMode.Write)) // Cria um CryptoStream
                {
                    inputFileStream.CopyTo(cryptoStream); // Copia o conteúdo do arquivo de entrada para o CryptoStream
                }
            }
        }

        static void DecryptFile(string sourceFilePath, string outputFilePath, string password)
        {
            byte[] key = Encoding.UTF8.GetBytes(password.PadRight(32).Substring(0, 32)); // Gera uma chave de 256 bits
            byte[] iv = Encoding.UTF8.GetBytes(password.PadRight(16).Substring(0, 16)); // Gera um IV de 128 bits

            using (Aes aes = Aes.Create()) // Cria uma instância de AES
            {
                aes.Key = key; // Define a chave
                aes.IV = iv; // Define o IV

                using (FileStream inputFileStream = new FileStream(sourceFilePath, FileMode.Open))
                using (FileStream outputFileStream = new FileStream(outputFilePath, FileMode.Create))
                using (CryptoStream cryptoStream = new CryptoStream(inputFileStream, aes.CreateDecryptor(), CryptoStreamMode.Read))
                {
                    cryptoStream.CopyTo(outputFileStream);
                }
            }
        }
    }

    public class Summary
    {
        public string Name { get; set; }
        public double Total { get; set; }
    }
}
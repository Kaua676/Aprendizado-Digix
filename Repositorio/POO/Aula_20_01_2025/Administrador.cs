using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace Desafio4
{
    public class Administrador : Usuario, IPersistencia
    {
        public string Password { get; private set; } = "adm";

        public Administrador(string nome) : base(nome, "Administrador") { }

        public void CriarEleicao(string nome, DateTime dataInicial, DateTime dataFinal, ECargosEmDisputa cargos)
        {
            Eleicao eleicao = new Eleicao(nome, dataInicial, dataFinal, cargos);
            Console.WriteLine($"Eleição '{nome}' criada com sucesso!");
        }

        public void CadastrarCandidato(string nome, ECargosEmDisputa cargo, int numeroIdentificador)
        {
            Candidato candidato = new Candidato(nome, cargo, numeroIdentificador);
            Console.WriteLine($"Candidato '{nome}' cadastrado no cargo de {cargo}.");
        }

        public void GerarRelatorio(Eleicao eleicao)
        {
            Console.WriteLine($"Relatório da Eleição: {eleicao.Nome}");
            foreach (var grupo in eleicao.Votos.GroupBy(v => v.Candidato.Nome))
            {
                Console.WriteLine($"Candidato: {grupo.Key}, Votos: {grupo.Count()}");
            }
        }

        // Persistência
        public void SalvarVotosEncriptados(string inputFilePath, string outputFilePath, string password)
        {
            byte[] key = System.Text.Encoding.UTF8.GetBytes(password.PadRight(32).Substring(0, 32));
            byte[] iv = System.Text.Encoding.UTF8.GetBytes(password.PadRight(16).Substring(0, 16));

            using Aes aes = Aes.Create();
            aes.Key = key;
            aes.IV = iv;

            using FileStream inputFileStream = new FileStream(inputFilePath, FileMode.Open);
            using FileStream outputFileStream = new FileStream(outputFilePath, FileMode.Create);
            using CryptoStream cryptoStream = new CryptoStream(outputFileStream, aes.CreateEncryptor(), CryptoStreamMode.Write);

            inputFileStream.CopyTo(cryptoStream);
            Console.WriteLine("Votos encriptados salvos com sucesso.");
        }

        public void CarregarResultadoDesencriptado(string inputFilePath, string outputFilePath, string password)
        {
            byte[] key = System.Text.Encoding.UTF8.GetBytes(password.PadRight(32).Substring(0, 32));
            byte[] iv = System.Text.Encoding.UTF8.GetBytes(password.PadRight(16).Substring(0, 16));

            using Aes aes = Aes.Create();
            aes.Key = key;
            aes.IV = iv;

            using FileStream inputFileStream = new FileStream(inputFilePath, FileMode.Open);
            using FileStream outputFileStream = new FileStream(outputFilePath, FileMode.Create);
            using CryptoStream cryptoStream = new CryptoStream(inputFileStream, aes.CreateDecryptor(), CryptoStreamMode.Read);

            cryptoStream.CopyTo(outputFileStream);
            Console.WriteLine("Resultado desencriptado carregado com sucesso.");
        }
        
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_10_01_2025
{
    public struct PessoaStruct
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public PessoaStruct(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public override string ToString()
        {
            return "Nome: " + Nome + ", Idade: " + Idade;
        }
    }

    public class PessoaClasse
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public PessoaClasse(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public override string ToString()
        {
            return "Nome: " + Nome + ", Idade: " + Idade;
        }
    }

    class ExecutarExe
    {
        static void ExecutarExemplo()
        {
            // Trabalha com PessoaStruct
            PessoaStruct pessoaStruct1 = new PessoaStruct("Joaquim", 30);
            PessoaStruct pessoaStruct2 = pessoaStruct1;
            pessoaStruct2.Idade = 40;
            System.Console.WriteLine(pessoaStruct1);
            System.Console.WriteLine(pessoaStruct2);

            // Trabalha com PessoaClasse
            PessoaClasse pessoaClasse1 = new PessoaClasse("Joaquim", 30);
            PessoaClasse pessoaClasse2 = pessoaClasse1;
            pessoaClasse2.Idade = 40;
            System.Console.WriteLine(pessoaClasse1);
            System.Console.WriteLine(pessoaClasse2);

            // 1. Struct é um tipo de valor, entao atribuições criam copias independentes
            // 2. Classes é um tipo de referência, entao atribuições criam referências para o mesmo objeto
            // 3. Structs são mais leves e geralmente são usados parados simples e imutaveis
            // 4. Classes são mais adequadas para objetos complexos e com estados mutaveis e comportamentos complexos

        }
    }
}

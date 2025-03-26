using System;

namespace Exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Digite um DDD: ");
            int ddd = int.Parse(Console.ReadLine());

            switch (ddd)
            {
                case 11:
                    Console.WriteLine("São Paulo - SP");
                    break;
                case 12:
                    Console.WriteLine("São Paulo - SP (Vale do Paraíba)");
                    break;
                case 13:
                    Console.WriteLine("São Paulo - SP (Baixada Santista)");
                    break;
                case 14:
                    Console.WriteLine("São Paulo - SP (Bauru)");
                    break;
                case 15:
                    Console.WriteLine("São Paulo - SP (Sorocaba)");
                    break;
                case 16:
                    Console.WriteLine("São Paulo - SP (Ribeirão Preto)");
                    break;
                case 17:
                    Console.WriteLine("São Paulo - SP (São José do Rio Preto)");
                    break;
                case 18:
                    Console.WriteLine("São Paulo - SP (Presidente Prudente)");
                    break;
                case 19:
                    Console.WriteLine("São Paulo - SP (Campinas)");
                    break;

                case 21:
                    Console.WriteLine("Rio de Janeiro - RJ");
                    break;
                case 22:
                    Console.WriteLine("Rio de Janeiro - RJ (interior)");
                    break;
                case 24:
                    Console.WriteLine("Rio de Janeiro - RJ (região dos Lagos)");
                    break;

                case 27:
                    Console.WriteLine("Espírito Santo - ES");
                    break;
                case 28:
                    Console.WriteLine("Espírito Santo - ES (interior)");
                    break;

                case 31:
                    Console.WriteLine("Minas Gerais - MG (Belo Horizonte)");
                    break;
                case 32:
                    Console.WriteLine("Minas Gerais - MG (Juiz de Fora)");
                    break;
                case 33:
                    Console.WriteLine("Minas Gerais - MG (Varginha)");
                    break;
                case 34:
                    Console.WriteLine("Minas Gerais - MG (Uberlândia)");
                    break;
                case 35:
                    Console.WriteLine("Minas Gerais - MG (Divinópolis)");
                    break;
                case 37:
                    Console.WriteLine("Minas Gerais - MG (Passos)");
                    break;

                case 41:
                    Console.WriteLine("Paraná - PR (Curitiba)");
                    break;
                case 42:
                    Console.WriteLine("Paraná - PR (Ponta Grossa)");
                    break;
                case 43:
                    Console.WriteLine("Paraná - PR (Londrina)");
                    break;
                case 44:
                    Console.WriteLine("Paraná - PR (Maringá)");
                    break;
                case 45:
                    Console.WriteLine("Paraná - PR (Foz do Iguaçu)");
                    break;
                case 46:
                    Console.WriteLine("Paraná - PR (Cascavel)");
                    break;

                case 51:
                    Console.WriteLine("Rio Grande do Sul - RS (Porto Alegre)");
                    break;
                case 53:
                    Console.WriteLine("Rio Grande do Sul - RS (Pelotas)");
                    break;
                case 54:
                    Console.WriteLine("Rio Grande do Sul - RS (Caxias do Sul)");
                    break;
                case 55:
                    Console.WriteLine("Rio Grande do Sul - RS (Santa Maria)");
                    break;

                case 61:
                    Console.WriteLine("Distrito Federal - DF (Brasília)");
                    break;

                case 62:
                    Console.WriteLine("Goiás - GO");
                    break;
                case 64:
                    Console.WriteLine("Goiás - GO (interior)");
                    break;

                case 63:
                    Console.WriteLine("Tocantins - TO");
                    break;

                case 65:
                    Console.WriteLine("Mato Grosso - MT");
                    break;
                case 66:
                    Console.WriteLine("Mato Grosso - MT (interior)");
                    break;

                case 67:
                    Console.WriteLine("Mato Grosso do Sul - MS");
                    break;

                case 68:
                    Console.WriteLine("Acre - AC");
                    break;
                case 69:
                    Console.WriteLine("Acre - AC (interior)");
                    break;

                case 71:
                    Console.WriteLine("Bahia - BA (Salvador)");
                    break;
                case 73:
                    Console.WriteLine("Bahia - BA (Feira de Santana)");
                    break;
                case 74:
                    Console.WriteLine("Bahia - BA (Juazeiro)");
                    break;
                case 75:
                    Console.WriteLine("Bahia - BA (Itabuna)");
                    break;
                case 77:
                    Console.WriteLine("Bahia - BA (interior)");
                    break;

                case 81:
                    Console.WriteLine("Pernambuco - PE (Recife)");
                    break;
                case 82:
                    Console.WriteLine("Alagoas - AL (Maceió)");
                    break;

                case 83:
                    Console.WriteLine("Paraíba - PB (João Pessoa)");
                    break;
                case 84:
                    Console.WriteLine("Rio Grande do Norte - RN (Natal)");
                    break;
                case 85:
                    Console.WriteLine("Ceará - CE (Fortaleza)");
                    break;

                case 86:
                    Console.WriteLine("Piauí - PI (Teresina)");
                    break;
                case 87:
                    Console.WriteLine("Pernambuco - PE (Caruaru)");
                    break;

                case 88:
                    Console.WriteLine("Ceará - CE (interior)");
                    break;

                case 89:
                    Console.WriteLine("Piauí - PI (interior)");
                    break;

                case 91:
                    Console.WriteLine("Pará - PA (Belém)");
                    break;
                case 92:
                    Console.WriteLine("Amazonas - AM (Manaus)");
                    break;
                case 93:
                    Console.WriteLine("Pará - PA (interior)");
                    break;
                case 94:
                    Console.WriteLine("Pará - PA (interior)");
                    break;
                case 95:
                    Console.WriteLine("Roraima - RR");
                    break;
                case 96:
                    Console.WriteLine("Amapá - AP");
                    break;
                case 97:
                    Console.WriteLine("Amazonas - AM (interior)");
                    break;
                case 98:
                    Console.WriteLine("Maranhão - MA");
                    break;
                case 99:
                    Console.WriteLine("Maranhão - MA (interior)");
                    break;

                default:
                    Console.WriteLine("DDD não reconhecido. Por favor, verifique e tente novamente.");
                    break;
            }
        }
    }
}
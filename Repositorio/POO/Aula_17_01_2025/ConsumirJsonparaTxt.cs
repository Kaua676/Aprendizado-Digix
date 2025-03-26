using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace Aula_17_01_2025
{
    public class ConsumirJsonparaTxt
    {
        static async Task Main(string[] args)
        {
            string url = "https://raw.githubusercontent.com/manami-project/anime-offline-database/master/anime-offline-database-minified.json";

            string nomeArquivo = "anime-offline-database.txt";
            try
            {
                // HttpClient é uma classe que permite fazer requisições HTTP
                using (HttpClient client = new HttpClient())
                {
                    // Faz a requisição GET para obter o arquivo JSON
                    var response = await client.GetAsync(url);

                    var responseString = await response.Content.ReadAsStringAsync();

                    // Deixa o Json em estrutura dinamica que é o JArray
                    using (JsonDocument document = JsonDocument.Parse(responseString))
                    {
                        var animeList = document.RootElement.GetProperty("data");

                        // Função que grava todas as informações do Json e salva em um txt
                        SalvaremTXT(animeList, nomeArquivo);
                    }

                    System.Console.WriteLine("Arquivo criado com sucesso!");
                }
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }
        }

        static void SalvaremTXT(JsonElement animeList, string nomeArquivo)
        {
            using (StreamWriter writer = new StreamWriter(nomeArquivo))
            {
                foreach (JsonElement anime in animeList.EnumerateArray())
                {
                    writer.WriteLine($"Nome: {anime.GetProperty("name").GetString()}");
                    writer.WriteLine($"Episodios: {anime.GetProperty("episodes").GetString()}");
                    writer.WriteLine($"Estudio: {anime.GetProperty("studio").GetString()}");
                    writer.WriteLine($"Genero: {anime.GetProperty("genres").GetString()}");
                    writer.WriteLine($"Sinopse: {anime.GetProperty("synopsis").GetString()}");
                }

            }
        }
    }
}
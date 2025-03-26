namespace Aula_4
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Digite o valor inicial: ");
            int inicio = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite o valor final: ");
            int final = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Tamanho: " + (final - inicio));
        }
    }
}
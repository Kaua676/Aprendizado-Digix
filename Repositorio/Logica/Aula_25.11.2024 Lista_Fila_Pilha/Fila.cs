// using System;

// namespace XXXXXXX
// {
//     public class Fila
//     {

//         static int[] fila = new int[10];

//         static int inicio = 0; //Inicio da fila

//         static int fim = 0; //Fim da fila

//         static int count = 0; //Contador de quantidade de elemtnso na fila

//         //Adicionar um elemento na fila, enqueue
//         public static void Adicionar(int valor)
//         {
//             if (count < fila.Length)
//             {
//                 fila[fim] = valor;
//                 fim = (fim + 1) % fila.Length;
//                 count++; //Incrementa a quadidade de elementos na fila
//             }
//             else
//             {
//                 System.Console.WriteLine("Fila cheia!");
//             }
//         }

//         public static void Remover()
//         {
//             if (count > 0)
//             {
//                 fila[inicio] = 0;
//                 inicio = (inicio + 1) % fila.Length;
//                 count--;
//             }
//             else
//             {
//                 System.Console.WriteLine("Fila vazia!");
//             }
//         }

//         public static void Listar()
//         {
//             for (int i = 0; i < count; i++)
//             {
//                 System.Console.WriteLine(fila[(inicio + i) % fila.Length]);
//             }
//         }

//         public static void Primeiro()
//         {
//             if (count > 0)
//             {
//                 System.Console.WriteLine(fila[inicio]);
//             }
//             else
//             {
//                 System.Console.WriteLine("Fila vazia!");
//             }
//         }

//         static void Main(string[] args)
//         {
//             Adicionar(10);
//             Adicionar(20);
//             Adicionar(30);
//             Adicionar(40);
//             Adicionar(50);
//             Adicionar(60);
//             Adicionar(70);
//             Adicionar(80);
//             Adicionar(90);
//             Adicionar(100);

//             Listar();

//             System.Console.WriteLine("Primeiro elemento da fila: ");
//             Primeiro();

//             Remover();

//             Listar();
//         }
//     }
// }
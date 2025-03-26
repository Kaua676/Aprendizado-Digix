// using System;

// namespace XXXXXXX
// {
//     public class ListaEncadeadaDelegate
//     {

//         static delegate void FuncaoDelegate(int valor);

//         static FuncaoDelegate? inicio = null;

//         static FuncaoDelegate CriarNo(int valor, FuncaoDelegate? proximo)
//         {
//             return v =>
//             {
//                 System.Console.WriteLine(valor);
//                 proximo?. Invoke(v);
//             }
//         }

//         static void Main(string[] args)
//         {

//         }
//     }
// }
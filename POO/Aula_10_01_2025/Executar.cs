using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_10_01_2025
{
    public class Executar
    {
        public struct Point
        {
            public int X { get; set; }
            public int Y { get; set; }

            // Construtor no struct é obrigatorio inicializar todos os campos e ter parametros neles
            public Point(int x, int y)
            {
                X = x;
                Y = y;
            }

            public double CalcularDistancia(Point outroPonto)
            {
                X = 10; // Isso não é permitido em um metodo de struct pois ele é um tipo de valor
                // Não se tem modificador de estado em um struct
                return Math.Sqrt((X - outroPonto.X) * (X - outroPonto.X) + (Y - outroPonto.Y) * (Y - outroPonto.Y));
            }

            public class Player
            {
                public string Name { get; set; }
                public Point Position { get; set; }

                public Player(string name, Point position)
                {
                    Name = name;
                    Position = position;
                }

                public void Move(Point newPosition)
                {
                    Position = newPosition;
                }
            }

            public class Executar
            {
                public static void ExecutarExemplo()
                {
                    Point p1 = new Point(10, 20);
                    Point p2 = new Point(30, 40);

                    System.Console.WriteLine($"Distância entre p1 e p2: {p1.CalcularDistancia(p2)}");

                    Player player = new Player("Jogador 1", p1);
                    System.Console.WriteLine($"Posição do jogador: ({player.Position.X}, {player.Position.Y})");

                    player.Move(p2);
                    System.Console.WriteLine($"Posição do jogador depois de se mover: ({player.Position.X}, {player.Position.Y})");

                    
                }
            }
        }
    }
}
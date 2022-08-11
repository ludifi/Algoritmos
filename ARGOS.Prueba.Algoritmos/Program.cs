
namespace ARGOS.Prueba.Algoritmos
{
    using System;

    /// <summary>
    /// Class program
    /// </summary>
    public static class Program
    {
        public static void Main()
        {
            Console.Write("Ingrese tamaño de escalera: ");

            ///Validate is int
            bool isNumber = int.TryParse(Console.ReadLine().Trim(), out int size);
            if (isNumber)
            {
                ///Validate int between values
                if (size > 0 && size < 100)
                {
                    string[,] ladder = Staircase(size);
                    PrintStaircase(ladder);
                }
                else
                {
                    Console.Write("Tamaño no permitido (mayor a 0 y menor que 100");
                }
            }
            else
            {
                Console.Write("Tamaño ingresado debe ser un entero ");
            }

            Console.ReadLine();
        }

        /// <summary>
        /// Staircases the specified size.
        /// </summary>
        /// <param name="size">The size</param>
        public static string[,] Staircase(int size)
        {
            string[,] ladder = new string[size, size];

            for (int row = 0; row < ladder.GetLength(0); row++)
            {
                for (int col = 1; col <= row + 1; col++)
                {
                    ladder[row, size - col] = "#";
                }
            }

            return ladder;
        }

        /// <summary>
        /// Print Staircase
        /// </summary>
        /// <param name="ladder"></param>
        public static void PrintStaircase(string[,] ladder)
        {
            for (int row = 0; row < ladder.GetLength(0); row++)
            {
                for (int col = 0; col < ladder.GetLength(1); col++)
                {
                    Console.Write("{0}", ladder[row, col] ?? " ");
                }
                Console.WriteLine();
            }
        }
    }
}

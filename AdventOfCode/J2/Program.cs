using System;
using System.IO;

namespace J2
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputs = File.ReadAllLines("input.txt");

            var position = new Position();

            foreach (var input in inputs)
            {
                var inputsplitted = input.Split(" ");

                if (inputsplitted[0].Contains("forward"))
                {
                    position.Forward(int.Parse(inputsplitted[1]));
                }

                if (inputsplitted[0].Contains("down"))
                {
                    position.Down(int.Parse(inputsplitted[1]));
                }

                if (inputsplitted[0].Contains("up"))
                {
                    position.Up(int.Parse(inputsplitted[1]));
                }
            }

            Console.WriteLine($"{position.GetResult()}");

            Console.WriteLine("Press any key to quit!");
            Console.ReadLine();
        }
    }
}

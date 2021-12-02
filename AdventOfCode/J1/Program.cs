using System;
using System.IO;

namespace J1
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputs = File.ReadAllLines("input.txt");

            // PART 1
            var n_part1 = 0;
            for (var i = 0; i < inputs.Length - 1; i++)
            {
                if (int.Parse(inputs[i + 1]) > int.Parse(inputs[i]))
                {
                    n_part1++;
                }
            }

            Console.WriteLine(n_part1);


            // PART 2
            var n_part2 = 0;
            for (var i = 0; i < inputs.Length - 3; i++)
            {
                var un = GetSommeDeTrois(i, inputs);
                var deux = GetSommeDeTrois(i + 1, inputs);


                if (un < deux)
                {
                    n_part2++;
                }
            }

            Console.WriteLine(n_part2);

            Console.WriteLine("Press any key to quit!");
            Console.ReadLine();
        }

        public static int GetSommeDeTrois(int i, string[] inputs)
        {
            var bla = int.Parse(inputs[i])
                    + int.Parse(inputs[i + 1])
                    + int.Parse(inputs[i + 2]);

            return bla;
        }
    }
}

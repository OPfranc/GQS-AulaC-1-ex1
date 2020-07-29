using System;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Console.WriteLine("Entre com a letra alvo");
                var a = Console.ReadKey().KeyChar;

                var diamond = new Diamond();
                Console.Clear();

                PrintDiamond(diamond.CreateDiamond(a));
            }

        }

        static void PrintDiamond(string[] diamond){

           foreach (var line in diamond)
           {
               Console.WriteLine(line);
           }
        }
    }
}

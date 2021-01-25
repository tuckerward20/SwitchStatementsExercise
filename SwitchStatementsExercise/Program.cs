using System;

namespace SwitchStatementsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite subject?");
            var favSubject = Console.ReadLine();

            switch (favSubject)
            {
                case "Math":
                    Console.WriteLine("Rich Nerd");
                    break;
                case "Science":
                    Console.WriteLine("Nerd");
                    break;
                case "English":
                    Console.WriteLine("Poor Nerd");
                    break;
                case "History":
                    Console.WriteLine("Really Poor Nerd");
                    break;
                case "Philosophy":
                    Console.WriteLine("Poor Nerd?");
                    break;
                default:
                    Console.WriteLine("Try Math, Science, English, History or Philosophy");
                    break;
            }
                
        }
    }
}

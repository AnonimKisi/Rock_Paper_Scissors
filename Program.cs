//Made by AnonimKisi
using System;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            Console.Title = "Made by AnonimKisi";
            Thread.Sleep(20);
            Console.WriteLine("-----------------------");
            Random random = new Random();
            int random_number = random.Next(1,4);
            Console.WriteLine("1. Rock\n2. Paper\n3. Scissors\n");
            Console.Write("input: ");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            switch(input)
            {
                case 1:
                    if(random_number == 2)
                    {
                        Console.WriteLine("Opponent: I draw paper. I win.");
                        Main();
                    }else if(random_number == 1)
                    {
                        Console.WriteLine("Opponent: I draw rock. Draw.");
                        Main();
                    }else if (random_number == 3)
                    {
                        Console.WriteLine("Opponent: I draw scissors. You win.");
                        Main();
                    }else
                        {
                        Console.WriteLine("ERROR");
                    }
                    break;

                case 2:
                    if (random_number == 3)
                    {
                        Console.WriteLine("Opponent: I draw scissors. I win.");
                        Main();
                    }else if (random_number == 2)
                    {
                        Console.WriteLine("Opponent: I draw paper. Draw.");
                        Main();
                    }else if (random_number == 1)
                    {
                        Console.WriteLine("Opponent: I draw rock. You win.");
                        Main();
                    }else
                    {
                        Console.WriteLine("ERROR");
                    }
                    break;

                case 3:
                    if (random_number == 3)
                    {
                        Console.WriteLine("Opponent: I draw scissors. Draw.");
                        Main();
                    }else if (random_number == 2)
                    {
                        Console.WriteLine("Opponent: I draw paper. You win.");
                        Main();
                    }else if (random_number == 1)
                    {
                        Console.WriteLine("Opponent: I draw rock. I win.");
                        Main();
                    }
                    break;

                default:
                    Console.WriteLine("Choose between 1 and 3.");                    
                    Main();
                    break;
            }
            /*Console.WriteLine(random_number);
            Console.ReadKey();
            Main();*/
            Console.ReadKey();
        }
    }
}
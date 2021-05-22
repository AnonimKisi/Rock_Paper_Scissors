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

            int p = 0, o = 0, a = 0;

            start:

            if (p == 3 || o == 3)
            {
                dontfuckwithme:
                Console.Write("Do you want to play again? (1: yes/2: no) ");
                a = Convert.ToInt32(Console.ReadLine());
                switch (a)
                {
                    case 1:
                        p = 0; o = 0; a = 0;
                        goto start;
                    case 2:
                        goto exit;
                    default:
                        goto dontfuckwithme;
                }
            }
            else
            {              
                Thread.Sleep(20);
                Console.WriteLine("-----------------------");
                Random random = new Random();
                int random_number = random.Next(1, 4);

                Console.WriteLine("1. Rock\n2. Paper\n3. Scissors\n");

                Console.Write("input: ");
                int input = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();
                switch (input)
                {
                    case 1:
                        if (random_number == 2)
                        {
                            Console.WriteLine("Opponent: I draw paper. I win.");
                            o = o + 1;
                            Console.WriteLine("Opponent: {0} || You: {1}", o, p);
                            goto start;
                        }
                        else if (random_number == 1)
                        {
                            Console.WriteLine("Opponent: I draw rock. Draw.");
                            Console.WriteLine("Opponent: {0} || You: {1}", o, p);
                            goto start;
                        }
                        else if (random_number == 3)
                        {
                            Console.WriteLine("Opponent: I draw scissors. You win.");
                            p = p + 1;
                            Console.WriteLine("Opponent: {0} || You: {1}", o, p);
                            goto start;
                        }
                        else
                        {
                            Console.WriteLine("ERROR");
                        }
                        break;

                    case 2:
                        if (random_number == 3)
                        {
                            Console.WriteLine("Opponent: I draw scissors. I win.");
                            o = o + 1;
                            Console.WriteLine("Opponent: {0} || You: {1}", o, p);
                            goto start;
                        }
                        else if (random_number == 2)
                        {
                            Console.WriteLine("Opponent: I draw paper. Draw.");
                            Console.WriteLine("Opponent: {0} || You: {1}", o, p);
                            goto start;
                        }
                        else if (random_number == 1)
                        {
                            Console.WriteLine("Opponent: I draw rock. You win.");
                            p = p + 1;
                            Console.WriteLine("Opponent: {0} || You: {1}", o, p);
                            goto start;
                        }
                        else
                        {
                            Console.WriteLine("ERROR");
                        }
                        break;

                    case 3:
                        if (random_number == 3)
                        {
                            Console.WriteLine("Opponent: I draw scissors. Draw.");
                            Console.WriteLine("Opponent: {0} || You: {1}", o, p);
                            goto start;
                        }
                        else if (random_number == 2)
                        {
                            Console.WriteLine("Opponent: I draw paper. You win.");
                            p = p + 1;
                            Console.WriteLine("Opponent: {0} || You: {1}", o, p);
                            goto start;
                        }
                        else if (random_number == 1)
                        {
                            Console.WriteLine("Opponent: I draw rock. I win.");
                            o = o + 1;
                            Console.WriteLine("Opponent: {0} || You: {1}", o, p);
                            goto start;
                        }
                        else
                        {
                            Console.WriteLine("ERROR");
                        }
                        break;

                    default:
                        Console.WriteLine("Choose between 1 and 3.");
                        goto start;
                }
            }
            exit:
            Console.WriteLine("Click any button to exit");
            Console.ReadKey();
        }
    }
}

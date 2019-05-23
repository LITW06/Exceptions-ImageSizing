using System;

namespace ConsoleApp27
{
    class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            //    Console.WriteLine("Enter a number");
            //    int num = int.Parse(Console.ReadLine());

            //    Console.WriteLine(10 / num);

            //}

            //catch (FormatException ex)
            //{
            //    Console.WriteLine("Sorry, only numeric values allowed");
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine("Please not zero!");
            //}

            //catch (Exception ex)
            //{
            //    Console.WriteLine("I have no clue what went wrong");
            //}

            try
            {
                Function1();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error!! Here's the message");
                Console.WriteLine(ex.Message);
            }



            Console.ReadKey(true);
        }

        static void PrintNum(int num)
        {
            if (num == 11)
            {
                return;
            }

            Console.WriteLine(num);
            PrintNum(num + 1);
        }

        static void Function1()
        {
            Console.WriteLine("Start of function one");
            Function2();
            Console.WriteLine("End of function one");
        }

        static void Function2()
        {
            Console.WriteLine("Start of function two");
            try
            {
                Function3();
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Whew! caught it in time!");
            }

            Console.WriteLine("End of function two");
        }

        static void Function3()
        {
            Console.WriteLine("Start of function three");
            int u = 0;
            int y = 10 / u;
            Console.WriteLine("End of function three");
        }
    }
}

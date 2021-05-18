using System;

namespace BasicCalculator
{
    class Program
    {

        static void Main(string[] args)
        {
            menu();
        }

        //Addition
        static void option1()
        {
            Console.Write("\n\nPlease provide the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nPlease provide the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int total = num1 + num2;
            Console.WriteLine("\nThe answer is: " + total);
            Console.Write("\nDo you want to do another calculation? Y or N: ");
            string cont2 = Console.ReadLine();
            if (cont2 == "Y")
            {
                Console.WriteLine();
                menu();
            }
            else if (cont2 == "N")
            {
                Console.WriteLine("\nExiting the program!\nGoodbye!");
                System.Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("\nThis is the wrong option, You will be redirected to the option menu\n");
                menu();

            }

        }

        //Subtraction
        static void option2()
        {
            Console.Write("\n\nPlease provide the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nPlease provide the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int total = num1 - num2;
            Console.WriteLine("\nThe answer is: " + total);
            Console.Write("\nDo you want to do another calculation? Y or N: ");
            string cont2 = Console.ReadLine();
            if (cont2 == "Y")
            {
                Console.WriteLine();
                menu();
            }
            else if (cont2 == "N")
            {
                Console.WriteLine("\nExiting the program!\nGoodbye!");
                System.Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("\nThis is the wrong option, You will be redirected to the option menu\n");
                menu();

            }
        }

        //Multiplication
        static void option3()
        {
            Console.Write("\n\nPlease provide the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nPlease provide the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int total = num1 * num2;
            Console.WriteLine("\nThe answer is: " + total);
            Console.Write("\nDo you want to do another calculation? Y or N: ");
            string cont2 = Console.ReadLine();
            if (cont2 == "Y")
            {
                Console.WriteLine();
                menu();
            }
            else if (cont2 == "N")
            {
                Console.WriteLine("\nExiting the program!\nGoodbye!");
                System.Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("\nThis is the wrong option, You will be redirected to the option menu\n");
                menu();

            }
        }
        //Division
        static void option4()
        {
            Console.Write("\n\nPlease provide the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nPlease provide the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int total = num1 / num2;
            Console.WriteLine("\nThe answer is: " + total);
            Console.Write("\nDo you want to do another calculation? Y or N: ");
            string cont2 = Console.ReadLine();
            if (cont2 == "Y")
            {
                Console.WriteLine();
                menu();
            }
            else if (cont2 == "N")
            {
                Console.WriteLine("\nExiting the program!\nGoodbye!");
                System.Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("\nThis is the wrong option, You will be redirected to the option menu\n");
                menu();

            }
        }
        //Exiting program
        static void option5()
        {
            Console.WriteLine("\nYou are about to exit the program\nAre you sure?");
            Console.Write("Please reply with a Y or N: ");
            string cont1 = Console.ReadLine();
            if (cont1 == "Y")
            {
                Console.WriteLine("\nExiting the program!\nGoodbye!");
                System.Environment.Exit(0);
            }
            else if (cont1 == "N")
            {
                Console.WriteLine();
                menu();
            }
            else
            {
                Console.WriteLine("\nThis is the wrong option, Please provide the correct answer!\n");
                option5();
            }

        }

        //Menu
        static void menu()
        {
            Console.WriteLine("************Calculator************\n\n1: Addition\n2: Subtraction\n3: Multiplication\n4: Division\n5: Exit Program");
            Console.Write("Please provide the option number on the menu here: ");
            int option = Convert.ToInt32(Console.ReadLine());

            //addition
            if (option == 1)
            {
                option1();
            }
            //Subtraction
            else if (option == 2)
            {
                option2();
            }
            //Multiplication
            else if (option == 3)
            {
                option3();
            }
            //Division
            else if (option == 4)
            {
                option4();
            }
            //Exit program
            else if (option == 5)
            {
                option5();
            }
            //Wrong answer
            else
            {
                Console.WriteLine("\n\nThis is the wrong answer\nPlease try again\n");
                menu();
            }
        }
    }
}

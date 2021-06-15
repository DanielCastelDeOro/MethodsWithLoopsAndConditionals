using System;

namespace MethodsWithLoopsAndConditionals
{
    class Program
    {
        public static void by3EachTime()
        {
            var i = 3;
            while (i < 1000)
            {
                if (i % 3 == 0)
                    Console.WriteLine(i);
                i++;
            }
        }
        public static void negThowToPlus()
        {
            for (int dC = -1000; dC < 1001; dC++)
            {
                Console.WriteLine($"{dC}");
            }
        }

        public static void EvenOrOdd()
        {
            int num1, rem1;
            Console.WriteLine("\n\n");
            Console.WriteLine("Now lets check whether a number is even or odd:\n");
            Console.WriteLine("<------------==========-------------->");
            Console.WriteLine("\n\n");
            Console.WriteLine(" Please input an integer:");
            num1 = Convert.ToInt32(Console.ReadLine());
            rem1 = num1 % 2;
            if (rem1 == 0)
            {
                Console.WriteLine("{0} is an even integer.\n", num1);
            }
            else
            {
                Console.WriteLine("{0} is an odd integer.\n", num1);
            }
        }

        public static void EqualOrNot()
        {
            Console.WriteLine("Lets check if two different numbers are equal or not");
            Console.WriteLine("------------------000000-----------------");
            int numberOne, numberTwo;


            Console.WriteLine("Do me a favor and input a number for (numberOne) and (numberTwo)");
            numberOne = Convert.ToInt32(Console.ReadLine());
            numberTwo = Convert.ToInt32(Console.ReadLine());
            if (numberOne == numberTwo)
            {
                Console.WriteLine($"Those two numbers are equal\n");
            }

            else
            {
                Console.WriteLine($"Nope those two numbers are not equal\n");
            }
            Console.ReadLine();
        }

        public static void PositiveOrNegative()
        {
            int n;
            //2
            Console.WriteLine("Enter any number. Note: if negative please add - to the front of the number : ");
            //3
            n = int.Parse(Console.ReadLine());
            //4
            if (n == 0)
            {
                Console.WriteLine(n + " is zero.");
            }
            else if (n > 0)
            {
                //5
                Console.WriteLine(n + " is a positive number.");
            }
            else
            {
                //6
                Console.WriteLine(n + " is a negative number.");
            }
        }

        public static void AgeToVote()
        {
            Console.WriteLine("Thanks for hanging around now lets try one last thing.");
            Console.WriteLine("Lets see if your old enough to vote");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Please input your age");
            var age = 18;
            age = int.Parse(Console.ReadLine());
            if (age == 18)
            {
                Console.WriteLine($"Your good to go. Vote away!");
            }
            else if (age <= 18)
            {
                Console.WriteLine("Sorry. Your not old enough.");
            }
            else
            {
                Console.WriteLine("Heck ya. No judgment here! Get to Voting!");
            }
        }
        static void Main(string[] args)
        {//by3EachTime - will count 3s to 999
         var anwser = "3";
         Console.WriteLine("pick a number between 2 and 4.");
         var TryParse = ($"Great {anwser}");
         Console.ReadLine();
         var secondNum = "999";
         Console.WriteLine($"Cool now whats 1000 - 1 =??");
         Console.ReadLine();
         Console.WriteLine($"So now Im going to count by {anwser}'s all the way to {secondNum}. Please press enter to perform this action.");
        Console.ReadLine();
            var i = 3;
            while (i < 1000)
            {
                if (i % 3 == 0) 
                Console.WriteLine(i);
                i++;
            }

            //count from -1000 to 1000 - negThowToPlus
            var thow = 1000;
            Console.WriteLine("Please input 1000.");
            Console.ReadLine();
            Console.WriteLine($"Thank you for entering {thow}.");
            var negThow = -1000;
            Console.WriteLine("Okay, now please enter -1000.");
            Console.ReadLine();
            Console.WriteLine($"Thank you for entering {negThow}.");
            Console.WriteLine("Now Im going to count from -1000 to 1000.");
            Console.WriteLine("------------------------");
            Console.WriteLine("Please press enter to perform this action.");
            Console.ReadLine();

            for (int dC = -1000; dC < 1001; dC++)
            {
                Console.WriteLine($"{dC}");
            }

            //Number is even or odd - EvenOrOdd
            int num1, rem1;
            Console.WriteLine("\n\n");
            Console.WriteLine("Now lets check whether a number is even or odd:\n");
            Console.WriteLine("<------------==========-------------->");
            Console.WriteLine("\n\n");
            Console.WriteLine(" Please input an integer:");
            num1 = Convert.ToInt32(Console.ReadLine());
            rem1 = num1 % 2;
            if (rem1==0)
            {
                Console.WriteLine("{0} is an even integer.\n", num1);
            }
            else
            {
                Console.WriteLine("{0} is an odd integer.\n",num1);
            }

            //two numbers equal or not - EqualOrNot
            Console.WriteLine("Lets check if two different numbers are equal or not.");

            Console.WriteLine("-----------------------------------------");
            int numberOne, numberTwo;


            Console.WriteLine("Do me a favor and input a number for (numberOne) and (numberTwo).");
            numberOne = Convert.ToInt32(Console.ReadLine());
            numberTwo = Convert.ToInt32(Console.ReadLine());
            if (numberOne==numberTwo)
            {
                Console.WriteLine($"Those two numbers are equal\n");
            }

            else
            {
                Console.WriteLine($"Nope those two numbers are not equal\n");
            }
            Console.WriteLine("---------->     To continue press enter or to quit press X     <------------");
            Console.ReadLine();

            //Positive or negative
            Console.WriteLine("Lets now check to see if a number is (+) Positive or (-) Negative. Lets do it!!!");

            Console.WriteLine("-------------------------------------------");

            int n;
            
            Console.WriteLine("Enter any number. Note: if negative please add - to the front of the number : ");
            
            n = int.Parse(Console.ReadLine());
            
            if (n == 0)
            {
                Console.WriteLine(n + " is zero.");
            }
            else if (n > 0)
            {
                
                Console.WriteLine(n + " is a positive number.");
            }
            else
            {
                
                Console.WriteLine(n + " is a negative number.");
            }

            //age to vote - AgeToVote
            Console.WriteLine("Thanks for hanging around now lets try one last thing.");
            Console.WriteLine("Lets see if your old enough to vote.");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Please input your age.");
            var age = 18;
            age = int.Parse(Console.ReadLine());
            if (age == 18)
            {
                Console.WriteLine($"Your good to go. Vote away!");
            }
            else if (age <= 18)
            {
                Console.WriteLine("Sorry. Your not old enough.");
            }
            else
            {
                Console.WriteLine("Heck ya. No judgment here! Get to Voting!");
            }

            Console.WriteLine("THE END");

           // AgeToVote();
           // PositiveOrNegative();
            //EqualOrNot();
            // by3EachTime();
            //  negThowToPlus();
            // EvenOrOdd();


            //Write a method that will print to the console all numbers 1000 through -1000. (Done)
            // Write a method that will print to the console numbers 3 through 999 by 3 each time. (Done)
            //Write a method to accept two integers as parameters and check whether they are equal or not. (Done)
            //Write a method to check whether a given number is even or odd. (Done)
            //Write a method to check whether a given number is positive or negative. (Done)
            //Write a method to read the age of a candidate and determine whether they can vote. Hint: use Parse()... or the safer TryParse() for an extra challenge!!


        }
    }
}

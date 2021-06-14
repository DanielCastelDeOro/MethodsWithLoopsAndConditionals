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
        static void Main(string[] args)
        {//by3EachTime
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
            var thow = 1000;
            Console.WriteLine("Please input 1000");
            Console.ReadLine();
            Console.WriteLine($"Thank you for entering {thow}");
            var negThow = -1000;
            Console.WriteLine("Okay, now please enter -1000");
            Console.ReadLine();
            Console.WriteLine($"Thank you for entering {negThow}");
            Console.WriteLine("Now Im going to count from -1000 to 1000");
            Console.WriteLine("------------------------");
            Console.WriteLine("Please press enter to perform this action");
            Console.ReadLine();

            for (int dC = -1000; dC < 1001; dC++)
            {
                Console.WriteLine($"{dC}");
            }

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

            // by3EachTime();
            //  negThowToPlus();
           // EvenOrOdd();

            
            //Write a method that will print to the console all numbers 1000 through -1000.
              // Write a method that will print to the console numbers 3 through 999 by 3 each time.
             //Write a method to accept two integers as parameters and check whether they are equal or not.
            //Write a method to check whether a given number is even or odd.
            //Write a method to check whether a given number is positive or negative.
            //Write a method to read the age of a candidate and determine whether they can vote. Hint: use Parse()... or the safer TryParse() for an extra challenge!!


        }
    }
}

using System;

namespace FirstPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //// string works
            //string newString;
            //Console.WriteLine("hello timmy");
            //Console.WriteLine("enter whatchu wanna say:");
            //newString = Console.ReadLine();

            //Console.WriteLine(newString);

            //Gettin Number inputs from users.
            /* Console.Write("Enter an int ");
             int num = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine(num); */
            // Mad Libs
            /*string name, age;
            Console.Write("Enter your name ");
            name = Console.ReadLine();
            Console.Write("Enter your age ");
            age = Console.ReadLine();
            
            Console.WriteLine( name + " you are " +age + "and you are slow");*/

            // Arrays
            //declared with variables {}
            /*int[] myArray = {1, 2, 3 };*/
            // declared with empty/ size []
            /*int[] myFirstArray = new int[5];
            myFirstArray[0] = 1;
            myFirstArray[1] = 2;
            myFirstArray[2] = 3;
            myFirstArray[3] = 4;
            myFirstArray[4] = 5;
            Console.WriteLine(myFirstArray[0]);
            Console.WriteLine(myArray[0]);*/

            //Methods
            Calculate(3, 5);

            /// No need for storing in a variable.
            Console.WriteLine(ReturnInts(5, 4, 2));
            /// storing in a variable.
            int newResult = ReturnInts(5, 4, 2);
            Console.WriteLine("variable is " + Convert.ToString(newResult));
            // if/else syntax:
            int d = 11;
            if (newResult == d)
            {
                Console.WriteLine("It is number " + Convert.ToString(d));
            }
            else
            {
                Console.WriteLine("It is not number " + Convert.ToString(d));
            }

            SwitchCase(0, 12);
            SwitchCase(1, 12);
            SwitchCase(3, 3);
            //GuessingGame();
            MakeForLoop();
            Console.WriteLine("power is " + Convert.ToString(GetPower(2, 3)));
           


            
        }
        // C# has do while;
        // Methods creations.
        static void Calculate(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        static int ReturnInts(int a, int b, int c)
        {
            int result;
            result = a * b / c;
            return result;
        }
        // Switch/case
        static void SwitchCase(int day, int month)
        {
            switch (day)
            {
                case 0:
                    Console.WriteLine(month);
                    break;
                case 1:
                    Console.WriteLine(day);
                    break;
                default:
                    Console.WriteLine("Invalid");
                    break;
            }
        }
        // Guessing Game Function.
        static void GuessingGame()
        {
            string secretWord = "Timmy";
            string guess = "";
            int count = 0;
            do
            {
                Console.WriteLine("Please guess the letters");
                guess = Console.ReadLine();
                count++;
                //if (guess.ToLower() == secretWord.ToLower())
                //{
                //    Console.WriteLine("It is " + secretWord);
                //}
            } while ((guess.ToLower() != secretWord.ToLower()) && (count <=3));
            Console.WriteLine("It is " + secretWord);

        }
        //For loop
        static void MakeForLoop() 
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }

        // Make a power function
        static int GetPower(int baseNum, int power)
        {
            int result = 1;
            for (int i = 0; i < power; i++)
            {
                result = result* baseNum;
            }
            return result;
        }
    }
}

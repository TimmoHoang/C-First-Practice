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
            Console.Write("Enter an int ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num);

            // Mad Libs
            string name, age;
            Console.Write("Enter your name ");
            name = Console.ReadLine();
            Console.Write("Enter your age ");
            age = Console.ReadLine();
            
            Console.WriteLine( name + " you are " +age + "and you are slow");

            // Arrays
            //declared with variables {}
            int[] myArray = {1, 2, 3 };
            // declared with empty/ size []
            int[] myFirstArray = new int[5];
            myFirstArray[0] = 1;
            myFirstArray[1] = 2;
            myFirstArray[2] = 3;
            myFirstArray[3] = 4;
            myFirstArray[4] = 5;
            Console.WriteLine(myFirstArray[0]);
            Console.WriteLine(myArray[0]);
            
        }
    }
}

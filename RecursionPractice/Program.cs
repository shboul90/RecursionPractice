using System;

namespace RecursionPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number");

            //read number from user   

            int number = Convert.ToInt32(Console.ReadLine());

            //invoke the static method   

            double factorial = Factorial(number);

            int[] exSumArray = { 3, 2, 4, 5 };

            int sumOfArray = SumArray(exSumArray);
            //print the factorial result   

            Console.WriteLine("factorial of " + number + " = " + factorial.ToString() + "\n The sum of " + exSumArray.ToString() + " is " + sumOfArray );
            Console.ReadKey();

        }
        public static double Factorial(int number)
        {

            if (number == 0)

                return 1;

            return number * Factorial(number - 1);//Recursive call   

        }

        public static int SumArray(int[] arraySum)
        {

            if (arraySum.Length == 1)

                return arraySum[arraySum.Length-1];

            int[] subArray = new int[arraySum.Length-1];

            Array.Copy(arraySum, subArray, arraySum.Length - 1);

            return arraySum[arraySum.Length-1] + SumArray(subArray);//Recursive call   

        }
    }
}

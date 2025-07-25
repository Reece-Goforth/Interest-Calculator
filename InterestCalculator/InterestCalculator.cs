using System;

namespace InterestCalculator
{
    public class InterestCalculatorClass
    {
        static float interestRate = 0f;
        static float initialAmount = 0f;

        static void Main(string[] args)
        {
            while(true)
            {
                Console.Clear();
                Console.WriteLine("Interest Calculator:\n\n(R) Set interest rate\n(A) Set initial amount\n(T) Test\n\n");
                Console.Write("Enter > ");

                switch (Console.ReadLine().ToUpper())
                {
                    case "T":
                        Console.Clear();
                        CalculateInterest();
                        break;
                    case "A":
                        Console.WriteLine("\nEnter the desired initial amount.\n\n");
                        Console.Write("Enter > ");
                        initialAmount = float.Parse(Console.ReadLine());
                        break;
                    case "R":
                        Console.WriteLine("\nEnter the desired interest rate (in %).\n\n");
                        Console.Write("Enter > ");
                        interestRate = float.Parse(Console.ReadLine()) * 0.01f;
                        break;
                }
            }
        }

        static void CalculateInterest()
        {
            Console.WriteLine("Using the interest rate of " + interestRate.ToString());
            Console.WriteLine("And a starting amount of " + initialAmount.ToString() + "\n");
            Console.Write("Enter the number of months for which to calculate compound interest > ");
           
            int numMonths = int.Parse(Console.ReadLine());

            var value = Calculate(numMonths, initialAmount, interestRate);

            Console.Write("Press any key to continue...");
            Console.ReadKey();
        }

        public static float Calculate(int numMonths, float amount, float rate)
        {
            float value = amount + (amount * rate);

            Console.WriteLine(Math.Round(value*100) / 100);

            if (numMonths > 1)
            {
                value = Calculate(numMonths-1, value, rate);
            }
            return (float)Math.Round(value*100) / 100;
        }
    }
}

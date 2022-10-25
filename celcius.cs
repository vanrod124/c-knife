using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      double celcius;
        double fahrenheit;
        int increment, iteration;
        char s = 'y';

        while (s == 'y')
        {
            Console.WriteLine("Enter the starting temperature in Celcius: ");
            celcius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the increment: ");
            increment = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of iterations: ");
            iteration = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Celcius\tFahrenheit");
            for (int i = 0; i < iteration; i++)
            {
                fahrenheit = celcius * 9 / 5 + 32;
                Console.WriteLine("{0}\t{1}", celcius, fahrenheit);
                celcius += increment;
            }

            Console.WriteLine("Do you want to continue? (y/n)");
            s = Convert.ToChar(Console.ReadLine());
        }
    }
  }
}

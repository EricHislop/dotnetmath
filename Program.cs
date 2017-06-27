using System;
namespace LCMofTwoNum
{
  class Program
  {

    static void Main(string[] args)
    {
      Console.WriteLine("Enter 1 to 10 \n 1: Check if a number is Divisible \n 2: List Fibonacci Numbers \n 3: least common multiple \n 4: list prime numbers \n 5: Greatest common denominator \n 6: Add two Fractions \n 7: Solve for x");
      int selectedQuestion;
      selectedQuestion = int.Parse(Console.ReadLine());
      if (selectedQuestion == 1)
      {
        Console.WriteLine("Enter two numbers to see if number 1 is divisible by number 2");
        int num1;
        int num2;
        Console.WriteLine("Enter the first number");
        num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second number");
        num2 = int.Parse(Console.ReadLine());
        int divisibleResult = checkDivisible(num1, num2);
        if (divisibleResult == 0)
        {
          Console.WriteLine("{0} is not divisible by {1}", num1, num2, divisibleResult);
        }
        else
        {
          Console.WriteLine("{2} is divisible by {1}", num1, num2, divisibleResult);
        }
      }
      else if (selectedQuestion == 2)
      {

        Console.WriteLine("enter a number for the Fibonacci Numbers to count up to:");
        int FibonacciCount;
        FibonacciCount = int.Parse(Console.ReadLine());
        for (int i = 0; i < FibonacciCount; i++)
        {
          Console.WriteLine($"{i + 1}: {FibonacciNumber(i)}");
        }
      }
      else if (selectedQuestion == 3)
      {
        Console.WriteLine("do it your self eric");
        for (int x = 2; x < 500000; x++)
        {
          int isPrime = 0;
          for (int y = 1; y < x; y++)
          {
            if (x % y == 0)
              isPrime++;

            if (isPrime == 2) break;
          }
          if (isPrime != 2)
            Console.WriteLine(x);

          isPrime = 0;
        }
      }
      else if (selectedQuestion == 4)
      {
        Console.WriteLine("Enter the number for primes to count up to");
        int num1;
        num1 = int.Parse(Console.ReadLine());
        for (int x = 2; x < num1; x++)
        {
          int isPrime = 0;
          int sqrtx = GetSqrtx(x);
          for (int y = 1; y <= sqrtx; y++)
          {
            if (x % y == 0)
              isPrime++;

            if (isPrime == 2) break;
          }
          if (isPrime != 2)
            Console.WriteLine(x);
          isPrime = 0;
        }

      }

    }

    private static int GetSqrtx(int x)
    {
      return (int)Math.Sqrt(x);
    }

    public static int checkDivisible(int a, int b)
    {
      if (a % b == 0)
      {
        return a;
      }
      else
      {
        return 0;
      }

    }
    static int FibonacciNumber(int n)
    {
      int a = 0;
      int b = 1;
      int tmp;

      for (int i = 0; i < n; i++)
      {
        tmp = a;
        a = b;
        b += tmp;
      }

      return a;
    }
  }
}
using System;

class Function
{   //ex01
    static bool IsPrime(int number)
    {
        if (number <= 1)
        {
            return false; // Numbers less than or equal to 1 are not prime.
        }

        if (number <= 3)
        {
            return true; // 2 and 3 are prime numbers.
        }

        if (number % 2 == 0 || number % 3 == 0)
        {
            return false; // Numbers divisible by 2 or 3 are not prime.
        }

        for (int i = 5; i * i <= number; i += 6)// כי 2 ו3 נבדקו כבר
        {
            if (number % i == 0 || number % (i + 2) == 0)//only need to check numbers of the form 6k ± 1 ,i =6k-1, i+2 =6k+1
            {
                return false; // Numbers divisible by i or i+2 are not prime.
            }
        }

        return true; // If no divisors are found, the number is prime.
    }

    //ex03
    static void PrintFibonacciSeries(int n)
    {
        int a, b = 1, c = 0;

        Console.Write("Fibonacci Series: ");

        while (c <= n)
        {
            Console.Write($"{c} ");
            a = b;
            b = c;
            c = a + b;
        }

        Console.WriteLine();
    }




    static void Main()
    {   //ex01
        Console.Write("Enter a number: ");

        int number = int.Parse(Console.ReadLine());

        bool isPrime = IsPrime(number);

        if (isPrime)
        {
            Console.WriteLine($"{number} is a prime number.");
        }
        else
        {
            Console.WriteLine($"{number} is not a prime number.");
        }


        //ex02
        Console.WriteLine("Enter positive integers (enter -1 to stop):");

        int largestPositiveNumber = -1;
        int input;

         do
        {
           
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out input))// בדיקה אם מה שהוכנס הוא מספר חיובי ושלם( חוץ מ-1)
                {
                    if (input == -1 || input > 0)
                    {
                        break; // Valid input, exit the loop
                    }
                }
               
                Console.WriteLine("Invalid input. Please enter a whole and positive number (or -1 to end).");
            }
            if (input > largestPositiveNumber && input != -1)
            {
                largestPositiveNumber = input;
            }

        } while (input != -1);

        if (largestPositiveNumber == -1)
        {
            Console.WriteLine("No positive numbers entered.");
        }
        else
        {
            Console.WriteLine($"The largest positive number entered is: {largestPositiveNumber}");
        }


        //ex03

        Console.Write("Enter a positive integer: ");
        int inputFibonacci = int.Parse(Console.ReadLine());

        PrintFibonacciSeries(inputFibonacci);
    

        // ex04

        Console.WriteLine("Enter positive integers (enter -1 to stop):");

        int[] sequence = new int[3];
    
        int input04;
        int count = 0;

        while (true)
        {
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out input04))// בדיקה אם מה שהוכנס הוא מספר חיובי ושלם( חוץ מ-1)
                {
                    if (input04 == -1 || input04 > 0)
                    {
                        break; // Valid input, exit the loop
                    }
                }

                Console.WriteLine("Invalid input. Please enter a whole and positive number (or -1 to end).");
            }



            if (input04 == -1)
            {
                break;
            }
            if (count < 3)//There are less than 3 numbers
            {
                sequence[count] = input04;
                count++;
            }

           if (count==3) //Sorting when the array fills up
                Array.Sort(sequence);

            if (input04 > sequence[0])//If the new number  is greater than the minimum number, it overruns it 
            {
                sequence[0] = input04;
                Array.Sort(sequence);
            }
        }
        Console.WriteLine("The sequence with the largest sum is:");
        Console.WriteLine(string.Join(" ", sequence));
    }
}

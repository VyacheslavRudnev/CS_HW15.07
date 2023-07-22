using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain2
{
    namespace EvenNumber
    {
        public class Number
        {
            public int Numb { get; set; }
            public Number(int number)
            {
                Numb = number;
            }
            public void IsEven()
            {
                bool isEven = true;
                if (Numb % 2 != 0)
                {
                    isEven = false;
                }
                else
                {
                    Console.WriteLine($"Число {Numb} парне");
                }
            }


        }
    }

    namespace PrimeNumber
    {
        public class Number
        {
            public int Numb { get; set; }
            public Number(int number)
            {
                Numb = number;
            }
            public void IsPrime()
            {
                bool isPrime = true;
                for (int i = 2; i < Numb; i++)
                {
                    if (Numb % i == 0)
                    {
                        isPrime = false;
                        Console.WriteLine($"Число {Numb} не є простим");
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.WriteLine($"Число {Numb} просте");
                }
            }
        }
    }
    namespace OddNumber
    {
        public class Number
        {
            public int Numb { get; set; }
            public Number(int number)
            {
                Numb = number;
            }
            public void IsOdd()
            {
                bool isOdd = true;
                if (Numb % 2 == 0)
                {
                    isOdd = false;
                }
                else
                {
                    Console.WriteLine($"Число {Numb} непарне");
                }
            }
        }
    }

    namespace FibonacciNumber
    {
        public class Number
        {
            public int Numb { get; set; }
            public Number(int number)
            {
                Numb = number;
            }
            public void IsFibonacci()
            {
                int a = 0;
                int b = 1;
                int c = 0;
                bool isFibonacci = false;
                while (c < Numb)
                {
                    c = a + b;
                    a = b;
                    b = c;
                    if (c == Numb)
                    {
                        isFibonacci = true;
                        Console.WriteLine($"Число {Numb} є числом Фібоначчі");
                        break;
                    }
                }
                if (!isFibonacci)
                {
                    Console.WriteLine($"Число {Numb} не є числом Фібоначчі");
                }
            }
        }
    }
}

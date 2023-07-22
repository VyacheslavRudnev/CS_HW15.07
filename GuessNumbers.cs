using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain2
{
    namespace GuessIntNumber
    {
        public class Number
        {
            private int number;
            public int minLim;
            public int maxLim;
            public int intNumber
            {
                get { return number; }
                set { number = value; }
            }
            public int MinLim
            {
                get { return minLim; }
                set { minLim = value; }
            }
            public int MaxLim
            {
                get { return maxLim; }
                set { maxLim = value; }
            }
            public Number() { }
            public Number(int minLim, int maxLim)
            {
                this.minLim = minLim;
                this.maxLim = maxLim;
            }
            public void StartGame()
            {
                Console.WriteLine("\nПограємо в гру ВГАДАЙ ЧИСЛО ? ");
                Console.WriteLine("ти загадуєш число, я відгадую");
                Console.Write("Вкажи нижню границю діапазона (ціле число): ");
                int minLim = Convert.ToInt32(Console.ReadLine());
                Console.Write("Вкажи верхню границю діапазона (ціле число): ");
                int maxLim = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Загадай ціле число від {0} до {1}", minLim, maxLim);
                Console.WriteLine("Якщо загадав натисни Enter");
                Console.ReadLine();
                Console.WriteLine();

                int tryCount = 0;
                while (true)
                {
                    tryCount++;
                    int mid = (minLim + maxLim) / 2;
                    Console.WriteLine($"Ти загадав {mid} ?");
                    Console.WriteLine("Якщо так натисни 1");
                    Console.WriteLine("Якщо твоє число більше натисни 2");
                    Console.WriteLine("Якщо твоє число менше натисни 3");
                    int answer = Convert.ToInt32(Console.ReadLine());
                    if (answer == 1)
                    {
                        Console.WriteLine($"Я відгадав твоє число {mid} з {tryCount} спроби");
                        break;
                    }
                    else if (answer == 2)
                    {
                        minLim = mid + 1;
                    }
                    else if (answer == 3)
                    {
                        maxLim = mid - 1;
                    }
                    else
                    {
                        Console.WriteLine("Введи 1, 2 або 3");
                    }
                    Console.WriteLine();
                }
            }
        }
    }

    namespace GuessDoubNumber
    {
        public class Number
        {
            private double number;
            public double minLim;
            public double maxLim;
            public double intNumber
            {
                get { return number; }
                set { number = value; }
            }
            public double MinLim
            {
                get { return minLim; }
                set { minLim = value; }
            }
            public double MaxLim
            {
                get { return maxLim; }
                set { maxLim = value; }
            }
            public Number() { }
            public Number(double minLim, double maxLim)
            {
                this.minLim = minLim;
                this.maxLim = maxLim;
            }
            public void StartGame()
            {
                Console.WriteLine("\nПограємо в гру ВГАДАЙ ЧИСЛО ? ");
                Console.WriteLine("ти загадуєш число, я відгадую");
                Console.Write("Вкажи нижню границю діапазона (дробне число в форматі ##,#): ");
                double minLim = Convert.ToDouble(Console.ReadLine());
                Console.Write("Вкажи верхню границю діапазона (дробне число в форматі ##,#) : ");
                double maxLim = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Загадай число від {0} до {1}", minLim, maxLim);
                Console.WriteLine("Якщо загадав натисни Enter");
                Console.ReadLine();
                Console.WriteLine();

                int tryCount = 0;
                while (true)
                {
                    tryCount++;
                    double mid = (minLim + maxLim) / 2;

                    Console.WriteLine($"Ти загадав {mid.ToString("F1")} ?");
                    Console.WriteLine("Якщо так натисни 1");
                    Console.WriteLine("Якщо твоє число більше натисни 2");
                    Console.WriteLine("Якщо твоє число менше натисни 3");
                    int answer = Convert.ToInt32(Console.ReadLine());
                    if (answer == 1)
                    {
                        Console.WriteLine($"Я відгадав твоє число {mid.ToString("F1")} з {tryCount} спроби");
                        break;
                    }
                    else if (answer == 2)
                    {
                        minLim = mid + 1;
                    }
                    else if (answer == 3)
                    {
                        maxLim = mid - 1;
                    }
                    else
                    {
                        Console.WriteLine("Введи 1, 2 або 3");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}

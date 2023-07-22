using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;
//Pract/Mod04/ex01
using Domain2.EvenNumber;
using Domain2.FibonacciNumber;
using Domain2.OddNumber;
using Domain2.PrimeNumber;
//Pract/Mod04/ex02
using Domain2.Triangle;
using Domain2.Rectangle;
using Domain2.Square;
//Pract/Mod04/ex03
using Domain2.GuessIntNumber;
using Domain2.GuessDoubNumber;
//Pract/Mod04/ex04
using Domain2.PseudoTextUA;
using Domain2.PseudoTextEN;
//HW/Mod04/ex01-ex02
using Domain2.TicTacToeAi;
using Domain2.TicTacToePaP;
//HW/Mod04/ex03-ex04
using Domain2.MorseCodeEN;
using Domain2.MorseCodeUA;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Завдання 1
            //Створіть класи для створення парних чисел, непарних
            //чисел, простих чисел, чисел Фібоначчі.Використовуйте
            //механізми просторів імен.

            //Console.WriteLine("Pract/Mod04/ex01\n");
            //Console.InputEncoding = Encoding.Unicode;
            //Console.OutputEncoding = Encoding.Unicode;

            //Console.WriteLine("Введіть число: ");
            //int number = Convert.ToInt32(Console.ReadLine());

            //var evenNumber = new Domain2.EvenNumber.Number(number);
            //var oddNumber = new Domain2.OddNumber.Number(number);
            //var primeNumber = new Domain2.PrimeNumber.Number(number);
            //var fibonacciNumber = new Domain2.FibonacciNumber.Number(number);
            //Console.WriteLine();
            //evenNumber.IsEven();
            //oddNumber.IsOdd();
            //primeNumber.IsPrime();
            //fibonacciNumber.IsFibonacci();

            //Завдання 2
            //Створіть класи для відображення різних геометричних
            //фігур: трикутника, прямокутника, квадрата.Використо -
            //вуйте механізми просторів імен.

            //Console.WriteLine("Pract/Mod04/ex02\n");
            //Console.InputEncoding = Encoding.Unicode;
            //Console.OutputEncoding = Encoding.Unicode;

            //Console.WriteLine("Введіть сторону а: ");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Введіть сторону b: ");
            //int b = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Введіть сторону c: ");
            //int c = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine();

            //var triangle = new Domain2.Triangle.Figure(a, b, c);
            //triangle.IsTriangle();
            //Console.WriteLine();
            //var rectangle = new Domain2.Rectangle.Figure(a, b, c);
            //rectangle.IsRectangle();
            //Console.WriteLine();
            //var square = new Domain2.Square.Figure(a, b, c);
            //square.IsSquare();
            //Console.WriteLine();


            //Завдання 3
            //Створіть гру «Вгадай число». Комп’ютер вгадує число,
            //яке загадав користувач у вказаному діапазоні. Використо -
            //вуйте механізми просторів імен.

            //Console.WriteLine("Pract/Mod04/ex03\n");
            //Console.InputEncoding = Encoding.Unicode;
            //Console.OutputEncoding = Encoding.Unicode;

            //var number = new Domain2.GuessIntNumber.Number();
            //number.StartGame();

            //var number2 = new Domain2.GuessDoubNumber.Number();
            //number2.StartGame();
            //Console.WriteLine();

            //Завдання 4
            //Створіть додаток для генерації псевдотексту.Користувач
            //вводить кількість голосних і приголосних, максимальну
            //довжину слова. Додаток генерує текст на основі вибраних
            //параметрів.Використовуйте механізми просторів імен.

            //Console.WriteLine("Pract/Mod04/ex04\n");
            //Console.InputEncoding = Encoding.Unicode;
            //Console.OutputEncoding = Encoding.Unicode;

            //Console.WriteLine("Перед вами програма, що генерує випадковий текст " +
            //                    "з випадкових українських або англійських символів");
            //Console.WriteLine("Для початку роботи оберіть опцію мови: \n" +
            //    "\t1 - Ураїнські символи\n" +
            //    "\t2 - Англійські символи\n");
            //int language = Convert.ToInt32(Console.ReadLine());
            //switch (language)
            //{
            //    case 1:
            //        Console.WriteLine("Ви обрали українські символи");
            //        Console.WriteLine("Введіть кількість голосних: ");
            //        int vowelsCount = Convert.ToInt32(Console.ReadLine());

            //        Console.WriteLine("Введіть кількість приголосних: ");
            //        int consonantsCount = Convert.ToInt32(Console.ReadLine());

            //        Console.WriteLine("Введіть максимальну довжину слова: ");
            //        int maxLength = Convert.ToInt32(Console.ReadLine());

            //        Console.WriteLine("Введіть потрібну кількість слів: ");
            //        int wordsCount = Convert.ToInt32(Console.ReadLine());

            //        string pseudoText = Domain2.PseudoTextUA.Text.GeneratePseudoText(wordsCount, vowelsCount, consonantsCount, maxLength);
            //        Console.WriteLine("\nВипадково згенерований текст: ");
            //        Console.ForegroundColor = ConsoleColor.DarkYellow;
            //        Console.WriteLine(pseudoText);
            //        break;
            //    case 2:
            //        Console.WriteLine("Ви обрали англійські символи");
            //        Console.WriteLine("Введіть кількість голосних: ");
            //        int vowelsCount2 = Convert.ToInt32(Console.ReadLine());

            //        Console.WriteLine("Введіть кількість приголосних: ");
            //        int consonantsCount2 = Convert.ToInt32(Console.ReadLine());

            //        Console.WriteLine("Введіть максимальну довжину слова: ");
            //        int maxLength2 = Convert.ToInt32(Console.ReadLine());

            //        Console.WriteLine("Введіть потрібну кількість слів: ");
            //        int wordsCount2 = Convert.ToInt32(Console.ReadLine());

            //        string pseudoText2 = Domain2.PseudoTextEN.Text.GeneratePseudoText(wordsCount2, vowelsCount2, consonantsCount2, maxLength2);
            //        Console.WriteLine("\nВипадково згенерований текст: ");
            //        Console.ForegroundColor = ConsoleColor.DarkBlue;
            //        Console.WriteLine(pseudoText2);
            //        break;
            //    default:
            //        Console.ForegroundColor = ConsoleColor.Red;
            //        Console.WriteLine("Ви обрали неправильну опцію");
            //        break;
            //}
            //Console.ForegroundColor = ConsoleColor.White;

            //Завдання 1
            //Створіть додаток «Хрестики - Нулики». Користувач грає
            //з комп'ютером. При старті гри рандомно обирається, хто
            //перший розпочинає гру.Гравці ходять по черзі. Гра може
            //закінчитися перемогою одного з гравців або нічиєю.Ви -
            //користовуйте механізми просторів імен.
            //Завдання 2
            //Додайте до першого завдання можливість грати з ін-
            //шим користувачем.

            //Console.WriteLine("HW/Mod04/ex01-ex02\n");
            //Console.InputEncoding = Encoding.Unicode;
            //Console.OutputEncoding = Encoding.Unicode;
            //Console.WriteLine("Гра в Хрестики-Нолики");
            //Console.WriteLine("Оберіть режим гри: \n" +
            //              "\t1 - Гра з комп'ютером\n" +
            //              "\t2 - Гра з іншим користувачем\n");
            //int gameMode = Convert.ToInt32(Console.ReadLine());
            //if (gameMode == 1)
            //{
            //    var game = new Domain2.TicTacToeAi.Game();
            //    game.Start();
            //}
            //else if (gameMode == 2)
            //{
            //    var game = new Domain2.TicTacToePaP.Game();
            //    game.Start();
            //}
            //else
            //{
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.WriteLine("Ви обрали неправильну опцію");
            //}
            //Console.ResetColor();

            //Завдання 3
            //Створіть додаток для перекладу звичайного тексту в
            //азбуку Морзе.Користувач вводить текст.Додаток виводить
            //введений текст азбукою Морзе. Використовуйте механізми
            //просторів імен.
            //Завдання 4
            //Додайте до попереднього завдання механізм перекладу
            //тексту з азбуки Морзе у звичайний текст.

            //Console.WriteLine("HW/Mod04/ex03-ex04\n");
            //Console.InputEncoding = Encoding.Unicode;
            //Console.OutputEncoding = Encoding.Unicode;

            //Console.WriteLine("Додаток для перекладу тексту в азбуку Морзе та навпаки");
            //Console.WriteLine("Оберіть мову для перекладу в азбуку Морзе: \n" +
            //                    "\t1 - Англійська\n" +
            //                    "\t2 - Українська\n");
            //int language = Convert.ToInt32(Console.ReadLine());
            //switch (language)
            //{
            //    case 1:
            //        Console.WriteLine("Введіть текст для перекладу: ");
            //        string textEN = Console.ReadLine();

            //        Console.WriteLine("Виберіть опцію перекладу: \n" +
            //                     "\t1 - Перекласти в азбуку Морзе\n" +
            //                     "\t2 - Перекласти з азбуки Морзе\n");
            //        int optionEN = Convert.ToInt32(Console.ReadLine());
            //        switch (optionEN)
            //        {
            //            case 1:
            //                Console.WriteLine("Ви обрали опцію 1");
            //                Console.ForegroundColor = ConsoleColor.DarkBlue;
            //                Console.WriteLine("Ваш оригінальний текст: " + textEN);
            //                Console.ResetColor();
            //                Console.WriteLine("Ваш текст в азбуці Морзе: ");
            //                Console.ForegroundColor = ConsoleColor.DarkYellow;
            //                Console.WriteLine(Domain2.MorseCodeEN.MorseTranslator.TranslateToMorse(textEN));
            //                Console.ResetColor();
            //                break;
            //            case 2:
            //                Console.WriteLine("Ви обрали опцію 2");
            //                Console.ForegroundColor = ConsoleColor.DarkBlue;
            //                Console.WriteLine("Ваш оригінальний текст: " + textEN);
            //                Console.ResetColor();
            //                Console.Write("Ваш текст в звичайному вигляді: ");
            //                Console.ForegroundColor = ConsoleColor.DarkYellow;
            //                Console.WriteLine(Domain2.MorseCodeEN.MorseTranslator.TranslateFromMorse(textEN));
            //                Console.ResetColor();
            //                break;
            //            default:
            //                Console.ForegroundColor = ConsoleColor.Red;
            //                Console.WriteLine("Ви обрали неправильну опцію");
            //                Console.ResetColor();
            //                break;
            //        }
            //        break;
            //    case 2:
            //        Console.WriteLine("Введіть текст для перекладу: ");
            //        string textUA = Console.ReadLine();

            //        Console.WriteLine("Виберіть опцію перекладу: \n" +
            //                     "\t1 - Перекласти в азбуку Морзе\n" +
            //                     "\t2 - Перекласти з азбуки Морзе\n");
            //        int optionUA = Convert.ToInt32(Console.ReadLine());
            //        switch (optionUA)
            //        {
            //            case 1:
            //                Console.WriteLine("Ви обрали опцію 1");
            //                Console.ForegroundColor = ConsoleColor.DarkBlue;
            //                Console.WriteLine("Ваш оригінальний текст: " + textUA);
            //                Console.ResetColor();
            //                Console.WriteLine("Ваш текст в азбуці Морзе: ");
            //                Console.ForegroundColor = ConsoleColor.DarkYellow;
            //                Console.WriteLine(Domain2.MorseCodeUA.MorseTranslator.TranslateToMorse(textUA));
            //                Console.ResetColor();
            //                break;
            //            case 2:
            //                Console.WriteLine("Ви обрали опцію 2");
            //                Console.ForegroundColor = ConsoleColor.DarkBlue;
            //                Console.WriteLine("Ваш оригінальний текст: " + textUA);
            //                Console.ResetColor();
            //                Console.Write("Ваш текст в звичайному вигляді: ");
            //                Console.ForegroundColor = ConsoleColor.DarkYellow;
            //                Console.WriteLine(Domain2.MorseCodeUA.MorseTranslator.TranslateFromMorse(textUA));
            //                Console.ResetColor();
            //                break;
            //            default:
            //                Console.ForegroundColor = ConsoleColor.Red;
            //                Console.WriteLine("Ви обрали неправильну опцію");
            //                Console.ResetColor();
            //                break;
            //        }
            //        break;
            //    default:
            //        Console.ForegroundColor = ConsoleColor.Red;
            //        Console.WriteLine("Ви обрали неправильну опцію");
            //        break;
            //}

            Console.ReadKey();
        }
    }
}
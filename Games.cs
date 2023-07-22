using Domain2.TicTacToeAi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain2
{
    namespace TicTacToeAi
    {
        public class Game
        {
            private char[,] board;
            private char currentPlayer;
            private char userSymbol;
            private string userName;
            private char aiSymbol;


            public void Start()
            {
                Console.Write("Введи ім'я: ");
                userName = Console.ReadLine();
                Console.WriteLine($"Привіт, {userName}!");
                Console.Write("Введи розмір поля (наприклад, 3 для поля розміром 3x3): ");
                int size;
                while (!int.TryParse(Console.ReadLine(), out size) || size < 3)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Вкажи коректний розмір поля (не менше 3): ");
                }
                Console.ResetColor();
                InitBoard(size);
                PrintBoard();
                Console.WriteLine();

                Console.WriteLine("Визначення першого ходу " +
                    $"(1 - {userName}, " +
                    "2 - комп'ютер)");
                int firstMoveChoice;
                while (!int.TryParse(Console.ReadLine(), out firstMoveChoice) || (firstMoveChoice != 1 && firstMoveChoice != 2))
                {
                    Console.WriteLine("Вибери хто буде ходити першим. Введи 1 або 2: ");
                }

                char symbolChoice;
                while (!char.TryParse(Console.ReadLine(), out symbolChoice) || !IsValidSymbol(symbolChoice))
                {
                    Console.WriteLine($" {userName} обери символ для гри, введи X або O: ");
                }
                userSymbol = char.ToUpper(symbolChoice);
                aiSymbol = userSymbol == 'X' ? 'O' : 'X';

                currentPlayer = firstMoveChoice == 1 ? userSymbol : aiSymbol;

                while (true)
                {
                    Console.WriteLine($"Ходить {(currentPlayer == userSymbol ? userName : "Комп'ютер")}");

                    if (currentPlayer == userSymbol)
                    {
                        GetUserMove();
                    }
                    else
                    {
                        GetAiMove();
                    }

                    PrintBoard();
                    Console.WriteLine();

                    if (CheckWin())
                    {
                        Console.WriteLine($"Гравець {(currentPlayer == userSymbol ? userName : "Комп'ютер")} переміг!");
                        break;
                    }

                    if (IsBoardFull())
                    {
                        Console.WriteLine("\nНічия!");
                        break;
                    }

                    currentPlayer = currentPlayer == userSymbol ? aiSymbol : userSymbol;
                }

                Console.WriteLine("Гра завершена. Дякуємо за гру!");
            }
            private bool IsValidSymbol(char symbol)
            {
                char[] validSymbols = { 'X', 'O', 'x', 'o', 'Х', 'О', 'х', 'о' };

                return validSymbols.Contains(symbol);
            }

            public void InitBoard(int size)
            {
                board = new char[size, size];
                for (int row = 0; row < size; row++)
                {
                    for (int col = 0; col < size; col++)
                    {
                        board[row, col] = ' ';
                    }
                }
            }
            public void PrintBoard()
            {
                int size = board.GetLength(0);

                for (int row = 0; row < size; row++)
                {
                    for (int col = 0; col < size; col++)
                    {
                        Console.Write(board[row, col]);
                        if (col < size - 1)
                        {
                            Console.Write(" | ");
                        }
                    }
                    Console.WriteLine();
                    if (row < size - 1)
                    {
                        Console.WriteLine(new string('-', 4 * size - 1));
                    }
                }
            }

            public void MakeMove(int row, int col)
            {
                board[row, col] = currentPlayer;
            }

            public bool IsMoveValid(int row, int col)
            {
                return board[row, col] == ' ';
            }

            public bool CheckWin()
            {
                int size = board.GetLength(0);

                for (int row = 0; row < size; row++)
                {
                    if (board[row, 0] != ' ' && board[row, 0] == board[row, 1] && board[row, 1] == board[row, 2])
                    {
                        return true;
                    }
                }

                for (int col = 0; col < size; col++)
                {
                    if (board[0, col] != ' ' && board[0, col] == board[1, col] && board[1, col] == board[2, col])
                    {
                        return true;
                    }
                }

                if (board[0, 0] != ' ' && board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
                {
                    return true;
                }

                if (board[0, 2] != ' ' && board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0])
                {
                    return true;
                }
                return false;
            }
            public bool IsBoardFull()
            {
                int size = board.GetLength(0);

                for (int row = 0; row < size; row++)
                {
                    for (int col = 0; col < size; col++)
                    {
                        if (board[row, col] == ' ')
                            return false;
                    }
                }
                return true;
            }
            private void GetUserMove()
            {
                Console.Write("Введи номер рядка (від 1 до 3): ");
                int row = Convert.ToInt32(Console.ReadLine()) - 1;
                Console.Write("Введи номер стовпця (від 1 до 3): ");
                int col = Convert.ToInt32(Console.ReadLine()) - 1;

                if (row >= 0 && row < board.GetLength(0) && col >= 0 && col < board.GetLength(1) && IsMoveValid(row, col))
                {
                    Console.WriteLine();
                    MakeMove(row, col);
                    Console.WriteLine();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Неприпустимий хід. Повтори спробу.");
                    GetUserMove();
                }
                Console.ResetColor();
                Console.Clear();
            }

            private void GetAiMove()
            {
                Random random = new Random();
                int row, col;
                do
                {
                    row = random.Next(board.GetLength(0));
                    col = random.Next(board.GetLength(1));
                } while (!IsMoveValid(row, col));
                Console.WriteLine();
                MakeMove(row, col);
                Console.WriteLine();
            }
        }
    }

    namespace TicTacToePaP
    {
        public class Game
        {
            private char[,] board;
            private char currentPlayer;
            private char player1Symbol;
            private char player2Symbol;
            private string player1Name;
            private string player2Name;


            public void Start()
            {   
                Console.Write("Гравець 1, введіть ваше ім'я: ");
                player1Name = Console.ReadLine();

                Console.Write("Гравець 2, введіть ваше ім'я: ");
                player2Name = Console.ReadLine();
                
                Console.Write("Введіть розмір поля (наприклад, 3 для 3x3): ");
                int size;
                while (!int.TryParse(Console.ReadLine(), out size) || size < 3)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Введіть коректний розмір поля (не менше 3): ");
                }
                Console.ResetColor();
                InitBoard(size);
                PrintBoard();
                Console.WriteLine();

                Console.Write($"{player1Name}, виберіть символ (X або O): ");
                char player1SymbolChoice;
                while (!char.TryParse(Console.ReadLine(), out player1SymbolChoice) || !IsValidSymbol(player1SymbolChoice))
                {
                    Console.WriteLine("Введіть X або O: ");
                }
                player1Symbol = char.ToUpper(player1SymbolChoice);
                player2Symbol = player1Symbol == 'X' ? 'O' : 'X';

               

                Console.WriteLine($"Гравець {player1Name} грає за {player1Symbol}, а гравець {player2Name} грає за {player2Symbol}.\n");
                Console.WriteLine("Оберіть порядок ходів.");
                Console.Write($"Введіть 1, якщо гравець {player1Name} буде ходити першим, або 2, якщо гравець {player2Name} буде ходити першим: ");
                int firstPlayerChoice;
                while (!int.TryParse(Console.ReadLine(), out firstPlayerChoice) || (firstPlayerChoice != 1 && firstPlayerChoice != 2))
                {
                    Console.WriteLine("Введіть 1 або 2: ");
                }
                if (firstPlayerChoice == 1)
                {
                    currentPlayer = player1Symbol;
                }
                else
                {
                    currentPlayer = player2Symbol;
                }

                while (true)
                {
                    Console.WriteLine($"\n {(currentPlayer == player1Symbol ? player1Name : player2Name)}, ваш хід.");

                    GetUserMove();

                    PrintBoard();

                    if (CheckWin())
                    {
                        Console.WriteLine($"Гравець {(currentPlayer == player1Symbol ? player1Name : player2Name)} переміг!");
                        break;
                    }

                    if (IsBoardFull())
                    {
                        Console.WriteLine("Нічия!");
                        break;
                    }

                    SwitchPlayers();
                }

                Console.WriteLine("Гра завершена. Дякуємо за гру!");
            }

            private bool IsValidSymbol(char symbol)
            {
                // Множина допустимих символів: 'X', 'O', 'x', 'o', 'Х', 'О', 'х', 'о'
                char[] validSymbols = { 'X', 'O', 'x', 'o', 'Х', 'О', 'х', 'о' };

                return validSymbols.Contains(symbol);
            }

            private void InitBoard(int size)
            {
                board = new char[size, size];
                for (int row = 0; row < size; row++)
                {
                    for (int col = 0; col < size; col++)
                    {
                        board[row, col] = ' ';
                    }
                }
            }
            public void PrintBoard()
            {
                int size = board.GetLength(0);

                for (int row = 0; row < size; row++)
                {
                    for (int col = 0; col < size; col++)
                    {
                        Console.Write(board[row, col]);
                        if (col < size - 1)
                        {
                            Console.Write(" | ");
                        }
                    }
                    Console.WriteLine();
                    if (row < size - 1)
                    {
                        Console.WriteLine(new string('-', 4 * size - 1));
                    }
                }
            }

            public void MakeMove(int row, int col)
            {
                board[row, col] = currentPlayer;
            }

            public bool IsMoveValid(int row, int col)
            {
                return board[row, col] == ' ';
            }

            private bool CheckWin()
            {
                int size = board.GetLength(0);

                for (int i = 0; i < size; i++)
                {
                    if (board[i, 0] == currentPlayer && board[i, 1] == currentPlayer && board[i, 2] == currentPlayer)
                        return true;

                    if (board[0, i] == currentPlayer && board[1, i] == currentPlayer && board[2, i] == currentPlayer)
                        return true;
                }

                if (board[0, 0] == currentPlayer && board[1, 1] == currentPlayer && board[2, 2] == currentPlayer)
                    return true;

                if (board[0, 2] == currentPlayer && board[1, 1] == currentPlayer && board[2, 0] == currentPlayer)
                    return true;

                return false;
            }
            private bool IsBoardFull()
            {
                int size = board.GetLength(0);
                for (int row = 0; row < size; row++)
                {
                    for (int col = 0; col < size; col++)
                    {
                        if (board[row, col] == ' ')
                            return false;
                    }
                }
                return true;
            }
            private void GetUserMove()
            {
                Console.Write($" {(currentPlayer == player1Symbol ? player1Name : player2Name)}, введіть номер рядка (від 1 до 3): ");
                int row = Convert.ToInt32(Console.ReadLine()) - 1;
                Console.Write($" {(currentPlayer == player1Symbol ? player1Name : player2Name)}, введіть номер стовпця (від 1 до 3): ");
                int col = Convert.ToInt32(Console.ReadLine()) - 1;

                if (row >= 0 && row < board.GetLength(0) && col >= 0 && col < board.GetLength(1) && IsMoveValid(row, col))
                {
                    Console.WriteLine();
                    MakeMove(row, col);
                    Console.WriteLine();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Неприпустимий хід. Повторіть спробу.");
                    GetUserMove();
                }
                Console.ResetColor();
                Console.Clear();
            }

            private void SwitchPlayers()
            {
                currentPlayer = currentPlayer == player1Symbol ? player2Symbol : player1Symbol;
            }
        }
    }


}

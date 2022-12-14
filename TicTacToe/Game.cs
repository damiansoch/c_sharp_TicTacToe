using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Game
    {
        public char[,] ticTacToe =
            {
            {'1','2','3' },
            {'4','5','6' },
            {'7','8','9' },

            };


        public void PlayGame(Player player1, Player player2)
        {


            for (int i = 0; i < 9; i++)
            {
                int field;
                if (i % 2 == 0)
                {


                    Console.WriteLine("{0}'s turn. Please select the field!", player1.Name);
                    bool validField = int.TryParse(Console.ReadLine(), out field);
                    bool fieldIsAvailable = FieldIsAvailable(field);
                    while (!validField || field < 1 || field > 9 || !fieldIsAvailable)
                    {
                        Console.WriteLine("Incorrect input. {0}'s turn. Please select the field!", player1.Name);
                        validField = int.TryParse(Console.ReadLine(), out field);
                        fieldIsAvailable = FieldIsAvailable(field);
                    }

                    UpdateTable(field, player1);
                    player1.IsWinner = CheckWinning(ticTacToe);
                    if (player1.IsWinner)
                    {
                        Console.Clear();
                        DisplayTable();

                        Console.WriteLine("\n{0} won!!! CONGRATULATIONS!!!", player1.Name);
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("{0}'s turn. Please select the field!", player2.Name);
                    bool validField = int.TryParse(Console.ReadLine(), out field);
                    bool fieldIsAvailable = FieldIsAvailable(field);
                    while (!validField || field < 1 || field > 9 || !fieldIsAvailable)
                    {
                        Console.WriteLine("Incorrect input. {0}'s turn. Please select the field!", player2.Name);
                        validField = int.TryParse(Console.ReadLine(), out field);
                        fieldIsAvailable = FieldIsAvailable(field);

                    }
                    UpdateTable(field, player2);
                    player2.IsWinner = CheckWinning(ticTacToe);
                    if (player2.IsWinner)
                    {
                        Console.Clear();
                        DisplayTable();

                        Console.WriteLine("\n{0} won!!! CONGRATULATIONS!!!", player2.Name);
                        return;
                    }
                }
                Console.Clear();
                DisplayTable();


            }

            Console.WriteLine("Game is a tie!!! Noone wins!!!");

        }

        public void DisplayTable()
        {
            Console.WriteLine("\n");
            for (int k = 0; k < 3; k++)
            {
                for (int i = 0; i < ticTacToe.GetLength(0); i++)
                {
                    for (int j = 0; j < ticTacToe.GetLength(1); j++)
                    {
                        if (i == k)
                        {

                            if (j == 0)
                            {

                                Console.Write("     " + ticTacToe[i, j]);
                            }
                            else
                            {
                                Console.Write("  |  " + ticTacToe[i, j]);
                            }
                        }

                    }
                }
                if (k != 2)
                {
                    Console.WriteLine("\n    ----------------");
                }
                else
                {
                    Console.WriteLine("\n");
                }

            }


        }

        public bool FieldIsAvailable(int field)
        {
            switch (field)
            {
                case 1:
                    if (ticTacToe[0, 0].Equals('X') || ticTacToe[0, 0].Equals('O'))
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                case 2:
                    if (ticTacToe[0, 1].Equals('X') || ticTacToe[0, 1].Equals('O'))
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                case 3:
                    if (ticTacToe[0, 2].Equals('X') || ticTacToe[0, 2].Equals('O'))
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }

                case 4:
                    if (ticTacToe[1, 0].Equals('X') || ticTacToe[1, 0].Equals('O'))
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                case 5:
                    if (ticTacToe[1, 1].Equals('X') || ticTacToe[1, 1].Equals('O'))
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                case 6:
                    if (ticTacToe[1, 2].Equals('X') || ticTacToe[1, 2].Equals('O'))
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                case 7:
                    if (ticTacToe[2, 0].Equals('X') || ticTacToe[2, 0].Equals('O'))
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                case 8:
                    if (ticTacToe[2, 1].Equals('X') || ticTacToe[2, 1].Equals('O'))
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                case 9:
                    if (ticTacToe[2, 2].Equals('X') || ticTacToe[2, 2].Equals('O'))
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                default: return false;


            }
        }
        public void UpdateTable(int field, Player player)
        {
            switch (field)
            {
                case 1:
                    ticTacToe[0, 0] = player.Mark;
                    break;
                case 2:
                    ticTacToe[0, 1] = player.Mark;
                    break;
                case 3:
                    ticTacToe[0, 2] = player.Mark;
                    break;
                case 4:
                    ticTacToe[1, 0] = player.Mark;
                    break;
                case 5:
                    ticTacToe[1, 1] = player.Mark;
                    break;
                case 6:
                    ticTacToe[1, 2] = player.Mark;
                    break;
                case 7:
                    ticTacToe[2, 0] = player.Mark;
                    break;
                case 8:
                    ticTacToe[2, 1] = player.Mark;
                    break;
                case 9:
                    ticTacToe[2, 2] = player.Mark;
                    break;


            }
        }
        public bool CheckWinning(char[,] arr)
        {

            if (arr[0, 0].Equals(arr[0, 1]) && arr[0, 0].Equals(arr[0, 2]))
            {
                return true;
            }
            else if (arr[1, 0].Equals(arr[1, 1]) && arr[1, 0].Equals(arr[1, 2]))
            {
                return true;
            }
            else if (arr[2, 0].Equals(arr[2, 1]) && arr[2, 0].Equals(arr[2, 2]))
            {
                return true;
            }
            else if (arr[0, 0].Equals(arr[1, 0]) && arr[0, 0].Equals(arr[2, 0]))
            {
                return true;
            }
            else if (arr[0, 1].Equals(arr[1, 1]) && arr[0, 1].Equals(arr[2, 1]))
            {
                return true;
            }
            else if (arr[0, 2].Equals(arr[1, 2]) && arr[0, 2].Equals(arr[2, 2]))
            {
                return true;
            }
            else if (arr[0, 0].Equals(arr[1, 1]) && arr[0, 0].Equals(arr[2, 2]))
            {
                return true;
            }
            else if (arr[0, 2].Equals(arr[1, 1]) && arr[0, 2].Equals(arr[2, 0]))
            {
                return true;
            }
            else
            {
                return false;
            }



        }



    }
}



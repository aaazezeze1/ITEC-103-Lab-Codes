using System;

namespace LabTicTacToe
{
    internal class Program
    {
        // Driver Main Function
        static void Main(string[] args)
        {
            // Create an empty char array that's 3 by 3
            char[,] board = new char[3, 3];

            // Start with player X
            char player = 'X';
            bool gameOver = false;

            // Greet the player and show them the rows and columns of the board
            Console.WriteLine("Welcome to Tic-Tac-Toe!");
            Console.WriteLine("Player 'X' starts the game");

            string[,] initialBoard = new string[,] {
                {" ", "   0", "   1", "   2",},
                {"0", "   |", "   |", "   |",},
                {"1", "   |", "   |", "   |",},
                {"2", "   |", "   |", "   |",},
            };

            Console.WriteLine("\nThis is the board layout:");
            Console.WriteLine("Make sure to remember it as the game board won't show the rows and columns");
            Console.WriteLine();

            for (int r = 0; r < initialBoard.GetLength(0); r++)
            {
                for (int c = 0; c < initialBoard.GetLength(1); c++)
                {
                    Console.Write(string.Format("{0}", initialBoard[r, c]));
                }
                Console.WriteLine();
            }

            InitializeGrid(board);
            PlayGame(board, gameOver, player);
        }
        // Create the grid that contains empty arrays
        public static void InitializeGrid(char[,] board)
        {
            for (int r = 0; r < board.GetLength(0); r++)
            {
                // If column is less than the length of the row
                for (int c = 0; c < board.GetLength(0); c++)
                {
                    board[r, c] = ' ';
                }
            }
        }
        // Display the grid
        public static void DisplayGrid(char[,] board)
        {
            Console.WriteLine("\nCurrent Board: ");

            for (int r = 0; r < board.GetLength(0); r++)
            {
                for (int c = 0; c < board.GetLength(0); c++)
                {
                    Console.Write(board[r, c] + " | ");
                }
                Console.WriteLine();
            }
        }
        // Get players moves
        public static void GetPlayerMove(char[,] board, bool gameOver, char player)
        {
            while (!gameOver)
            {
                // Try catch for error handling incase the input is a string instead of a number in the correct format
                try
                {
                    DisplayGrid(board);
                    Console.Write("\nPlayer '" + player + "' enter a row and column (e.g., 1 2): ");
                    string[] input = Console.ReadLine().Split();
                    int row = int.Parse(input[0]);
                    int col = int.Parse(input[1]);

                    // Check if the space is empty
                    if (board[row, col] == ' ')
                    {
                        board[row, col] = player;
                        gameOver = CheckWin(board, player);

                        if (gameOver)
                        {
                            DisplayGrid(board);
                            DisplayResult(player);
                            PlayAgainPrompt(gameOver, board, player);
                            break;
                        }
                        else
                        {
                            player = (player == 'X') ? 'O' : 'X';
                        }

                        // Check for tie if there's no winner yet
                        if (!CheckWin(board, player))
                        {
                            // If the board is full then its a draw otherwise game continues
                            if (CheckDraw(board))
                            {
                                DisplayGrid(board);
                                Console.WriteLine("\nThe game is a tie");
                                gameOver = true;
                                PlayAgainPrompt(gameOver, board, player);
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid Move, Try Again");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("\nPlease Try Again");
                }
            }
        }
        // Check the winner
        public static bool CheckWin(char[,] board, char player)
        {
            // Check for the rows
            for (int r = 0; r < board.GetLength(0); r++)
            {
                if (board[r, 0] == player && board[r, 1] == player && board[r, 2] == player)
                {
                    return true;
                }
            }

            // Check for the columns
            for (int c = 0; c < board.GetLength(0); c++)
            {
                if (board[0, c] == player && board[1, c] == player && board[2, c] == player)
                {
                    return true;
                }
            }

            // Check for the diagonals
            if (board[0, 0] == player && board[1, 1] == player && board[2, 2] == player)
            {
                return true;
            }

            if (board[0, 2] == player && board[1, 1] == player && board[2, 0] == player)
            {
                return true;
            }

            // If none of the conditions are met
            return false;
        }
        // Check if draw
        public static bool CheckDraw(char[,] board)
        {
            // Check if there's still empty spaces and if not then the game is a draw
            for (int r = 0; r < board.GetLength(0); r++)
            {
                for (int c = 0; c < board.GetLength(0); c++)
                {
                    if (board[r, c] == ' ')
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public static void PlayGame(char[,] board, bool gameOver, char player)
        {
            GetPlayerMove(board, gameOver, player);
        }
        // Display the winner
        public static void DisplayResult(char player)
        {
            Console.WriteLine("\nPlayer '" + player + "' wins!");
        }
        // Give option to play again
        public static void PlayAgainPrompt(bool gameOver, char[,]board, char player)
        {
            Console.Write("\nDo you want to play again (y/n): ");
            string ans = Console.ReadLine();
            ans.ToLower();

            while (ans == " ")
            {
                Console.Write("\nDo you want to play again (y/n): ");
                ans = Console.ReadLine();
                ans.ToLower();
            }

            if (ans.ToLower() == "y")
            {
                InitializeGrid(board);
                gameOver = false;
                PlayGame(board, gameOver, player);
            } else if (ans.ToLower() == "n")
            {
                Console.WriteLine("\nThanks for playing!");
            } else
            {
                Console.WriteLine("\nProgram Exited");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 井字遊戲
{
    internal class Program
    {
		// TicTacToe2.Program.Display

		static void Display(char[,] board)
		{
			Console.Clear();
			Console.WriteLine(" 0 1 2 ");
			Console.WriteLine(" ");
			Console.WriteLine("0 {0} | {1} | {2} ", board[0, 0], board[0, 1], board[0, 2]);
			Console.WriteLine(" ---+---+---");
			Console.WriteLine("1 {0} | {1} | {2} ", board[1, 0], board[1, 1], board[1, 2]);
			Console.WriteLine(" ---+---+---");
			Console.WriteLine("2 {0} | {1} | {2} ", board[2, 0], board[2, 1], board[2, 2]);
			Console.WriteLine(" ");
		}

		// TicTacToe2.Program.TakeAPosition

		static void TakeAPosition(Random rand, char[,] board, out int io, out int jo)
		{
			do
			{
				int k = rand.Next() % 9;
				io = k / 3;
				jo = k % 3;
			}
			while (board[io, jo] != ' ');
			board[io, jo] = 'o';
		}

		// TicTacToe2.Program.Won

		static bool Won(int io, int jo, char[,] board)
		{
			if ((board[io, 0] == board[io, 1]) && (board[io, 1] == board[io, 2])) return true;
			if ((board[0, jo] == board[1, jo]) && (board[1, jo] == board[2, jo])) return true;
			if ((board[0, 0] == board[io, jo]) && (board[1, 1] == board[io, jo]) && (board[2, 2] == board[io, jo])) return true;
			if ((board[0, 2] == board[io, jo]) && (board[1, 1] == board[io, jo]) && (board[2, 0] == board[io, jo])) return true;
			return false;
		}

		// TicTacToe2.Program.HasVacancies

		static bool HasVacancies(char[,] board)
		{
			bool hasVacancies = false;
			for (int i = 0; i < 3; ++i)
			{
				for (int j = 0; j < 3; ++j)
				{
					if (board[i, j] == ' ')
					{
						hasVacancies = true;
						break;
					}
				}
			}
			return hasVacancies;
		}


		static void Main(string[] args)
        {
			Char[,] board = {{' ',' ',' '},
							 {' ','o',' '},
							 {' ',' ',' '}};

			Random rand = new Random();
			bool hasVacancies, userWin, computerWin = true;

			do
			{
				Display(board);
				Console.Write("輸入x位置的座標, 以逗點分隔: ");
				string[] input = new string[2];
				input = Console.ReadLine().Split(',');
				int ix = Convert.ToInt16(input[0]);
				int jx = Convert.ToInt16(input[1]);

				board[ix, jx] = 'x';

				userWin = Won(ix, jx, board);
				hasVacancies = HasVacancies(board);

				if (userWin || !hasVacancies) break;
					TakeAPosition(rand, board, out int io, out int jo);
					computerWin = Won(io, jo, board);

				if (computerWin) break;
					hasVacancies = HasVacancies(board);
			}
			while (hasVacancies);
				Display(board);

			if (userWin)
			{
				Console.WriteLine("使用者獲勝");
			}
			else if (computerWin)
			{
				Console.WriteLine("電腦獲勝");
			}
			else
			{
				Console.WriteLine("平手");
			}
		}
    }
}

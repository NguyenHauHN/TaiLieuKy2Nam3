using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    class Program
    {
        public static int[,] S;
        public static void DocFile()
        {
            string[] lines = System.IO.File.ReadAllLines(@"E:\Phân tích thiết kế giải thuật\Bài tập\Quay lui\Sudoku\Data\input.txt");
            int row = 0;
            int column;
            string[] element = new string[10];
            foreach (string line in lines)
            {
                element = line.Split(' ');
                if (row != 0)
                {
                    for (column = 1; column < element.Length; column++)
                    {
                        S[row, column] = Convert.ToInt32(element[column]);
                    }
                }

                row++;
            }
        }

        public static void GhiFile()
        {
            int i, j;
            System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"E:\Phân tích thiết kế giải thuật\Bài tập\Quay lui\Sudoku\Data\output.txt");
            string line = null;
            for (i = 1; i <= 9; i++)
            {
                for (j = 1; j <= 9; j++)
                {
                    if (j != 9)
                    {
                        line += S[i, j].ToString() + " ";
                    }
                    else
                        line += S[i, j].ToString();

                }
                file.WriteLine(line);
                System.Console.WriteLine(line);
                line = null;
            }
            file.Close();
        }

        public static bool Feasible(int x, int y, int k)
        {
            int i, j;
            // xet hang x va cot y xem co gia tri trung voi k hay khong
            for (i = 1; i <= 9; i++)
            {
                if (S[x, i] == k)
                {
                    return false;
                }
            }
            for (j = 1; j <= 9; j++)
            {
                if (S[j, y] == k)
                {
                    return false;
                }
            }
            // xet trong hinh vuong 3 X 3 xem co gia tri trung voi k hay khong
            int a, b;
            a = (x - 1) / 3; b = (y - 1) / 3;
            for (i = 3 * a + 1; i <= 3 * a + 3; i++)
            {
                for (j = 3 * b + 1; j <= 3 * b + 3; j++)
                {
                    if (S[i, j] == k)
                    {
                        return false;
                    }
                }

            }
            return true;
        }

        public static void SudokuFunc(int x, int y)
        {
            int k;
            if (y == 10)
            {
                if (x == 9)
                {
                    // print s
                    GhiFile();
                }
                else
                    SudokuFunc(x + 1, 1);
            }
            else if (S[x, y] == 0)
            {
                for (k = 1; k <= 9; k++)
                {
                    if (Feasible(x, y, k))
                    {
                        S[x, y] = k;
                        SudokuFunc(x, y + 1);
                        S[x, y] = 0;
                    }
                }
            }
            else
                SudokuFunc(x, y + 1);
        }

        static void Main(string[] args)
        {
            S = new int[11, 11];
            DocFile();
            SudokuFunc(1, 1);
            System.Console.ReadKey();
        }
    }
}

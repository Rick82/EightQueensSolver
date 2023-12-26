using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightQueens
{
    public class EightQueensSolver
    {
        public int SolutionCount { get; private set; }
        private int[] Queens;
        private readonly int N;

        /// <summary>
        /// Support N Queens, default is 8
        /// </summary>
        /// <param name="num"></param>
        public EightQueensSolver(int num = 8)
        {
            N = num;
            Queens = new int[num];
        }

        /// <summary>
        /// From 1 to N Put Queen
        /// </summary>
        /// <param name="num">which queen in Queens</param>
        public void PutQueen(int num)
        {
            for (var i = 1; i <= N; i++)
            {
                if (num == N)
                {
                    SolutionCount++;
                    Write();
                    Console.WriteLine();
                    break;
                }
                //isSafe
                if (IsSafe(num, i))
                {
                    Queens[num] = i;
                    PutQueen(num + 1);
                }
            }
        }

        /// <summary>
        /// Is the current location safe?
        /// </summary>
        /// <param name="row">already settle queen count</param>
        /// <param name="queen">newer queen</param>
        /// <returns></returns>
        private bool IsSafe(int row, int queen)
        {
            if (row == 0)
            {
                return true;
            }
            else
            {
                for (var pointer = 0; pointer < row; pointer++)
                {
                    if (!Compare(Queens[pointer], row - pointer, queen))
                    {
                        return false;
                    }
                }
                return true;
            }
        }

        /// <summary>
        /// verify diagonals
        /// </summary>
        /// <param name="i">Nth settle queen</param>
        /// <param name="row"></param>
        /// <param name="queen">newer queen</param>
        /// <returns></returns>
        public bool Compare(int i, int row, int queen)
        {
            //position is the same or diagonals
            if ((i == queen) || ((i - queen) == row) || ((queen - i) == row))
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Print out solution 
        /// </summary>
        public void Write()
        {
            Console.WriteLine($"//Solution {SolutionCount}");
            for (var i = 0; i < N; i++)
            {
                for (var j = 1; j < N + 1; j++)
                {
                    if (j == Queens[i])
                    {
                        Console.Write("Q");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
                //换行
                Console.Write("\n");
            }
        }
    }
}

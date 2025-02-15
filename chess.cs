﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class chesssolver
    {
        static int N;
        static void printBoard(int[,] board)
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(board[i, j] + " ");
                }
                Console.Write("\n");
            }
        }
        static Boolean toPlaceOrNotToPlace(int[,] board, int row, int col)
        {
            int i, j;
            for (i = 0; i < col; i++)
            {
                if (board[row, i] == 1) return false;
            }
            for (i = row, j = col; i >= 0 && j >= 0; i--, j--)
            {
                if (board[i, j] == 1) return false;
            }
            for (i = row, j = col; j >= 0 && i < N; i++, j--)
            {
                if (board[i, j] == 1) return false;
            }
            return true;
        }
        static Boolean theBoardSolver(int[,] board, int col)
        {
            if (col >= N) return true;
            for (int i = 0; i < N; i++)
            {
                if (toPlaceOrNotToPlace(board, i, col))
                {
                    board[i, col] = 1;
                    if (theBoardSolver(board, col + 1)) return true;

                    board[i, col] = 0;
                }
            }
            return false;
        }
        public void chesssolvealgo()
        {
            Console.WriteLine("state size of chess table exp '4'");
            N = Convert.ToInt32(Console.ReadLine());
            int[,] board = new int[N, N];
            if (!theBoardSolver(board, 0))
            {
                Console.WriteLine("Solution not found.");
            }
            printBoard(board);
            Console.ReadLine();
        }
    }

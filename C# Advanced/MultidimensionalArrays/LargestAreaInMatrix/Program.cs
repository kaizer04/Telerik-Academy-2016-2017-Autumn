﻿namespace LargestAreaInMatrix
{
    // DFS Solution
    using System;

    public class Program
    {
        static short[,] matrix;
        static bool[,] visitedElements;
        static int counter;
        static short height;  //matrix "height"
        static short width;  //matrix "width"

        public static void Main()
        { 
            //input and values
            string[] input = Console.ReadLine().Split(' ');
            height = short.Parse(input[0]);  //rows
            width = short.Parse(input[1]);  //cols

            matrix = new short[height, width]; //create Master Matrix from user's values
            for (int row = 0; row < height; row++)
            {
                string[] tempStr = Console.ReadLine().Split(' ');
                for (int col = 0; col < width; col++)
                {
                    matrix[row, col] = short.Parse(tempStr[col]);
                }
            }

            visitedElements = new bool[height, width]; //this matrix will keep only the number of equal elements. This is "dynamic programing" technique. See: 01.Arrays\18.RemoveElementsFromArray
            for (int row = 0; row < height; row++) //define all element with value "1"
            {
                for (int col = 0; col < width; col++)
                {
                    visitedElements[row, col] = false;
                }
            }

            //calculation
            MatrixCalculation();
            //print
            Console.WriteLine(counter);
        }

        static void MatrixCalculation()
        {
            int currentCounter = 0;
            short element = 0;
            for (int row = 0; row < height; row++)
            {
                for (int col = 0; col < width; col++)
                {
                    element = matrix[row, col];
                    DFS(element, row, col, ref currentCounter);
                    counter = MaxCounter(ref currentCounter);
                }
            }
        }

        static void DFS(short element, int row, int col, ref int currentCounter)
        {
            if (row < 0 || col < 0 || row >= height || col >= width || visitedElements[row, col] == true)
            {
                return;
            }
            if (matrix[row, col] == element)
            {
                currentCounter++;
                visitedElements[row, col] = true;
                //recursion
                DFS(element, (row + 1), col, ref currentCounter);  //down
                DFS(element, row, (col + 1), ref currentCounter);  //right
                DFS(element, row, (col - 1), ref currentCounter);  //left
                DFS(element, (row - 1), col, ref currentCounter);  //up
            }
        }

        static int MaxCounter(ref int currentCounter)
        {
            if (currentCounter > counter)
            {
                counter = currentCounter;
            }

            currentCounter = 0;

            return counter;
        }
    }
}

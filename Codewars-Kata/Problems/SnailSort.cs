﻿//Snail Sort
//Given an n x n array, return the array elements arranged from outermost elements to the middle element, traveling clockwise.

//array = [[1,2,3],
//         [4,5,6],
//         [7,8,9]]
//snail(array) #=> [1,2,3,6,9,8,7,4,5]

//For better understanding, please follow the numbers of the next array consecutively:

//array = [[1, 2, 3],
//         [8,9,4],
//         [7,6,5]]
//snail(array) #=> [1,2,3,4,5,6,7,8,9]

//This image will illustrate things more clearly:

//https://www.codewars.com/kata/521c2db8ddc89b9b7a0000c1

//NOTE: The idea is not sort the elements from the lowest value to the highest; the idea is to traverse the 2-d array in a clockwise snailshell pattern.

//NOTE 2: The 0x0(empty matrix) is represented as en empty array inside an array [[]].

namespace Codewars_Kata.Problems;

internal class SnailSort
{
    public class SnailSolution
    {
        public static int[] Snail(int[][] array)
        {
            int l = array[0].Length;
            int[] sorted = new int[l * l];
            Snail(array, -1, 0, 1, 0, l, 0, sorted);
            return sorted;
        }

        public static void Snail(int[][] array, int x, int y, int dx, int dy, int l, int i, int[] sorted)
        {
            if (l == 0)
                return;
            for (int j = 0; j < l; j++)
            {
                x += dx;
                y += dy;
                sorted[i++] = array[y][x];
            }
            Snail(array, x, y, -dy, dx, dy == 0 ? l - 1 : l, i, sorted);
        }
    }
}

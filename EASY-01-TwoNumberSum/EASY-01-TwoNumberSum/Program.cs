/*
Write a function that takes in a non-empty array of distinct integers 
and an integer representing a target sum. If any two numbers in the 
input array sum up to the target sum, the function should return 
them in an array. If no two numbers sum up to the target sum, the 
function should return an empty array. Assume that there will be at 
most one pair of numbers summing up to the target sum.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EASY_01_TwoNumberSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 3, 5, -4, 8, 11, 1, -1, 6 };
            int targetSum = 10;

            System.Console.WriteLine("[{0}]", string.Join(", ", TwoNumberSum(array, targetSum)));

            System.Console.ReadLine();
        }

        public static int[] TwoNumberSum(int[] array, int targetSum)
        {
            // SolutionFound = false;
            int[] solution = new int[2];
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] + array[j] == targetSum)
                    {
                        solution[0] = array[i];
                        solution[1] = array[j];
                        return solution;
                    }
                }
            }
            return null;
        }
    }
}

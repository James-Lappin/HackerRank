using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HackerRank.CrackingTheCodingInterview
{
    // https://www.hackerrank.com/challenges/ctci-array-left-rotation/problem
    public class LeftRotation
    {
        public void Main(String[] args)
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int k = Convert.ToInt32(tokens_n[1]);
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);

            foreach (var element in RotateLeft(a, k))
            {
                Console.Write(element + " ");
            }
        }

        public int[] RotateLeft(int[] array, int numberOfRotations)
        {
            var lengthOfArray = array.Length;
            var rotatedArry = new int[lengthOfArray];

            var point = lengthOfArray - numberOfRotations;
            for (int i = 0; i < lengthOfArray; i++)
            {
                var arrayIndex = i;
                if (i < point)
                {
                    arrayIndex += numberOfRotations;
                }
                else
                {
                    arrayIndex = i - point;
                }

                rotatedArry[i] = array[arrayIndex];
            }

            return rotatedArry;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhereIsVasya_CodeWars
{
    public static class Line
    {
        // Based on p (numPeople), there are no less than b (minInFront) people in front of Vasya and no more than a (maxBehind) people behind him.
        public static int WhereIsHe(int numPeople, int minInFront, int maxBehind)
        {
            if (!ValidateParameters(numPeople, minInFront) || !ValidateParameters(numPeople, maxBehind))
            {
                Console.WriteLine("Neither the number of people in front of Vasya nor the number of people behind him can be greater than or equal to the total number of people in line.");
                return 0;
            }

            int[] positionsFromMinInFront = GetPositionsFromMinInFront(numPeople, minInFront);
            int[] positionsFromMaxBehind = GetPositionsFromMaxBehind(numPeople, maxBehind);
            int[] overlap = GetOverlap(positionsFromMinInFront, positionsFromMaxBehind);

            int numPossiblePositions = overlap.Length;
            return numPossiblePositions;
        }

        // Make sure minInFront and maxBehind are not greater than numPeople.
        public static Boolean ValidateParameters(int numPeople, int number)
        {
            if (number >= numPeople)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        // Get the possible positions from line variables
        public static int[] GetPositionsFromMinInFront(int numPeople, int minInFront)
        {
            int[] possiblePositions = new int[numPeople - minInFront];

            int numPositions = numPeople - minInFront;

            for (int i = 0; i < possiblePositions.Length; i++)
            {
                if (numPositions > 0)
                {
                    possiblePositions[i] = numPositions;
                    numPositions--;
                }
            }

            return possiblePositions;
        }

        // Get the possible positions from line variables
        public static int[] GetPositionsFromMaxBehind(int numPeople, int maxBehind)
        {
            int[] possiblePositions = new int[maxBehind + 1];

            int numPositions = maxBehind + 1;

            for (int i = 0; i < possiblePositions.Length; i++)
            {
                if (numPositions > 0)
                {
                    possiblePositions[i] = numPositions;
                    numPositions--;
                }
            }

            return possiblePositions;
        }

        public static int[] GetOverlap(int[] positionsFromMinInFront, int[] positionsFromMaxBehind)
        {
            int[] overlap = new int[GetLengthOfShortestArray(positionsFromMinInFront, positionsFromMaxBehind)];
            int numInOverlap = 0;

            for (int i = 0; i < positionsFromMaxBehind.Length; i++)
            {
                for (int j = 0; j < positionsFromMinInFront.Length; j++)
                {
                    if (positionsFromMaxBehind[i] == positionsFromMinInFront[j])
                    {
                        overlap[numInOverlap] = positionsFromMaxBehind[i];
                        numInOverlap++;
                    }
                }
            }

            return overlap;
        }

        public static int GetLengthOfShortestArray(int[] positionsFromMinInFront, int[] positionsFromMaxBehind)
        {
            if (positionsFromMinInFront.Length < positionsFromMaxBehind.Length)
            {
                return positionsFromMinInFront.Length;
            }
            else if (positionsFromMaxBehind.Length < positionsFromMinInFront.Length)
            {
                return positionsFromMaxBehind.Length;
            }
            else // if both arrays are the same length
            {
                return positionsFromMinInFront.Length;
            }
        }
    }
}

//Vasya stands in line with number of people p (including Vasya), but he doesn't know exactly which position he occupies. 
//He can say that there are no less than b people standing in front of him and no more than a people standing behind him. 
//Find the number of different positions Vasya can occupy.

//Input

//As an input you have 3 numbers:

//1. Total amount of people in the line;

//2. Number of people standing in front of him

//3. Number of people standing behind him

//Examples:

//Line.WhereIsHe(3, 1, 1) // => 2  The possible positions are: 2 and 3

//Line.WhereIsHe(5, 2, 3) // => 3  The possible positions are: 3, 4 and 5
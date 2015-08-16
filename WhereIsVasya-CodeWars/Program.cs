using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhereIsVasya_CodeWars
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Line.WhereIsHe(7, 3, 5));

            Console.ReadLine();
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
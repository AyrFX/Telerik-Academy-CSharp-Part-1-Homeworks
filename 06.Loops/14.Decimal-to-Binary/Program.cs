﻿/*
 * Problem 14. Decimal to Binary Number
 * Using loops write a program that converts an integer number to its binary representation.
 * The input is entered as long. The output should be a variable of type string.
 * Do not use the built-in .NET functionality.
 * 
 * Examples:
 * decimal 	    binary
 * 0 	        0
 * 3 	        11
 * 43691 	    1010101010101011
 * 236476736 	1110000110000101100101000000
 */

using System;

class DecimalToBinary
{
    static void Main()
    {
        Console.Write("Please enter integer: ");
        long intNumber = long.Parse(Console.ReadLine());
        string result = "";
        do
        {
            result = (intNumber % 2) + result;
            intNumber = intNumber / 2;
        }
        while (intNumber >= 1);
        Console.WriteLine(result);
    }
}
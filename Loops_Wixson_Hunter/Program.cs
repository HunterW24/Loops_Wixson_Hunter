using System;

class Program
{
    static void Main(string[] args)
    {
        // Input string
        string inputString = "Hello world! How are you?";

        // Count spaces in the input string
        int spaceCount = CountSpaces(inputString);

        // Print the input string and the number of spaces
        Console.WriteLine("Input String: " + inputString);
        Console.WriteLine("Number of Spaces: " + spaceCount);

        // Input number
        long inputNumber = 123456789;

        // Calculate the sum of digits in the input number
        long digitSum = CalculateDigitSum(inputNumber);

        // Print the input number and the sum of its digits
        Console.WriteLine("\nInput Number: " + inputNumber);
        Console.WriteLine("Sum of Digits: " + digitSum);
    }

    // Function to count spaces in a string
    static int CountSpaces(string input)
    {
        int count = 0;
        foreach (char c in input)
        {
            if (c == ' ')
                count++;
        }
        return count;
    }

    // Function to calculate the sum of digits in a number
    static long CalculateDigitSum(long number)
    {
        long sum = 0;
        while (number > 0)
        {
            sum += number % 10;
            number /= 10;
        }
        return sum;
    }
}

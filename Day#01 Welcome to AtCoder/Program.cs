/*
Welcome to AtCoder — Problem A: Welcome to AtCoder

Problem summary:
- You are given three integers a, b, c and a string s.
- Input format (three lines):
    Line 1: a
    Line 2: b c   (two integers separated by a space)
    Line 3: s
- Output: print (a + b + c) followed by a half-width space and then s in one line.

*/

using System;

class Program
{
    static void Main()
    {
        // read first integer 'a'
        int a = int.Parse(Console.ReadLine()!);

        // read second line and split into 'b' and 'c'
        var parts = Console.ReadLine()!.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
        int b = int.Parse(parts[0]);
        int c = int.Parse(parts[1]);

        // Step 3: read the string 's'
        string s = Console.ReadLine()!;

        // Step 4: calculate sum
        int sum = a + b + c;

        // Step 5: output in required format (half-width space between sum and s)
        Console.WriteLine($"{sum} {s}");
    }
}

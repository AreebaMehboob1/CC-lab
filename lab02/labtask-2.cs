using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string input = "a && b || !c == d != e <= f >= g < h > i";
        
        // Regular expression for logical operators
        string logicalPattern = @"(&&|\|\||!)";
        
        // Regular expression for relational operators
        string relationalPattern = @"(==|!=|<=|>=|<|>)";
        
        Regex logicalRegex = new Regex(logicalPattern);
        Regex relationalRegex = new Regex(relationalPattern);
        
        // Find and print logical operators
        Console.WriteLine("Logical operators found:");
        foreach (Match match in logicalRegex.Matches(input))
        {
            Console.WriteLine(match.Value);
        }
        
        // Find and print relational operators
        Console.WriteLine("\nRelational operators found:");
        foreach (Match match in relationalRegex.Matches(input))
        {
            Console.WriteLine(match.Value);
        }
    }
}

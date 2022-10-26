using System;
using System.Collections;

public class Parentheses
{
    public static void Main()
    {
        Console.WriteLine("Enter a string with parentheses: ");
        string input = Console.ReadLine();
        
        if (CheckParentheses(input))
            Console.WriteLine("The parentheses are balanced.");
        else
            Console.WriteLine("The parentheses are not balanced.");
    }

    public static bool IsBalanced(string s)
    {
        Stack stack = new Stack();
        foreach (char c in s)
        {
            if (c == '(' | c == '[' | c == '{')
            {
                stack.Push(c);
            }
            else if (c == ')' | c == ']' | c == '}')
            {
                if (stack.Count == 0)
                {
                    return false;
                }
                char c2 = (char)stack.Pop();
                if (c == ')' & c2 != '(')
                {
                    return false;
                }
                if (c == ']' & c2 != '[')
                {
                    return false;
                }
                if (c == '}' & c2 != '{')
                {
                    return false;
                }
            }
        }
        return stack.Count == 0;
    }
}

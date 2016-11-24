using System;
using System.Collections.Generic;

class Rpn
{
    public static void Main()
    {
        var input = Console.ReadLine();

        var stack = new Stack<string>(input.Split(' '));

        var result = Calculate(stack);

        Console.WriteLine(result);
    }

    private static int Calculate(Stack<string> stack)
    {
        var current = stack.Pop();
        int x, y;
        if (!int.TryParse(current,out x))
        {
            y = Calculate(stack);
            x = Calculate(stack);
            if (current == "+")
            {
                x += y;
            }
            else if (current == "-")
            {
                x -= y;
            }
            else if (current == "*")
            {
                x *= y;
            }
            else if (current == "/")
            {
                x /= y;
            }
            else if (current == "&")
            {
                x &= y;
            }
            else if (current == "|")
            {
                x |= y;
            }
            else if (current == "^")
            {
                x ^= y;
            }
        }

        return x;
    }
}
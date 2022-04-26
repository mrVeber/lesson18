using System;
using System.Collections.Generic;
using System.Collections;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string str = Console.ReadLine();
            Console.WriteLine($"{Check(str)}");
            Console.ReadKey();

        }
        static bool Check (string str)
        {
        

            Stack<char> stack = new Stack<char>();
            
            Dictionary<char, char> bracket = new Dictionary<char, char> 
            {
                { '(',')'},
                { '{','}'},
                { '[',']'},
            };

            foreach (var c in str)
            {
                if (c == '(' || c == '{' || c == '[')
                    stack.Push(bracket[c]);
                if (c == ')' || c == '}' || c == ']')
                {
                    if (stack.Count == 0 || stack.Pop() != c)
                    {
                        return false;
                    }
                }
            }
            if (stack.Count == 0)
                return true;
            else
                return false;
        }
    }
}

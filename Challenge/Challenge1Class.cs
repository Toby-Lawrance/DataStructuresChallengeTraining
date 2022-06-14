using System;
using System.Collections.Generic;
using System.Linq;

namespace Challenge
{
    public class Challenge1Class
    {
        /// <summary>
        /// Check whether the parantheses in the expression are balanced.
        /// e.g. "[(())]" is balanced, "[)()]" is not, nor is "[()"
        /// </summary>
        /// <param name="input">A string containing only paranthesses characters, "[]", "()", "{}", "<>"</param>
        /// <returns>True if the parantheses are balanced. False otherwise</returns>
        public static bool Challenge1(string input)
        {
            var check = new Stack<char>();
            foreach (var c in input)
            {
                switch (c)
                {
                    case ')':
                        if (!check.Any() || check.Peek() != '(') return false;
                        check.Pop();
                        break;
                    case ']': 
                        if (!check.Any() || check.Peek() != '[') return false;
                        check.Pop();
                        break;
                    case '}': 
                        if (!check.Any() || check.Peek() != '{') return false;
                        check.Pop();
                        break;
                    case '>': 
                        if (!check.Any() || check.Peek() != '<') return false;
                        check.Pop();
                        break;
                    default:
                        check.Push(c);
                        break;
                }
            }

            return check.Count == 0;
        }

        
    }
}
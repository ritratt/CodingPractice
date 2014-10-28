using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPractice.Stack
{
    public class ParanthesisChecker
    {
        private String paranthesis;
        public ParanthesisChecker(String s)
        {
            paranthesis = s;
        }
        bool IsPoppable(char s1, char s2)
        {
            if (Math.Abs((int) s1 - (int) s2) == 2 || Math.Abs((int) s1 - (int) s2) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsCorrect()
        {
            var stack = new Stack<char>();
            var charArr = paranthesis.ToCharArray();

            for (int i = 0; i < charArr.Length; i++)
            {
                if (i == 0 || stack.Count == 0)
                {
                    stack.Push(charArr[i]);
                    continue;
                }

                if (IsPoppable(stack.Peek(), charArr[i]))
                {
                    stack.Pop();
                }
                else
                {
                    stack.Push(charArr[i]);
                }
            }

            if (stack.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

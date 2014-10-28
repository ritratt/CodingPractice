using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPractice.Stack
{
    public class ReverseString
    {
        private String original;
        private String reversed;

        public ReverseString()
        {
            original = "Default String";
        }

        public ReverseString(String s)
        {
            original = s;
        }

        public void Reverse()
        {
            var charArray = original.ToCharArray();
            Stack<Char> stack = new Stack<Char>();

            for (int i = 0; i < charArray.Length; i++)
            {
                stack.Push(charArray[i]);
            }

            var count = stack.Count;
            for (int i = 0; i < count; i++)
            {
                Console.Write(stack.Pop());
            }
        }
    }
}

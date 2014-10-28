using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPractice.Stack
{
    public class NextGreaterElement
    {
        private Stack<int> original = new Stack<int>();
        private Stack<int> s1 = new Stack<int>();
        private Stack<int> s2 = new Stack<int>();
        
        public NextGreaterElement(String numbers)
        {
            foreach (var c in numbers.ToCharArray())
            {
                original.Push(int.Parse(c.ToString()));
            }

            s1.Push(original.Pop());
            Console.WriteLine("Next greatest for " + s1.Peek() + " is -1");

            if (original.Peek() < s1.Peek())
            {
                Console.WriteLine("Next greatest for " + original.Peek() + " is " + s1.Peek());
                s1.Push(original.Pop());
            }
        }

        public void DoStuffOne()
        {
            int currentLargest = -1;

            while (s1.Count != 0)
            {
                if (s1.Peek() > original.Peek())
                {
                    currentLargest = s1.Peek();
                }
                s2.Push(s1.Pop());
            }
            Console.WriteLine("Next greatest for " + original.Peek() + " is " + currentLargest);
            s1.Push(original.Pop());
        }

        public void DoStuffTwo()
        {
            int currentLargest = -1;

            while (s2.Count != 0)
            {
                if (s2.Peek() > original.Peek())
                {
                    currentLargest = s2.Peek();
                }
                s1.Push(s2.Pop());
            }
            Console.WriteLine("Next greatest for " + original.Peek() + " is " + currentLargest);
            s2.Push(original.Pop());
        }

        public void SolveThisShiz()
        {
            while (original.Count != 0)
            {
                if (s1.Count == 0)
                {
                    DoStuffTwo();
                }
                else
                {
                    DoStuffOne();
                }
            }
        }
    }
}

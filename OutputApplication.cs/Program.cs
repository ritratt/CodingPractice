using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodingPractice.Stack;

namespace OutputApplication.cs
{
    class Program
    {

        public static void Main()
        {
            //var reverser = new ReverseString("PallinDrome");
            //reverser.Reverse();

            /* TwoStacks
            var twostacks = new TwoStacks(3, 4);
            twostacks.Push1(1);
            twostacks.Push1(2);
            twostacks.Push1(3);

            twostacks.Push2(4);
            twostacks.Push2(5);
            twostacks.Push2(6);
            twostacks.Push2(7);

            Console.WriteLine(twostacks.Pop1());
            Console.WriteLine(twostacks.Pop2());
            Console.WriteLine(twostacks.Pop1());
            Console.WriteLine(twostacks.Pop2());
            Console.WriteLine(twostacks.Pop2());
            */

            //Paranthesis Checker
            /*
            ParanthesisChecker pc = new ParanthesisChecker("{([{}])]}");
            Console.WriteLine(pc.IsCorrect());
            */

            //Next Greatest Element
            var nge = new NextGreaterElement("8597324");
            nge.SolveThisShiz();
        }
    }
}

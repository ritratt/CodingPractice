using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPractice.Stack
{
    public class TwoStacks
    {
        private int[] arr;
        private int size1, size2;
        private int count1, count2;

        public TwoStacks(int s1, int s2)
        {
            size1 = s1;
            size2 = s2;

            count1 = 0;
            count2 = count1 + size1;

            arr = new int[size1 + size2];
        }

        public void Push1(int d)
        {
            if (count1 == size1)
            {
                Console.WriteLine("Stack Overflow");
                return;
            }

            arr[count1] = d;
            count1++;
        }

        public void Push2(int d)
        {
            if (count2 == size2 + size1)
            {
                Console.WriteLine("Stack Overflow");
                return;
            }

            arr[count2] = d;
            count2++;
        }

        public int Pop1()
        {
            return arr[count1--];
        }

        public int Pop2()
        {
            return arr[--count2];
        }
    }
}

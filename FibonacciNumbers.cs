using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSUIR_Lab_7_Tasks_3
{
    internal class FibonacciNumbers
    {
        private int start;
        private int end;
        public int Start { get { return start; } }
        public int End { get { return end; } }
        
        public FibonacciNumbers() { }
        public FibonacciNumbers(int start, int end) :this() 
        { 
            if (start < 0 || end  <= 0 || start > end) throw new ArgumentOutOfRangeException(" Неверно указаны числа.");
            this.start = start; 
            this.end = end; 
        }

        public IEnumerable<int> GetNumbers()
        {
            if (start ==0 && end == 1)
            {
                yield return 1;
                yield break;
            }

            int number1 = 0;
            int number2 = 1;
            int tempNumber = number1 + number2;

            if (number1 >= start) yield return number1;
            if (number2 >= start) yield return number2;

            while (true)
            {
                if (tempNumber >= end) yield break;
                if (tempNumber >= start) yield return tempNumber;
          
                number1 = number2;
                number2 = tempNumber;
                tempNumber = number1 + number2;
            } 
        }

    }
}

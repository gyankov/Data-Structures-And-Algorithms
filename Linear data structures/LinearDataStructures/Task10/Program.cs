using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, M;
            Stack<string> s = new Stack<string>();

            Console.Write("Enter N: ");
            N = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter M: ");
            M = Convert.ToInt32(Console.ReadLine());

            double newM = M, newN = N;
            if (N == 0)
            {
                newN = 1;
            }
            while (newM >= newN)
            {
                if (newM % 2 == 1 && newM != N)
                {
                    if (newM - 2 == newN)
                    {
                        newM -= 2;
                        s.Push("+ 2 ");
                    }
                    else
                    {
                        newM -= 1;
                        s.Push("+ 1 ");
                    }
                }
                newM /= 2;
                if (newM > newN)
                {
                    s.Push("* 2 ");
                }
            }
            newM *= 2;
            while (newM >= newN + 2)
            {
                newM -= 2;
                s.Push("+ 2 ");
            }
            if (newM == newN + 1)
            {
                s.Push("+ 1 ");
            }

            if (N == 0)
            {
                if (s.Peek() == "+ 1 ")
                {
                    s.Pop();
                    s.Push("+ 2 ");
                }
                else
                {
                    s.Push("+ 1 ");
                }
            }

            Console.Write("{0} ", N);
            foreach (string oper in s)
            {
                Console.Write(oper);
            }           
        }
    }
}

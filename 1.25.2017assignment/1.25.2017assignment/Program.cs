using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._25._2017assignment
{
    class Program
    {
        static public char Invert(char s)
        {
            return ((s == '0') ? '1' : '0');
        }

        public class Gene
        {
            public Gene(string s)
            {
                if (s.Length != 8)
                    throw new Exception("too big or too small... must be 8 long");
                value = s;
                tail = value.Substring(4);
                head = value.Remove(4, 4);
            }
            string value;
            string tail;
            string head;
            public override string ToString()
            {
                return value;
            }
            public string Head
            {
                get
                {
                    return head;
                }
            }

            public string Tail
            {
                get
                {
                    return tail;
                }
            }
        }
        static void Main(string[] args)
        {
            Gene answer = new Gene("00111111");
            string inverted = answer.Tail;
            string number = "";
            foreach (char c in inverted)
            {
                number += Invert(c);
                
            }
            number += answer.Tail;
            Console.WriteLine(number);
            Console.ReadLine();
        }
    }
}

/* string num(string number)
 * {
 * }*/
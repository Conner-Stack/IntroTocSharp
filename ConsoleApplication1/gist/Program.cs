using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gist
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> number = new List<int>();
           for(int i = 0; i <= 100; i++)
            {
                if (i == 0)
                    number.Add(0);
               if (i != 0 && i % 10 != 0 )
                number.Add(i);

            }
            foreach (var num in number)
            {
                if(num % 2 == 0)
                Console.WriteLine(num);
            }
            Console.ReadLine();
        }
    }
}

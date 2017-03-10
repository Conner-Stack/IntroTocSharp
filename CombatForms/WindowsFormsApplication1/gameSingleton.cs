using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace combatForms
{
    public class Singleton
    {
        // Arbitrary variables and methods
        public string

        public void PrintItem()
        {
            System.Console.WriteLine(item);
        }

        // Required Members of Singleton
        private static readonly Singleton instance;

        public static Singleton Instance
        {
            get { return instance; }

            // You cannot put a set in the property
            // because the instance is readonly
            // set { instance = value; }
        }

        private Singleton()
        {
            
        }

    }


    public class Container
    {

        // Arbitrary variables and methods

        public void PrintItem()
        {
        }

        // Normal class constructors
        public Container()
        {

        }

        public Container(string item)
        {
        }
    }
}

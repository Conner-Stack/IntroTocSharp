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
        public Container entity;

      

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
        public Character p1 = new Character(100, 10, "char1", true, false, 1);
        public Character p2 = new Character(100, 10, "char2", true, false, 1);
        public Character p3 = new Character(100, 10, "char3", true, false, 1);

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

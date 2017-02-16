using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
   public class singleton
    {
        //new up when we access the property Instance
        private static singleton instance = null;
        //private because someone to new up this instance
        private singleton()
        {
        }
        //this is actually how we access it
        //how u use it Singleton.instance."some other variable"
        public static singleton Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new singleton();
                }
                return instance;
            }
        }
        public string name;
    }
}

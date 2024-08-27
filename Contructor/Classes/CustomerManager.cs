using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contructor.Classes
{
    public class CustomerManager
    {
        private int _count;
        public CustomerManager(int count)
        {
            _count = count;
        }

        public void List()
        {
            Console.WriteLine("Listed {0} items", _count);
        }
        public void Add()
        {
            Console.WriteLine("Added {0} items", _count);
        }
    }
}

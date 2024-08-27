using Contructor.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contructor
{
    public class Program : CustomerManager
    {
        public Program(int count) : base(count)
        {
        }

        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(0129347 );
            customerManager.List();
            customerManager.Add();

            Console.ReadLine();


        }
    }   
    
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contructor
{
    public class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(0129347 );
            customerManager.List();

            Console.ReadLine();



        }

    }
    class CustomerManager
    {
        private int _count;
        public CustomerManager(int count)
        {
                _count = count;
        }

        public void List()
        {
            Console.WriteLine("Listed {0}", _count);
        }
        public void Add() 
        {
            Console.WriteLine("Added");
        }
    }   
    
}

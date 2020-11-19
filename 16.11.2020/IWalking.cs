using System;
using System.Collections.Generic;
using System.Text;

namespace _16._11._2020
{
    public interface IWalking
    { 
        public void Walk()
        {
            Console.WriteLine(this + " идет в новую точку");
        }
    }
}

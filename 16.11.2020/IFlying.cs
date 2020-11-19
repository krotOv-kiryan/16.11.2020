using System;
using System.Collections.Generic;
using System.Text;

namespace _16._11._2020
{
    public interface IFlying
    {
        public void Fly()
        {
            Console.WriteLine(this + " летит в новую точку");
        }
    }
}

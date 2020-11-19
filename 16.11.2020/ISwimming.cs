using System;
using System.Collections.Generic;
using System.Text;

namespace _16._11._2020
{
    public interface ISwimming
    {
        public void Swim()
        {
            Console.WriteLine(this + " плывет в новую точку");
        }
    }
}
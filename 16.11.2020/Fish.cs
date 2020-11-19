using System;
using System.Collections.Generic;
using System.Text;

namespace _16._11._2020
{
    public class Fish : Animal, ISwimming
   {
        public string Name
        { get; set; }
        public override string ToString() => Name;
        public Fish(string name, DateTime birthday)
        {
            Name = name;
            Birthday = birthday;
        }
    }
}

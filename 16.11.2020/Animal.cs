using System;
using System.Collections.Generic;
using System.Text;

namespace _16._11._2020
{
    public class Animal
    {
        public Animal()
        {

        }
        //Birthday, тип DateTime
        public DateTime Birthday
        {
            get;
            set;
        }
        public int Age
        {//Оставьте свойство доступным только для чтения, т.е. не добавляйте ему блок set.
            get { return (int)DateTime.Now.Subtract(Birthday).TotalDays / 365; }
        }
    }
}


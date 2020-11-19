using System;

namespace _16._11._2020
{
    class Program
    {
        static void Main(string[] args)
        {
            //надо много классов...хорошо
            /*Особо наблюдательные заметят, что до сих пор в нашем приложении не появилось интерфейсов,
            терпение. Создайте еще один класс. Назовите его Butterfly. Унаследуйте его от класса Animal.
            Теперь у нас есть бабочка, и, согласно иерархии наших классов, у нее и у нашего пса один и тот же родитель -
            это класс Animal. 
            //В программировании и не такое бывает, привыкайте. о_о...0_О
            */
            Dog d = new Dog("Kunak", new DateTime(2004, 04, 04));
            Console.WriteLine(d.Age);
            ((IWalking)d).Walk();

            Butterfly but = new Butterfly("Sveta", new DateTime(2005, 05, 5));
            ((IFlying)but).Fly();

            Bird bid = new Bird("Popugai", new DateTime(2006, 06, 06));
            ((IFlying)bid).Fly();

            Fish fis = new Fish("Gurami", new DateTime(2007, 07, 07));
            ((ISwimming)fis).Swim();
             Console.ReadLine();

            double n = 0;
            Console.WriteLine($"Программа сделана правильно?(1= да, 2= нет");
            double.TryParse(Console.ReadLine(), out n);
            if (n == 1)
            {
                Console.WriteLine($"Спасибо.(⊙_⊙)");
            }
            if (n == 2)
            {
                Console.WriteLine($"Ладно.(⊙_⊙)");
            }
            Console.ReadLine();
        }
    }
}

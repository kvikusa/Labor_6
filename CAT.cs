using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    public class CAT : IMeowCat
    {
        public string Name { get; private set; } //имя кота
       
        //конструктор
        public CAT(string name)
        {
            Name = name;
        }

        public override string ToString()//переопределение 
        {
            return $"кот: {Name}";
        }

        public void Meow() //мяукает 1 раз
        {
            Console.WriteLine($"{Name}: мяу!");
        }
        public void Meow(int n) //мяукает n раз
        {
            if (n < 1)
            {
                Console.WriteLine("Количество 'мяу' должно быть больше нуля.");
                return;
            }

            IEnumerable<string> meow = Enumerable.Repeat("мяу", n - 1);
            Console.Write($"{Name}: ");
            foreach (string i in meow)
                Console.Write(i + "-");
            Console.Write("мяу!\n");
        }

      
    }
}

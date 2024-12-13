using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    // Класс Funs, содержащий метод для вызова мяуканья
    public class Funs
    {
        public static void MeowsCare(IEnumerable<IMeowCat> meowables)
        {
            foreach (var meowable in meowables)
            {
                meowable.Meow(); // Каждое мяукающее животное мяукает один раз
            }
        }

        public static void MeowsCol(List<IMeowCat> meowables)
        {
            foreach (var meowable in meowables)
            {
                if (meowable is CAT cat)
                {
                    Console.WriteLine($"Количество мяуканий для кота {cat.Name}: {cat.ColMeow.ColMeow}");
                }
            }
        }
        public static void MeowsForCat(CAT cat)
        {
            Console.WriteLine($"Количество мяуканий для кота {cat.Name}: {cat.ColMeow.ColMeow}");
        }
    }
}

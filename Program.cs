using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int z = Proverka.InputIntegerWithValidation($"Введите номер задачи про котиков(1) или про дроби(2)-> ", 1, 2);
            if (z == 1)
            {
                // Создаем кота по имени "Барсик"
                CAT barsik = new CAT("Барсик");

                // Выводим текстовое представление кота
                Console.WriteLine(barsik.ToString());

                // Кот мяукает один раз
                barsik.Meow();

                int n = Proverka.InputIntegerWithValidation($"Сколько раз должен мяукнуть кот Барсик? -> ", 0, 100000000);
                barsik.Meow(n);

                int c = Proverka.InputIntegerWithValidation($"Сколько еще хотите добавить котов? -> ", 0, 100000000);
                // Создаем других котов для тестирования
                List<IMeowCat> meowables = new List<IMeowCat> { };
                for (int i = 0; i < c; i++)
                {
                    Console.Write($"Введите имя кота {i + 1}-> ");
                    string cat = Console.ReadLine();
                    CAT murzik = new CAT(cat);
                    meowables.Add(murzik);
                }

                // Вызываем мяуканье для каждого объекта
                Funs.MeowsCare(meowables);

                Funs.MeowsCol(meowables);
                Funs.MeowsForCat(barsik);

                ColMew b1 = new ColMew(barsik);
                b1.Meow();
                int n = b1.ColMeow;

                
            }
            if (z == 2)
            {
                int n1 = Proverka.InputIntegerWith($"Введите числитель 1-ой дроби -> ");
                int d1 = Proverka.InputIntegerWith($"Введите знаменатель 1-ой дроби -> ");

                int n2 = Proverka.InputIntegerWith($"Введите числитель 2-ой дроби -> ");
                int d2 = Proverka.InputIntegerWith($"Введите знаменатель 2-ой дроби -> ");

                int n3 = Proverka.InputIntegerWith($"Введите числитель 3-ей дроби -> ");
                int d3 = Proverka.InputIntegerWith($"Введите знаменатель 3-ей дроби -> ");

                var f1 = new Drobi(n1, d1);
                var f2 = new Drobi(n2, d2);
                var f3 = new Drobi(n3, d3);

                // Примеры использования методов
                var sum = f1 + f2;
                var diff = f2 - f1;
                var product = f1 * f2;
                var division = f2 / f1;

                Console.WriteLine($"{f1} + {f2} = {sum}");
                Console.WriteLine($"{f2} - {f1} = {diff}");
                Console.WriteLine($"{f1} * {f2} = {product}");
                Console.WriteLine($"{f2} / {f1} = {division}");

                var result = f1.sum(f2).div(f3).minus(5);
                Console.WriteLine($"(f1.sum(f2).div(f3).minus(5)) = {result}");

                //сравнивание дробей
                Console.WriteLine(f1.Equals(f2));
                Console.WriteLine(f1 == f2);
                Console.WriteLine(f1.Equals(f3));
                Console.WriteLine(f1 == f3);

                //клонирования
                var f4 = (Drobi)f3.Clone();
                Console.WriteLine($"Клонированная дробь: {f4}");

                //шаблоны
                Console.WriteLine($"Значение дроби {f2}: " + f2.GetValue());
                // Изменяем числитель
                f2.SetNumerator(5);
                Console.WriteLine("Новое значение дроби: " + f2.GetValue());
                // Изменяем знаменатель
                f2.SetDenominator(2);
                Console.WriteLine("После изменения знаменателя: " + f2.GetValue());
                // Попробуем установить знаменатель в 0
                f2.SetDenominator(0); // Этот вызов приведет к сообщению об ошибке
            }

        }
    }
}

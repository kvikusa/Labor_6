using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{ 
    public class Drobi : IDrob, ICloneable
    {
        private int numerator; //числитель
        private int denominator; //знаменатель
        //                         
        //свойства
        public int Numerator
        {
            get => numerator;
            public set => numerator = value;
        }

        public int Denominator
        {
            get => denominator;
            private set
            {
                if (value == 0) throw new ArgumentException("Знаменатель не может быть равен нулю."); ;
                denominator = Math.Abs(denominator);
                if (value < 0) numerator = -numerator; //меняем знак числителя, чтобы - был вверху
            }
        }

        // Конструктор для создания дроби с числителем и знаменателем
        public Drobi(int numerator, int denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;
        }

        //строковое представление дроби
        public override string ToString()
        {
            return $"{numerator}/{denominator}";
        }

        //перегрузка сложения
        public static Drobi operator +(Drobi f1, Drobi f2)
        {
            return new Drobi(f1.numerator * f2.denominator + f2.numerator * f1.denominator, f1.denominator * f2.denominator);
        }
        public static Drobi operator +(Drobi f, int i)
        {
            return f + new Drobi(i, 1);
        }

        //перегрузка вычитания
        public static Drobi operator -(Drobi f1, Drobi f2)
        {
            return new Drobi(f1.numerator * f2.denominator - f2.numerator * f1.denominator, f1.denominator * f2.denominator);
        }
        public static Drobi operator -(Drobi f, int i)
        {
            return f - new Drobi(i, 1);
        }
        //перегрузка умножения
        public static Drobi operator *(Drobi f1, Drobi f2)
        {
            return new Drobi(f1.numerator * f2.numerator, f1.denominator * f2.denominator);
        }
        public static Drobi operator *(Drobi f, int i)
        {
            return new Drobi(f.numerator * i, f.denominator);
        }

        //перегрузка деления
        public static Drobi operator /(Drobi f1, Drobi f2)
        {
            return new Drobi(f1.numerator * f2.denominator, f2.numerator * f1.denominator);
        } 
        public static Drobi operator /(Drobi f, int i)
        {
            return new Drobi(f.numerator, f.denominator * i);
        }


        public Drobi sum(Drobi other)
        {
            return this + other;
        }

        public Drobi minus(int value)
        {
            return this - value;
        }

        public Drobi div(Drobi other)
        {
            return this / other;
        }

        public Drobi proiz(Drobi other)
        {
            return this * other;
        }



        //сравнеение дробей
        public override bool Equals(object obj)
        {
            // Проверка на null и тип объекта
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            // Приведение к типу drobi
            Drobi other = (Drobi)obj;

            // Сравнение числителей и знаменателей
            return numerator == other.numerator && denominator == other.denominator;
        }

        // Перегрузка операторов равенства (опционально, но рекомендуется)
        public static bool operator ==(Drobi a, Drobi b)
        {
            // Проверка на null
            if (ReferenceEquals(a, null))
            {
                return ReferenceEquals(b, null);
            }

            return a.Equals(b);
        }

        public static bool operator !=(Drobi a, Drobi b)
        {
            return !(a == b);
        }

        //клонирование
        public object Clone()
        {
            return new Drobi(numerator, denominator);
        }

        //шаблоны
       public void SetNumerator(int numerator)
        {
            this.numerator = numerator;
        }

        public void SetDenominator(int denominator)
        {
            if (denominator == 0)
                throw new ArgumentException("Знаменатель не может быть равен нулю.");
            this.denominator = denominator;
        }

        public double GetValue()
        {
            return (double)this.Numerator / this.Denominator;
        }

    }
}

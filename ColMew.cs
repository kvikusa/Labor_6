using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    public class ColMew  : IMeowCat
    {
        public int ColMeow { get; private set; } //кол-во "МЯУ"
        IMeowCat cat;
        public ColMew(IMeowCat cat)
        {
            ColMeow = 0;
            this.cat = cat;
        }
        public void Meow()
        { 
            cat.Meow();
            ColMeow ++; }

        public void Meow(int value)
        {
            cat.Meow(value);
            if (value < 1)
            {
                throw new ArgumentException("Значение должно быть больше нуля.");
            }
            ColMeow += value;
        }
    }
}

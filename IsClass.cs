using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16___2
{
    internal class IsClass
    {
        private static int _num;
        private int _number;

        static public void Numplus()
        {
            _num++;
            Console.WriteLine("Numplus 작동됌");

        }

         public void Numberplus()
        {
            _number++;
            _num++;
            Console.WriteLine("Numberplus 작동됌");
            Console.WriteLine("스태틱은 : " + _num);
        }

        static public void Numdouble()
        {
            
            _num *= 3;
            //_number;
            Console.WriteLine("Numdouble 작동됌");
            Console.WriteLine("스태틱은 : " + _num);
        }




    }
}

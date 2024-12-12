using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16___2
{
   class NomalClass
   {
        private static int _num;
        //public static int _num;
        public int NomalClassnumnum;


        static public int num
        {
            get { return _num; }
            set { _num = value; }
        }


        public NomalClass()
        {
            _num++;
        }
        public void PrintConsole()
        {
            Console.WriteLine("static num : " + _num);

        }
    }
}

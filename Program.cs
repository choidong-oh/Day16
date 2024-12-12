using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Day16___2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////과제1번
            //NomalClass nomal = new NomalClass();
            //nomal.PrintConsole();
            //NomalClass noma2 = new NomalClass();
            //nomal.PrintConsole();
            //NomalClass noma3 = new NomalClass();
            //nomal.PrintConsole();

            //과제2번

            //NomalClass nomal = new NomalClass();
            ////nomal._num = 10;
            //NomalClass._num = 10;
            //Console.WriteLine(NomalClass._num);

            //과제3번
            //NomalClass nomal = new NomalClass();
            //nomal.NomalClassnumnum = 10;
            ////nomal.num = 10;
            //NomalClass.num = nomal.NomalClassnumnum;

            ////과제4번
            //IsClass isClass = new IsClass();
            //IsClass.Numplus();
            //isClass.Numberplus();

            ////과제5번
            //IsClass isclass = new IsClass();
            ////isclass.Numberplus();
            //isclass.Numberplus();
            //IsClass.Numdouble();


            ////심화과제1번

            //int[] arr = new int[4];
            //arr[0] = 1; 
            //arr[1] = 2;
            //arr[2] = 3;
            //arr[3] = 4;
            //int small = 5;

            //myHelper myHelper = new myHelper();
            ////myHelper.findsmall(arr);

            //Console.WriteLine(myHelper.findsmall(arr));

            ////심화과제2번
            //string name = "AAAddd";
            //myHelper myhelperclass = new myHelper();
            //Console.WriteLine(myHelper.CountUppercaseLetters(name));

            ////심화과제3번

           
            Achievement achievement1 = new Achievement("초급 도전자", "점수 100점 달성", 100); ;
            Achievement achievement2 = new Achievement("중급 도전자", "점수 500점 달성", 500); ;
            Achievement achievement3 = new Achievement("고급 도전자", "점수 1000점 달성", 1000); ;
            
            achievement1.AddProgress(100);
            achievement2.AddProgress(600);
            achievement3.AddProgress(800);

            achievement1.DisplayInfo();
            Achievement.DisplaySummary();
            Console.WriteLine();

            achievement2.DisplayInfo();
            Achievement.DisplaySummary();
            Console.WriteLine();

            achievement3.DisplayInfo();
            Achievement.DisplaySummary();
            Console.WriteLine();

        }

    }
}

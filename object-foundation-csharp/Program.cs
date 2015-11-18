using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hsdc.ofc.sample1;     // import the necessary packages.
using hsdc.ofc.sample2;

namespace hsdc.ofc
{
    public class Program
    {
        static void Main(string[] args)
        {
            // doSample1();
            doSample2();
        }

        static void doSample1()
        {
            Driver aDriver = new Driver("志玲");      // new a Driver instance who is named "志玲"
            hsdc.ofc.sample1.Car aCar = aDriver.aCar;                  // 透過 Driver 取得 Car instance

            Console.WriteLine("駕駛員： " + aDriver.name);
            Console.WriteLine("------------------------------------------");
            Console.WriteLine(aCar.發動());
            Console.WriteLine(aCar.踩油門());
            Console.WriteLine(aCar.轉動方向盤());
            Console.WriteLine(aCar.排檔("D"));
            Console.WriteLine(aCar.煞車());
            Console.WriteLine(aCar.關閉());
            Console.WriteLine("------------------------------------------");

            Console.WriteLine("\n\n" + "Press any Key to continue...");
            Console.ReadLine();     //Pause
        }

        static void doSample2()
        {
            hsdc.ofc.sample2.Car aCar = new sample2.Car();

            Console.WriteLine("------------------------------------------");
            Console.WriteLine(aCar.踩油門());
            Console.WriteLine(aCar.get引擎狀況());
            Console.WriteLine("------------------------------------------");

            Console.WriteLine("\n\n" + "Press any Key to continue...");
            Console.ReadLine();     //Pause
        }
    }
}

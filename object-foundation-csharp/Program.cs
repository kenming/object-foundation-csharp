using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hsdc.ofc.sample1;     // import the necessary packages.
using hsdc.ofc.sample2;
using hsdc.ofc.sample3;

namespace hsdc.ofc
{
    public class Program
    {
        static void Main(string[] args)
        {
            // doSample1();
            // doSample2();
            doSample3();
        }

        // Demo: Association (關聯)
        static void doSample1()
        {
            Driver aDriver = new Driver("志玲");        // new a Driver instance who is named "志玲"
            hsdc.ofc.sample1.Car aCar = aDriver.aCar;   // 透過 Driver 取得 Car instance

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

        // Demo: Whole-parts (整體-局部)
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

        // Demo: Generalization-Specialization (一般化-特殊化)
        static void doSample3()
        {
            汽車工廠 factory = new 汽車工廠();

            // 製造車子
            factory.製造(1, "BWM-1688");        // 製造轎車
            factory.製造(2, "TRUNK-8888");      // 製造卡車
            factory.製造(3, "TANK-01925");      // 製造坦克車
            factory.製造(2, "CAPCOM-17799");     // 製造卡車
            factory.製造(1, "Toyota-5201314");  // 製造轎車

            foreach (sample3.Car aCar in factory.getAll已製造車子())
            {
                Console.WriteLine("-------------已製造車子資訊---------------");
                Console.WriteLine(aCar.查詢車子資訊());
                Console.WriteLine("馬力： " + Convert.ToString(aCar.calc馬力()));                
                Console.WriteLine("車況： " + aCar.query車況());
                Console.WriteLine("------------------------------------------"+"\n\n");
            }

            Console.WriteLine("\n\n" + "Press any Key to continue...");
            Console.ReadLine();     //Pause
        }
    }
}

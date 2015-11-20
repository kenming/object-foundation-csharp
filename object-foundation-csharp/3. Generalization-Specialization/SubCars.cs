using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hsdc.ofc.sample3
{
    public class 轎車 : Car
    {

        // Constructor
        public 轎車(string cartype, string carno) : base(cartype, carno)
        {}

        // 實作父類別 (super-class)所定義的方法 (注意關鍵字 override)
        // 簡化公式：公制馬力PS =扭力(kg-m)×引擎轉速(rpm)/500
        public override decimal calc馬力()
        {
            // 假設轎車的扭力與轉速的預設值
            int kgm = 3;
            int rpm = 6000;
            decimal ps = kgm * rpm / 60;

            return ps;
        }

        public override string query車況()
        {
            string 車況 = "油表檢查結果：" + "OK\n";     // 需實做至各車種中控器查詢各類設備的檢查結果
            車況 = 車況 + "引擎檢查結果：" + "OK\n";
            車況 = 車況 + "輪胎檢查結果：" + "OK\n";
            車況 = 車況 + "氣囊檢查結果：" + "OK\n";

            return 車況;
        }
    }

    public class 卡車 : Car
    {

        // Constructor
        public 卡車(string cartype, string carno) : base(cartype, carno)
        { }

        // 實作父類別 (super-class)所定義的方法 (注意關鍵字 override)
        // 簡化公式：公制馬力PS =扭力(kg-m)×引擎轉速(rpm)/500
        public override decimal calc馬力()
        {
            // 假設卡車的扭力與轉速的預設值
            int kgm = 5;
            int rpm = 6800;
            decimal ps = kgm * rpm / 60;

            return ps;
        }

        public override string query車況()
        {
            string 車況 = "油表檢查結果：" + "OK\n";     // 需實做至各車種中控器查詢各類設備的檢查結果
            車況 = 車況 + "引擎檢查結果：" + "OK\n";
            車況 = 車況 + "輪胎檢查結果：" + "OK\n";
            車況 = 車況 + "棚架檢查結果：" + "OK\n";

            return 車況;
        }

        // 特殊化類別所定義的方法

        // 1. 只是說明特殊化類別可以有自己定義的方法。
        // 2. 若宣告為 Car 一般化類別時，無法被 Client 看到與呼叫使用此方法。
        // 3. Client 需直接宣告為 卡車 類別，始可使用該方法。
        public void 裝載物資()
        {
            // Not yet implemented.
        }
    }

    public class 坦克車 : Car
    {

        // Constructor
        public 坦克車(string cartype, string carno) : base(cartype, carno)
        { }

        // 實作父類別 (super-class)所定義的方法 (注意關鍵字 override)
        // 簡化公式：公制馬力PS =扭力(kg-m)×引擎轉速(rpm)/500
        public override decimal calc馬力()
        {
            // 假設卡車的扭力與轉速的預設值
            int kgm = 24;
            int rpm = 7200;
            decimal ps = kgm * rpm / 60;

            return ps;
        }

        public override string query車況()
        {
            string 車況 = "油表檢查結果：" + "OK\n";     // 需實做至各車種中控器查詢各類設備的檢查結果
            車況 = 車況 + "引擎檢查結果：" + "OK\n";
            車況 = 車況 + "履帶檢查結果：" + "OK\n";
            車況 = 車況 + "武器發射檢查結果：" + "OK\n";

            return 車況;
        }

        // 特殊化類別所定義的方法

        // 1. 只是說明特殊化類別可以有自己定義的方法。
        // 2. 若宣告為 Car 一般化類別時，無法被 Client 看到與呼叫使用此方法。
        // 3. Client 需直接宣告為 卡車 類別，始可使用該方法。
        public void 發射大砲()
        {
            // Not yet implemented.
        }
    }
    }

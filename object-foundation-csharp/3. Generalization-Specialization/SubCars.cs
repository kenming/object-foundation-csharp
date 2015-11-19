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
        public 轎車(string cartype) : base(cartype)
        {}

        // 實作父類別 (super-class)所定義的方法 (注意關鍵字 override)
        // 簡化公式：公制馬力PS =扭力(kg-m)×引擎轉速(rpm)/500
        public override decimal calc馬力()
        {
            // 假設轎車的扭力與轉速的預設值
            int kgm = 3;
            int rpm = 6000;
            int ps = kgm * rpm / 600;

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
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hsdc.ofc.sample3
{
    public abstract class Car
    {
        /// attributes
        public string 車型 { get; }

        // Constructor
        public Car(string cartype)
        {
            // new instance 給予的初始值
            車型 = cartype;
        }

        // 預設行為的實作
        public string 查詢車子資訊()
        {
            return "本款車子的類型為： " + 車型 ;
        }

        // 抽象類別的行為定義
        // 由所擴展 (extend)的子類別 (sub-class)來實作下列兩個方法的定義
        abstract public decimal calc馬力();

        abstract public string query車況();
    }
}

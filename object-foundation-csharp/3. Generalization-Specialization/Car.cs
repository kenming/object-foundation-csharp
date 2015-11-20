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
        public string 車號 { get; set; }

        // Constructor
        public Car(string cartype, string carno)
        {
            // new instance 給予的初始值
            車型 = cartype;
            車號 = carno;
        }

        // 預設行為的實作
        public string 查詢車子資訊()
        {
            return "車型： " + 車型 + " ; " + "車號： " + 車號 ;
        }

        // 抽象類別的行為定義
        // 由所擴展 (extend)的子類別 (sub-class)來實作下列兩個方法的定義
        abstract public decimal calc馬力();

        abstract public string query車況();
    }
}

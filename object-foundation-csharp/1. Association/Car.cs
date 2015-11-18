using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hsdc.ofc.sample1
{
    public class Car
    {
        /// attributes
        public string 型號 { get;}  // 單純的 get/set property
        public string 車號 { get; set; }
        private int 里程數;
        private int 油表數;

        // Constructor
        public Car(string cartype, string carno)
        {
            // new instance 給予的初始值
            型號 = cartype;
            車號 = carno;
        }


        /// operations
        public int get里程數()
        {
            //需至里程記錄器取得資料
            里程數 = 58000; //先給個測試數值
            return 里程數;
        }

        public int get油表數()
        {
            //需至油表監控器取得現存油表數
            油表數 = 12; //剩餘 12 公升
            return 油表數;
        }

        public string get車況資訊()
        {
            String 車況 = "型號：" + 型號
              + "；車號：" + 車號;
            return 車況;
        }

        public string 踩油門()
        {
            return "動作： 踩油門";
        }

        public string 排檔(string 排檔別)
        {
            return "動作： 排檔-> " + 排檔別;
        }

        public string 發動()
        {
            return "動作： 發動";
        }

        public string 煞車()
        {
            return "動作： 煞車";
        }

        public string 關閉()
        {
            return "動作： 關閉";
        }

        public string 轉動方向盤()
        {
            return "動作： 轉動方向盤";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hsdc.ofc.sample2
{
    public class Car
    {
        public 引擎 m_引擎;
        public 輪胎[] m_輪胎;

        // Constructor
        public Car()
        {
            m_引擎 = new 引擎();        // one instance
            m_輪胎 = new 輪胎[4];       // four instances
        }

        public string 踩油門()
        {
            string 滾動 = "";

            // 需要實作四個輪胎的同時滾動
            for (int i = 0; i < m_輪胎.Length; i++)
            {
                m_輪胎[i] = new 輪胎();
                滾動 = 滾動 + "輪胎：" + i + " " + m_輪胎[i].滾動() + "； ";
            }
            return 滾動;
        }

        public string get引擎狀況()
        {
            // Delegate: 透過引擎物件取得引擎的狀況
            return m_引擎.get引擎狀況();
        }
    }
}

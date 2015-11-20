using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hsdc.ofc.sample3
{
    public class 汽車工廠
    {
        private List<Car> carList;          // Hold 住所有製造的車子

        // constructor
        public 汽車工廠()
        {
            carList = new List<Car>();
        }

        // 依據傳入的車型編號，來決定所製造的車型
        public Car 製造(int cartype, string carno)
        {
            Car aCar;

            switch (cartype)
            {
                case 1:
                    aCar = new 轎車("轎車-輕型", carno);
                    carList.Add(aCar);
                    return aCar;
                case 2:
                    aCar = new 卡車("卡車-中型", carno);
                    carList.Add(aCar);
                    return aCar;
                case 3:
                    aCar = new 坦克車("坦克車-重型", carno);
                    carList.Add(aCar);
                    return aCar;
                default:
                    return null;
            }
        }

        public List<Car> getAll已製造車子()
        {
            return this.carList;
        }
    }
}

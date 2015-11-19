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

        public Car 製造(int cartype)
        {
            Car aCar;

            switch (cartype)
            {
                case 1:
                    aCar = new 轎車("轎車-中型");
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

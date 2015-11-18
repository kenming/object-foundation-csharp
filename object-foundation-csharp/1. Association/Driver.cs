using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hsdc.ofc.sample1
{
    public class Driver
    {
        public string name { get; }
        public Car aCar { get; }       // 參考變數 -> Car instance

        // Constructor
        public Driver(string _name)
        {
            // Set the default value of the Driver instance.
            name = _name;
            aCar = new Car("BMW","IS-1234");
        }
    }
}

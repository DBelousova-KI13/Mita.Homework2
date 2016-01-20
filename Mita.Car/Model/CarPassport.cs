using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class CarPassport
    {
        public CarPassport(Car car)
        {
            Car = car;
        }

        public Driver Owner { get; set; }

        public Car Car { get; }
    }
}

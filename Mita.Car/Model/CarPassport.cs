using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class CarPassport
    {
        private readonly Car _car;

        public CarPassport(Car car)
        {
            _car = car;
        }

        public Driver Owner { get; set; }


    }
}

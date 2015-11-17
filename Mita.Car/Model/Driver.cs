using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Driver
    {
        private readonly DateTime _licenceDate;
        private string  _name;
        private string _category = "";
        private Car _car;

        public Driver(DateTime licenceDate, string name)
        {
            _licenceDate = licenceDate;
            _name = name;
        }

        public void OwnCar(Car car)
        {
            Car temp = null;
            try
            {
                if (_category.Contains(car.Categorie))
                {
                    temp = car;
                    Console.WriteLine("Машина закреплена за водителем.");
                }
                else
                {
                    throw new System.ArgumentException("У предлагаемого владельца нет прав для управления данной машиной");                    
                }
            }
            catch (System.ArgumentException)
            {

                Console.WriteLine("У предлагаемого владельца нет прав для управления данной машиной");
            }
            _car = temp;
        }

        public DateTime LicenceDate => _licenceDate;

        public string Name => _name;

        public Car PropsCar => _car;

        public int Experience
        {
            get
            {
               int temp = DateTime.Now.Year - _licenceDate.Year;
                if ((DateTime.Now.Month < _licenceDate.Month) || (DateTime.Now.Month == _licenceDate.Month && DateTime.Now.Day <_licenceDate.Day))
                {
                    temp--;
                }
               return temp;
            }
        }

        public string Category
        {
            get { return _category; }
            set { _category = value; }
        }

        public void AddCategory(char cat)
        {
            
            if ((cat < 'A') || (cat > 'F'))
            {
                Console.WriteLine("Введено неверное значение категории");
            }
             else
            {
                    if (!(_category.Contains(cat)))
                    {
                         _category += cat;
                        Console.WriteLine("Водителю успешно присвоена категория {0}", cat);
                }
               
            }
        }





    }
}

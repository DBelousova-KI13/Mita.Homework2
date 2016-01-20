using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Driver
    {
        private string _category = "";

        public Driver(DateTime licenceDate, string name)
        {
            LicenceDate = licenceDate;
            Name = name;
        }

        public void OwnCar(Car car)
        {
            Car temp = null;
            if (_category.Contains(car.Categorie))
            {
                temp = car;
                Console.WriteLine("Машина закреплена за водителем.");
            }
            else
            {
                throw new System.ArgumentException("У предлагаемого владельца нет прав для управления данной машиной");
            }

            PropsCar = temp;
        }

        public DateTime LicenceDate { get; }

        public string Name { get; }

        public Car PropsCar { get; private set; }

        public int Experience
        {
            get
            {
               int temp = DateTime.Now.Year - LicenceDate.Year;
                if ((DateTime.Now.Month < LicenceDate.Month) || (DateTime.Now.Month == LicenceDate.Month && DateTime.Now.Day <LicenceDate.Day))
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

        public string AddCategory(char cat)
        {
            
            if ((cat < 'A') || (cat > 'F'))
            {
                return ("категория не была присвоена,так как было задано неверное значение");
            }
            else
            {
                string temp = "";
                    if (!(_category.Contains(cat)))
                    {
                         _category += cat;
                        temp = "Водителю успешно присвоена категория " + cat;
                        
                    }
                return temp;
            }
        }





    }
}

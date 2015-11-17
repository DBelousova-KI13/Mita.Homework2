using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Car
    {
        private readonly string _model;
        private readonly char _category;
        private readonly CarPassport _carPassport;
       

        public Car(string model, char category)
        {
            _model = model;
            _category = category;
            _carPassport = new CarPassport(this);
        }

        public ConsoleColor Color { get; set; }

        public char Categorie => _category;

        public string CarNumber { get; private set; }

        public CarPassport CarPass
        {
            get { return _carPassport; }     
        }

        public void ChangeOwner(string number, Driver driver)
        {
            Console.WriteLine("Закрепить за водителем имеющуюся машину:");
            driver.OwnCar(this);
            this._carPassport.Owner = driver;
            CarNumber = number;
        }


    }
}

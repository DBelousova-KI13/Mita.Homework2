using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Car
    {
        public Car(string model, char category)
        {
            Model = model;
            Categorie = category;
            CarPass = new CarPassport(this);
        }

        public ConsoleColor Color { get; set; }

        public string Model { get; }

        public char Categorie { get; }

        public string CarNumber { get; private set; }

        public CarPassport CarPass { get; }

        public void ChangeOwner(string number, Driver driver)
        {
            Console.WriteLine("Закрепить за водителем имеющуюся машину:");

            driver.OwnCar(this);

            this.CarPass.Owner = driver;
            CarNumber = number;
        }


    }
}

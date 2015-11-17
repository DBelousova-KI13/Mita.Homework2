using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace View
{
    class Program
    {
        static void Main(string[] args)
        {

            var car = new Car("Лада", 'D') {Color = ConsoleColor.DarkMagenta};
            Console.WriteLine("Автосалон приобрел новую машину");
            Console.WriteLine("Владелец машины:");
            try
            {
                Console.WriteLine(car.CarPass.Owner.Name);
            }
            catch(System.NullReferenceException)
            {
                Console.WriteLine("У данной машины пока нет владельца");
            }
            DateTime date1 = new DateTime(1990, 12, 1, 0, 0, 0);
            var drivingInstructor = new Driver(date1, "Вольдемар");
            Console.WriteLine("Нанят водитель (инструктор) {0}", drivingInstructor.Name);
            drivingInstructor.AddCategory('B');
            drivingInstructor.AddCategory('C');
            car.ChangeOwner("о777оо", drivingInstructor);
            drivingInstructor.AddCategory('D');
            car.ChangeOwner("о777оо", drivingInstructor);
            Console.WriteLine("Номер машины водителя с именем {0} - {1}", drivingInstructor.Name, drivingInstructor.PropsCar.CarNumber);
            Console.WriteLine("Владелец машины Лада - {0}", car.CarPass.Owner.Name);
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;

namespace Avtoservis
{
    class Program
    {
        static void Main(string[] args)
        {
            Detail cardanShaft = new Detail(3200, "Карданный вал");
            Detail crankshaftSeals = new Detail(200, "Сальники коленвала");
            Detail gasolinePump = new Detail(5400, "Бензонасос");
            Detail stoppingSupport = new Detail(2900, "Тормозной суппорт");
            Detail ignitionSwitch  = new Detail(300, "Выключатель зажигания");

            Dictionary<Detail, int> details = new Dictionary<Detail, int>();

            details.Add(cardanShaft, 3);
            details.Add(crankshaftSeals, 50);
            details.Add(gasolinePump, 1);
            details.Add(stoppingSupport, 8);

            CarService carService = new CarService(new Balance(1000), new Warehouse(details));

            Car car1 = new Car(new Breaking(cardanShaft, 2000, -1500, "Повреждение крданного вала."));
            Car car2 = new Car(new Breaking(ignitionSwitch, 500, -500, "Не заводится."));

            carService.TakeCar(car1);
            Console.WriteLine();
            carService.TakeCar(car2);
        }
    }
}

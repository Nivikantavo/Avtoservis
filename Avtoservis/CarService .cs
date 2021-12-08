using System;
using System.Collections.Generic;
using System.Text;

namespace Avtoservis
{
    class CarService
    {
        private Balance _balance;
        private Warehouse _warehouse;

        public CarService(Balance balance, Warehouse warehouse)
        {
            _balance = balance;
            _warehouse = warehouse;
        }

        public void TakeCar(Car car)
        {
            Console.WriteLine($"Поступила машина. Поломка: {car.Breaking.Name}, необходимая деталь: {car.Breaking.NecessaryDetail.Name}");

            if (_warehouse.CheckAvailabilityDetail(car.Breaking.NecessaryDetail))
            {
                RenovateCar(car);
            }
            else
            {
                RefuseToRepair(car);
            }
        }

        private void RenovateCar(Car car)
        {
            Console.WriteLine("Машина принята в ремонт.");

            _warehouse.TakeDetail(car.Breaking.NecessaryDetail);

            int paid = car.Breaking.NecessaryDetail.Price + car.Breaking.PriceForWork;

            Console.WriteLine("Ремонт выполнен.");
            _balance.CalculateTheClient(paid);
        }

        private void RefuseToRepair(Car car)
        {
            Console.WriteLine("В ремонте отказано.");
            _balance.CalculateTheClient(car.Breaking.RefusalPenalty);
        }
    }
}

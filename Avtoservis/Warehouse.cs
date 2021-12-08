using System;
using System.Collections.Generic;
using System.Text;

namespace Avtoservis
{
    class Warehouse
    {
        private Dictionary<Detail, int> _details;

        public Warehouse(Dictionary<Detail, int> details)
        {
            _details = details;
        }

        public bool CheckAvailabilityDetail(Detail detail)
        {
            if (_details.ContainsKey(detail) && _details[detail] > 0)
            {
                Console.WriteLine($"Деталь '{detail.Name}' есть в наличии.");
                return true;
            }
            else
            {
                Console.WriteLine($"Детали '{detail.Name}' нет в наличии.");
                return false;
            }
        }

        public void TakeDetail(Detail detail)
        {
            _details[detail] -= 1;
        }
    }
}

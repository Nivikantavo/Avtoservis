using System;
using System.Collections.Generic;
using System.Text;

namespace Avtoservis
{
    class Balance
    {
        public int MoneyCount {get; private set;}

        public void CalculateTheClient(int paid)
        {
            MoneyCount += paid;

            if(paid > 0)
            {
                Console.WriteLine($"Получена плата в размере: {paid}. Баланс: {MoneyCount}");
            }
            else
            {
                Console.WriteLine($"Уплачен штраф в размере: {paid}. Баланс: {MoneyCount}");
            }
        }

        public Balance(int money)
        {
            MoneyCount = money;
        }
    }
}

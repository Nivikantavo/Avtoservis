using System;
using System.Collections.Generic;
using System.Text;

namespace Avtoservis
{
    class Detail
    {
        public int Price { get; private set;}
        public string Name { get; private set;}

        public Detail(int price, string name)
        {
            Price = price;
            Name = name;
        }
    }
}

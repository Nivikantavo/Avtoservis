using System;
using System.Collections.Generic;
using System.Text;

namespace Avtoservis
{
    class Car
    {
        public Breaking Breaking { get; private set; }

        public Car(Breaking breaking)
        {
            Breaking = breaking;
        }
    }
}

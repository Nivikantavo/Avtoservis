using System;
using System.Collections.Generic;
using System.Text;

namespace Avtoservis
{
    class Breaking
    {
        private int _refusalPenalty;
        public Detail NecessaryDetail { get; private set; }
        public int PriceForWork { get; private set; }
        public string Name { get; private set; }
        public int RefusalPenalty
        {
            get 
            {  
                return _refusalPenalty; 
            }
            private set
            {
                if (value <= 0)
                    _refusalPenalty = value;
                else
                    _refusalPenalty = -value;
            }
        }

        public Breaking(Detail detail, int price, int fine, string name)
        {
            NecessaryDetail = detail;
            PriceForWork = price;
            RefusalPenalty = fine;
            Name = name;
        }
    }
}

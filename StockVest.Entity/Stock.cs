using System;
using System.Collections.Generic;
using System.Text;

namespace StockVest.Entity
{
    public class Stock : Security
    {
        public decimal DayHigh { get; set; }
        public decimal DayLow { get; set; }
        public decimal Dividend { get; set; }
        public decimal Open { get; set; }
        public decimal Volume  { get; set; }
    }
}

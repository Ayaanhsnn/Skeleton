using System;

namespace ClassLibrary
{
    public class clsStock
    {
        public int StockNo { get; set; }
        public int OrderNo { get; set; }
        public string StockDesc { get; set; }
        public bool Availability { get; set; }
        public int Quantity { get; set; }
        public DateTime DatePurch { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace BittrexSharp.Domain
{
    public class MarketHistoricalPrice
    {
        public string MarketName { get; set; }
        public List<Price> Prices { get; set; }

    }

    public class Price
    {
        public string PriceName { get; set; }
        public decimal PriceValue { get; set; }
    }
}
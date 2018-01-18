using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BittrexWinForm
{
    public class Alert
    {
        public string MarketName { get; set; }
        public string MaxValue { get; set; }
        public string MinValue { get; set; }
        public string CurrentValue { get; set; }
        public string TradingSite { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BittrexWinForm
{
    public class Bid
    {
        public string MarketName { get; set; }
        public string BidPrice { get; set; }
        public string BidAmount { get; set; }
        public string BidType { get; set; }
        public DateTime OrderTime { get; set; }
        public long OrderId { get; set; }
    }
}

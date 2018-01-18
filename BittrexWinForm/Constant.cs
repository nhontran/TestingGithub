using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BittrexWinForm
{
    public class Constant
    {
        public static class ExchangeSite
        {
            public const string Binance = "Binance";
            public const string Bittrex = "Bittrex";
            public const string CryptoCompare = "CryptoCompare";
        }

        public static class PopularCrypto
        {
            public const string BTC = "BTC";
            public const string ETH = "ETH";
            public const string USDT = "USDT";
        }

        public static class Currency
        {
            public const string USD = "USD";
            public const string SGD = "SGD";
        }

        public static class Configuration
        {
            public const string AlertInterval = "Alert Interval";
            public const string TradeInterval = "Trade Interval";
        }
    }
}


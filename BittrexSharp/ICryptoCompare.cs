using BittrexSharp.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BittrexSharp
{
    public interface ICryptoCompare
    {
        Task<ResponseWrapper<MarketHistoricalPrice>> PriceHistorical(string fromSymbol, string toCurrencies, string timeStamp);
        Task<ResponseWrapper<MarketHistoricalPrice>> Price(string fromSymbol, string toCurrencies);
    }
}

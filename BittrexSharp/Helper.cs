using BittrexSharp.Exceptions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BittrexSharp
{
    public class Helper
    {
        private static HttpClient httpClient = new HttpClient();
        public static string GetSourceCurrencyFromMarketName(string marketName) => marketName.Split('-').First();
        public static string GetTargetCurrencyFromMarketName(string marketName) => marketName.Split('-').Last();

        public static string ConvertParameterListToString(IDictionary<string, string> parameters)
        {
            if (parameters.Count == 0) return "";
            return parameters.Select(param => WebUtility.UrlEncode(param.Key) + "=" + WebUtility.UrlEncode(param.Value)).Aggregate((l, r) => l + "&" + r);
        }
    }
}

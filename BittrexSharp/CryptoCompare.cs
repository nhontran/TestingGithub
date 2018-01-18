using BittrexSharp.Domain;
using BittrexSharp.Exceptions;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BittrexSharp
{
    public class CryptoCompare
    {
        public const string BaseUrl = "https://min-api.cryptocompare.com/";
        private readonly Encoding encoding = Encoding.UTF8;
        private HttpClient httpClient;

        public CryptoCompare()
        {
            this.httpClient = new HttpClient();
        }

        protected HttpRequestMessage createRequest(HttpMethod httpMethod, string uri, IDictionary<string, string> parameters)
        {
            var parameterString = Helper.ConvertParameterListToString(parameters);
            var completeUri = uri + "?" + parameterString;
            var request = new HttpRequestMessage(httpMethod, completeUri);
            return request;
        }

        protected async Task<ResponseWrapper<TResult>> request<TResult>(HttpMethod httpMethod, string uri)
            => await request<TResult>(httpMethod, uri, new Dictionary<string, string>());

        protected async Task<ResponseWrapper<TResult>> request<TResult>(HttpMethod httpMethod, string uri, IDictionary<string, string> parameters)
        {
            var request = createRequest(HttpMethod.Get, uri, parameters);
            HttpResponseMessage response = await httpClient.SendAsync(request);
            if (!response.IsSuccessStatusCode)
                return new ResponseWrapper<TResult>
                {
                    Success = false,
                    Message = "HTTP Error: " + response.StatusCode + " " + response.ReasonPhrase
                };
            var content = await response.Content.ReadAsStringAsync();
            var cryptoCompareResponse = JsonConvert.DeserializeObject<JToken>(content);
            if(!cryptoCompareResponse.ToString().Contains("Error"))
            {
                return new ResponseWrapper<TResult>
                {
                    Success = true,
                    Message = string.Empty,
                    Result = cryptoCompareResponse.ToObject<TResult>()
                };
            }
            return new ResponseWrapper<TResult>
            {
                Success = false,
                Message = "HTTP Error: " + cryptoCompareResponse.ToString()
            };

        }

        /// <summary>
        /// Get price of cryptocurrency in multi currencies
        /// </summary>
        /// <param name="marketName">crypto name</param>
        /// <param name="toCurrencies">to currency 'USD,SGD,...'</param>
        /// <param name="timeStamp">time stamp</param>
        /// <returns></returns>
        public virtual async Task<ResponseWrapper<Dictionary<string, Dictionary<string, decimal>>>> PriceHistorical(string marketName, string toCurrencies, string timeStamp)
        {
            var uri = BaseUrl + "data/pricehistorical";
            var parameters = new Dictionary<string, string>
            {
                { "fsym", marketName },
                { "tsyms", toCurrencies },
                { "ts", timeStamp },
            };
            var marketsResponse = await request<Dictionary<string, Dictionary<string, decimal>>>(HttpMethod.Get, uri, parameters);
            return marketsResponse;
        }

        /// <summary>
        /// Get price of currency at moment
        /// </summary>
        /// <param name="marketName">crypto name</param>
        /// <param name="toCurrencies">to currency 'USD,SGD,...'</param>
        /// <returns></returns>
        public virtual async Task<ResponseWrapper<Dictionary<string, decimal>>> Price(string marketName, string toCurrencies)
        {
            var uri = BaseUrl + "data/price";
            var parameters = new Dictionary<string, string>
            {
                { "fsym", marketName },
                { "tsyms", toCurrencies }
            };
            var marketsResponse = await request<Dictionary<string, decimal>>(HttpMethod.Get, uri, parameters);
            return marketsResponse;
        }
    }
}

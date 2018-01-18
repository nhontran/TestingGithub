using Binance.Net;
using Binance.Net.Objects;
using BittrexSharp;
using BittrexSharp.Domain;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BittrexWinForm
{
    public partial class Form1 : Form
    {
        private Bittrex bittrex { get; set; }
        private CryptoCompare cryptoCompare { get; set; }
        private BinanceClient binance { get; set; }
        
        private List<Alert> alertList { get; set; }
        private System.Timers.Timer alertTimer = new System.Timers.Timer();
        private const string PortfolioFile = "portfolio.csv";
        private const string AlertFile = "alert.csv";
        private const string BinanceTradeFile = "binance.csv";
        private const string TradeLogFile = "log.csv";
        private const string ConfigurationFile = "configuration.csv";
        private const string AlertLogFile = "alert_log.csv";
        private const int DefaultInterval = 50000;

        private static readonly DateTime Epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
        private static int count = 0;
        private List<MarketSummary> marketSummaryList { get; set; }

        private List<BinanceOrder> binanceOrderList { get; set; }
        private List<Bid> bidList { get; set; }
        private System.Timers.Timer binanceTradeTimer = new System.Timers.Timer();
        public Form1()
        {
            InitializeComponent();

            bittrex = new Bittrex();
            cryptoCompare = new CryptoCompare();
            binance = new BinanceClient("Rp1VLQjELSvWbrfIoJ785U2PbTprbVqKj878pctrfP6mmiJ0ywDJwDV3ifUCVyLt", "3ASbBHSfq2k7GFOF5y8Xh8QOBLCyoSii9MsLkOMLALWnrYKfmdSpj3WeccBGdpv6");

            #region Configuration
            //Load configuration file
            LoadConfigurationFile();
            #endregion

            #region Alert Tab
            alertList = new List<Alert>();

            comboBoxTradingSite.SelectedIndex = 1;

            //Load all crypto currencies in bittrex
            LoadAllCryptocurrency();

            //Load personal portfolio
            LoadPortfolioFile();

            //Load personal portfolio
            LoadAlertFile();

            //Run Alert User in time interval
            SetAlertTimer();

            AlertUser(alertTimer, null);
            #endregion

            #region Market Summary Tab
            marketSummaryList = new List<MarketSummary>();
            #endregion

            #region Binance Trade
            bidList = new List<Bid>();

            LoadBinanceAllPrices();

            LoadBinanceTradeFile();

            LoadOpenOrders();

            SetBinanceTradeTimer();

            PlaceOrder(binanceTradeTimer, null);
            #endregion
        }

        /// <summary>
        /// Load all cryptocurrencies
        /// </summary>
        private void LoadAllCryptocurrency()
        {
            var cryptoList = Task.Run(bittrex.GetMarkets).Result;
            List<string> temp = new List<string>();
            if(cryptoList.Success)
            {
                foreach(var cryptoItem in cryptoList.Result)
                {
                    temp.Add(cryptoItem.MarketCurrency + " - " + cryptoItem.MarketCurrencyLong);
                }
                temp.Sort();
                comboBoxCryptoList.DataSource = temp.Distinct().ToList();
                //comboBoxCryptoAlert.DataSource = temp.Distinct().ToList();
            }
        }

        /// <summary>
        /// cryptolist combo box change event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboBoxCryptoList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }

        /// <summary>
        /// Convert json object to DataTable
        /// </summary>
        /// <param name="jsonObject"></param>
        /// <returns></returns>
        private object ConvertJsonToDataTable(object jsonObject)
        {
            var json = JsonConvert.SerializeObject(jsonObject);
            if (!Convert.ToString(json).StartsWith("["))
            {
                json = "[" + json + "]";
            }
            return JsonConvert.DeserializeObject<DataTable>(json);
        }

        /// <summary>
        /// Convert generic list to data table
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        private DataTable ConvertListToDataTable<T>(List<T> items)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);
            //Get all the properties by using reflection   
            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props)
            {
                //Setting column names as Property names  
                dataTable.Columns.Add(prop.Name);
            }
            foreach (T item in items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {

                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }

            return dataTable;
        }

        /// <summary>
        /// Load personal portfolio in current folder
        /// </summary>
        /// <param name="nameOfPortfolio">name of csv file</param>
        private void LoadPortfolioFile()
        {
            try
            {
                var filePath = Path.GetDirectoryName(Application.ExecutablePath) + "\\" + PortfolioFile;
                if(File.Exists(filePath))
                {
                    var portfolioItems = File.ReadLines(filePath).ToList();
                    if (portfolioItems.Count > 0)
                    {

                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }

        #region Alert Tab
        /// <summary>
        /// Load alert data from csv file
        /// </summary>
        /// <param name="alertFileName"></param>
        private void LoadAlertFile()
        {
            try
            {
                var filePath = Path.GetDirectoryName(Application.ExecutablePath) + "\\" + AlertFile;
                if (File.Exists(filePath))
                {
                    var alertLines = File.ReadLines(filePath).ToList();
                    foreach (var alertLine in alertLines)
                    {
                        var tempItem = alertLine.Split(',').ToList();
                        alertList.Add(new Alert
                        {
                            MarketName = tempItem[0],
                            MaxValue = tempItem[1],
                            MinValue = tempItem[2],
                            CurrentValue = tempItem[3],
                            TradingSite = tempItem[4]
                        });
                    }
                    dataGridViewCryptoAlert.DataSource = ConvertListToDataTable<Alert>(alertList);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }

        /// <summary>
        /// Load configuration file
        /// </summary>
        private void LoadConfigurationFile()
        {
            try
            {
                var filePath = Path.GetDirectoryName(Application.ExecutablePath) + "\\" + ConfigurationFile;
                if (File.Exists(filePath))
                {
                    var configurationItems = File.ReadLines(filePath).ToList();
                    if (configurationItems.Count > 0)
                    {
                        foreach(var conf in configurationItems)
                        {
                            var configName = conf.Split(',')[0];
                            var configValue = conf.Split(',')[1];
                            switch (configName)
                            {
                                case Constant.Configuration.AlertInterval:
                                    txtAlertInterval.Text = configValue;
                                    break;

                                case Constant.Configuration.TradeInterval:
                                    txtTradeInterval.Text = configValue;
                                    break;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }

        /// <summary>
        /// Update Configuration file
        /// </summary>
        private void UpdateConfigurationFile()
        {
            var filePath = Path.GetDirectoryName(Application.ExecutablePath) + "\\" + ConfigurationFile;
            StringBuilder configContent = new StringBuilder();

            Type type = typeof(Constant.Configuration); 
            foreach (var p in type.GetFields())
            {
                var value = p.GetValue(null);
                switch(value)
                {
                    case Constant.Configuration.AlertInterval:
                        configContent.AppendLine(value + "," + txtAlertInterval.Text);
                        break;

                    case Constant.Configuration.TradeInterval:
                        configContent.AppendLine(value + "," + txtTradeInterval.Text);
                        break;
                }
            }
            File.WriteAllText(filePath, configContent.ToString());
        }

        /// <summary>
        /// Add or update alert item into alert list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddAlert_Click(object sender, EventArgs e)
        {
            try
            {
                if(!string.IsNullOrEmpty(txtMaxVal.Text) && !string.IsNullOrEmpty(txtMinVal.Text) && 
                    !string.IsNullOrEmpty(comboBoxTradingSite.SelectedItem.ToString()))
                {
                    var marketName = comboBoxCryptoAlert.SelectedItem.ToString();
                    var maxVal = txtMaxVal.Text;
                    var minVal = txtMinVal.Text;
                    var tradingVal = comboBoxTradingSite.SelectedItem.ToString();
                    var alertItem = alertList.Where(a => a.MarketName.Equals(comboBoxCryptoAlert.SelectedItem)).FirstOrDefault();
                    if (alertItem == null)
                    {
                        alertList.Add(new Alert
                        {
                            MarketName = marketName,
                            MaxValue = maxVal,
                            MinValue = minVal,
                            CurrentValue = string.Empty,
                            TradingSite = tradingVal
                        });
                    }
                    else
                    {
                        alertList.Remove(alertItem);
                        alertItem.MaxValue = maxVal;
                        alertItem.MinValue = minVal;
                        alertItem.CurrentValue = string.Empty;
                        alertItem.TradingSite = tradingVal;
                        alertList.Add(alertItem);
                    }
                    dataGridViewCryptoAlert.DataSource = ConvertListToDataTable<Alert>(alertList);

                    //Update alert csv
                    UpdateAlertFile();
                }
                else
                {
                    MessageBox.Show("Please select value");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }

        /// <summary>
        /// Update Alert csv file
        /// </summary>
        private void UpdateAlertFile()
        {
            try
            {
                var filePath = Path.GetDirectoryName(Application.ExecutablePath) + "\\" + AlertFile;
                StringBuilder alertContents = new StringBuilder();
                foreach (var item in alertList)
                {
                    alertContents.AppendLine(item.MarketName + "," + item.MaxValue + "," + item.MinValue + "," + item.CurrentValue + "," + item.TradingSite);
                }
                File.WriteAllText(filePath, alertContents.ToString());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }

        /// <summary>
        /// Alert user if price surpass maxvalue or fail behind min value
        /// </summary>
        private void AlertUser(object sender, System.Timers.ElapsedEventArgs e)
        {
            try
            {
                StringBuilder log = new StringBuilder();
                decimal? pairValue = null;
                //get USDT-BTC from Bittrex    
                var pairResult = Task.Run(() => bittrex.GetTicker(Constant.PopularCrypto.USDT + "-" + Constant.PopularCrypto.BTC)).Result;
                if (pairResult.Success)
                {
                    //pairValue = pairResult.Result[Currencies];
                    pairValue = pairResult.Result.Last;
                    for (int i = 0; i < alertList.Count; i++)
                    {
                        var currentItem = alertList[i];
                        var cryptoName = currentItem.MarketName.Substring(0, currentItem.MarketName.IndexOf("-") - 1);
                        decimal? currentValue = null;
                        var exchangeSite = alertList[i].TradingSite;
                        switch (exchangeSite)
                        {
                            case Constant.ExchangeSite.Bittrex:
                                if(cryptoName.Equals(Constant.PopularCrypto.BTC))
                                {
                                    currentValue = pairValue;
                                }
                                var bittrexResult = Task.Run(() => bittrex.GetTicker(Constant.PopularCrypto.BTC + "-" + cryptoName)).Result;
                                if (bittrexResult.Success)
                                {
                                    currentValue = bittrexResult.Result.Last * pairValue;
                                }
                                log.AppendLine(DateTime.Now.ToString() + ": " + cryptoName + " - " + currentValue);
                                break;

                            case Constant.ExchangeSite.CryptoCompare:
                                //BCC = BCH = Bitcoin Cash
                                cryptoName = cryptoName == "BCC" ? "BCH" : cryptoName;
                                var CryptoResult = Task.Run(() => cryptoCompare.Price(cryptoName, Constant.Currency.USD)).Result;
                                if (CryptoResult.Success)
                                {
                                    currentValue = CryptoResult.Result[Constant.Currency.USD];
                                    log.AppendLine(DateTime.Now.ToString() + ": " + cryptoName + " - " + currentValue);
                                }
                                else
                                {
                                    MessageBox.Show("Failed to get price on crypto compare");
                                }
                                break;

                            case Constant.ExchangeSite.Binance:
                                var allPrices = Task.Run(() => binance.GetAllBookPricesAsync()).Result;
                                if (allPrices.Success)
                                {
                                    decimal temp;
                                    var resultItem = allPrices.Data.Where(x => x.Symbol.Equals((cryptoName + Constant.PopularCrypto.USDT))).FirstOrDefault();
                                    Decimal.TryParse(resultItem.BidPrice.ToString(), out temp);
                                    currentValue = temp;
                                    log.AppendLine(DateTime.Now.ToString() + ": " + cryptoName + " - " + currentValue);
                                }
                                else
                                {
                                    MessageBox.Show("Failed to get price on binance");
                                }
                                break;
                        }

                        if (currentValue != null)
                        {
                            if (currentValue > Decimal.Parse(currentItem.MaxValue) || currentValue < Decimal.Parse(currentItem.MinValue))
                            {
                                //MessageBox.Show("Found: " + alertItem.MarketName);
                                string html = string.Empty;
                                string url = @"https://productive-clock.glitch.me/webhook?hub.message=" + "Price of " + cryptoName + ":" + currentValue;

                                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                                request.AutomaticDecompression = DecompressionMethods.GZip;

                                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                                using (Stream stream = response.GetResponseStream())
                                using (StreamReader reader = new StreamReader(stream))
                                {
                                    html = reader.ReadToEnd();
                                }
                            }
                            currentItem.CurrentValue = currentValue.ToString();
                        }
                    }
                    if (this.IsHandleCreated)
                    {
                        Invoke((MethodInvoker)delegate ()
                        {
                            dataGridViewCryptoAlert.DataSource = ConvertListToDataTable<Alert>(alertList);
                            UpdateAlertFile();
                        });
                    }
                    log.AppendLine("-------------------------");
                    UpdateAlertLogFile(log);
                }
                else
                {
                    MessageBox.Show("Failed to get bittrex ticker");
                }
            }
            catch(TaskCanceledException taskEx)
            {
                MessageBox.Show(taskEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }

        /// <summary>
        /// Trading site combo box change event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxTradingSite_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(comboBoxTradingSite.SelectedItem)
            {
                case Constant.ExchangeSite.Bittrex:
                    var cryptoList = Task.Run(bittrex.GetMarkets).Result;
                    List<string> temp = new List<string>();
                    if (cryptoList.Success)
                    {
                        foreach (var cryptoItem in cryptoList.Result)
                        {
                            temp.Add(cryptoItem.MarketCurrency + " - " + cryptoItem.MarketCurrencyLong);
                        }
                        temp.Sort();
                        comboBoxCryptoAlert.DataSource = temp.Distinct().ToList();
                    }
                    break;
                case Constant.ExchangeSite.Binance:
                    var result = Task.Run(() => binance.GetAllPricesAsync()).Result;
                    //if (result.Success)
                    //{
                    //    List<string> temp = new List<string>();
                    //    foreach (var priceItem in result.Data)
                    //    {
                    //        temp.Add(priceItem.Symbol);
                    //    }
                    //    temp.Sort();
                    //    comboBoxBinanceMarketList.DataSource = temp;
                    //}
                    break;
            }
        }

        /// <summary>
        /// Alert combo box change event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxCryptoAlert_SelectedIndexChanged(object sender, EventArgs e)
        {
            var alertItem = alertList.Where(a => a.MarketName.Equals(comboBoxCryptoAlert.SelectedItem)).FirstOrDefault();
            if (alertItem != null)
            {
                txtMaxVal.Text = alertItem.MaxValue;
                txtMinVal.Text = alertItem.MinValue;
            }
        }

        /// <summary>
        /// User deleting row in alert grid view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cryptoAlertGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            var cryptoName = dataGridViewCryptoAlert.Rows[e.Row.Index].Cells[0].Value.ToString();
            var deleteItem = alertList.Where(a => a.MarketName.Equals(cryptoName)).FirstOrDefault();
            if (deleteItem != null)
            {
                alertList.Remove(deleteItem);
            }
            dataGridViewCryptoAlert.Update();
            UpdateAlertFile();
        }

        /// <summary>
        /// Bind market summary to grid view
        /// </summary>
        /// <param name="marketSummary"></param>
        private void LoadMarketSummaryInGridView(List<MarketSummary> marketSummary)
        {
            gridViewMarketSummary.DataSource = ConvertJsonToDataTable(marketSummary);
        }

        /// <summary>
        /// Add market summary to grid view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddMarketSum_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedItem = (string)comboBoxCryptoList.SelectedItem;
                var selectedMarket = selectedItem.Substring(0, selectedItem.IndexOf("-") - 1);
                var cryptoSummaryTaskRun = Task.Run(() => bittrex.GetMarketSummary(Constant.PopularCrypto.BTC + "-" + selectedMarket)).Result;
                if (cryptoSummaryTaskRun.Success)
                {
                    marketSummaryList.Add(cryptoSummaryTaskRun.Result);
                }
                else
                {
                    MessageBox.Show("Failed to get market summary");
                }

                LoadMarketSummaryInGridView(marketSummaryList);

                string elapsedTime = Convert.ToInt32((DateTime.Now - Epoch).TotalSeconds).ToString();
                var priceResult = Task.Run(() => cryptoCompare.PriceHistorical(Constant.PopularCrypto.BTC, Constant.Currency.USD, elapsedTime)).Result;
                var result = priceResult;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }

        /// <summary>
        /// Update configuration
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdateConfiguration_Click(object sender, EventArgs e)
        {
            SetAlertTimer();

            UpdateConfigurationFile();

            MessageBox.Show("Updated successfully");
        }

        private void SetAlertTimer()
        {
            if (alertTimer.Enabled)
            {
                alertTimer.Dispose();
            }
            alertTimer = new System.Timers.Timer();
            alertTimer.Interval = string.IsNullOrEmpty(txtAlertInterval.Text) ? DefaultInterval : Convert.ToInt32(txtAlertInterval.Text) * 1000;
            alertTimer.Elapsed += new System.Timers.ElapsedEventHandler(AlertUser);
            alertTimer.Start();
        }

        private void UpdateAlertLogFile(StringBuilder content)
        {
            try
            {
                var filePath = Path.GetDirectoryName(Application.ExecutablePath) + "\\" + AlertLogFile;
                StringBuilder bidContent = new StringBuilder(content.ToString());
                if(File.Exists(filePath))
                {
                    var txt = File.ReadAllText(filePath);
                    bidContent.AppendLine(txt);
                }
                File.WriteAllText(filePath, bidContent.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }
        #endregion

        #region Binance Trade
        private void LoadBinanceAllPrices()
        {
            var result = Task.Run(() => binance.GetAllPricesAsync()).Result;
            if(result.Success)
            {
                List<string> temp = new List<string>();
                foreach (var priceItem in result.Data)
                {
                    temp.Add(priceItem.Symbol);
                }
                temp.Sort();
                comboBoxBinanceMarketList.DataSource = temp;
            }
        }

        private void btnAddUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if(!string.IsNullOrEmpty(txtBidAmount.Text) && !string.IsNullOrEmpty(txtBidPrice.Text))
                {
                    var bidItem = new Bid
                    {
                        MarketName = comboBoxBinanceMarketList.SelectedItem.ToString(),
                        BidPrice = txtBidPrice.Text,
                        BidAmount = txtBidAmount.Text,
                        BidType = comboBoxBidType.SelectedItem.ToString()
                    };
                    var findItem = bidList.Where(b => b.MarketName.Equals(bidItem.MarketName) && 
                    b.BidType.Equals(comboBoxBidType.SelectedItem.ToString())).FirstOrDefault();
                    if (findItem == null)
                    {
                        bidList.Add(bidItem);
                    }
                    else
                    {
                        bidList.Remove(findItem);
                        bidList.Add(bidItem);
                    }
                    dataGridViewBinanceTrade.DataSource = ConvertListToDataTable<Bid>(bidList);
                    UpdateBinanceTradeFile();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void UpdateBinanceTradeFile()
        {
            try
            {
                var filePath = Path.GetDirectoryName(Application.ExecutablePath) + "\\" + BinanceTradeFile;
                StringBuilder bidContent = new StringBuilder();
                foreach (var item in bidList)
                {
                    bidContent.AppendLine(item.MarketName + "," + item.BidPrice + "," + item.BidAmount + "," + item.BidType);
                }
                File.WriteAllText(filePath, bidContent.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void dataGridViewBinanceTrade_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            var marketName = dataGridViewBinanceTrade.Rows[e.Row.Index].Cells[0].Value.ToString();
            var deleteItem = bidList.Where(a => a.MarketName.Equals(marketName)).FirstOrDefault();
            if (deleteItem != null)
            {
                bidList.Remove(deleteItem);
            }
            dataGridViewBinanceTrade.Update();
            UpdateBinanceTradeFile();
        }

        private void LoadBinanceTradeFile()
        {
            try
            {
                var filePath = Path.GetDirectoryName(Application.ExecutablePath) + "\\" + BinanceTradeFile;
                if (File.Exists(filePath))
                {
                    var bidLines = File.ReadLines(filePath).ToList();
                    foreach (var bidLine in bidLines)
                    {
                        var tempItem = bidLine.Split(',').ToList();
                        bidList.Add(new Bid
                        {
                            MarketName = tempItem[0],
                            BidPrice = tempItem[1],
                            BidAmount = tempItem[2],
                            BidType = tempItem[3]
                        });
                    }
                    dataGridViewBinanceTrade.DataSource = ConvertListToDataTable<Bid>(bidList);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void SetBinanceTradeTimer()
        {
            if (binanceTradeTimer.Enabled)
            {
                binanceTradeTimer.Dispose();
            }
            binanceTradeTimer = new System.Timers.Timer();
            binanceTradeTimer.Interval = string.IsNullOrEmpty(txtTradeInterval.Text) ? DefaultInterval : Convert.ToInt32(txtTradeInterval.Text) * 1000;
            binanceTradeTimer.Elapsed += new System.Timers.ElapsedEventHandler(PlaceOrder);
            binanceTradeTimer.Start();
        }

        private void PlaceOrder(object sender, System.Timers.ElapsedEventArgs e)
        {
            try
            {
                if (bidList.Count > 0)
                {
                    foreach (var bidItem in bidList)
                    {
                        var result = Task.Run(() => binance.GetOpenOrdersAsync(bidItem.MarketName)).Result;
                        if (result.Success)
                        {
                            foreach (var item in result.Data.ToList())
                            {
                                if (bidItem.MarketName.Equals(item.Symbol) && bidItem.BidType.Equals(item.Side.ToString()))
                                {
                                    //MessageBox.Show("Symbol: " + item.Symbol + "\n" +
                                    //    "Type: " + item.Type + "\n" +
                                    //    "ClientOrderId: " + item.ClientOrderId + "\n" +
                                    //    "ExecutedQuantity: " + item.ExecutedQuantity + "\n" +
                                    //    "IcebergQuantity: " + item.IcebergQuantity + "\n" +
                                    //    "OrderId: " + item.OrderId + "\n" +
                                    //    "OriginalQuantity: " + item.OriginalQuantity + "\n" +
                                    //    "Price: " + item.Price + "\n" +
                                    //    "Side: " + item.Side + "\n" +
                                    //    "Status: " + item.Status + "\n" +
                                    //    "StopPrice: " + item.StopPrice + "\n" +
                                    //    "Time: " + item.Time + "\n" +
                                    //    "TimeInForce: " + item.TimeInForce + "\n");
                                }
                                else
                                {
                                    //var accountInfoResult = Task.Run(() => binance.GetAccountInfoAsync()).Result;
                                    //if(accountInfoResult.Success)
                                    //{
                                    //    var data = accountInfoResult.Data;
                                    //    data.Balances.Where(x => x.Asset.Equals(bidItem.MarketName)).FirstOrDefault();
                                    //    foreach(var balance in data.Balances)
                                    //    {

                                    //    }
                                    //}
                                }
                            }
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void LoadOpenOrders()
        {
            //var result = Task.Run(() => binance.GetOpenOrdersAsync("BCCUSDT")).Result;
            //if (result.Success)
            //{
            //    if (result.Data.Count() > 0)
            //    {
            //        var temp = ConvertListToDataTable<BinanceOrder>(result.Data.ToList());
            //        dataGridViewBinanceOpenOrders.DataSource = temp;
            //    }
            //}
        }

        private void UpdateTradeLogFile()
        {
            try
            {
                var filePath = Path.GetDirectoryName(Application.ExecutablePath) + "\\" + TradeLogFile;
                StringBuilder bidContent = new StringBuilder();
                var txt = File.ReadAllText(filePath);
                bidContent.AppendLine(txt);
                File.WriteAllText(filePath, bidContent.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }
        #endregion

        
    }
}

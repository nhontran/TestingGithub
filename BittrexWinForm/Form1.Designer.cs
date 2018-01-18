namespace BittrexWinForm
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.comboBoxCryptoList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabAlert = new System.Windows.Forms.TabPage();
            this.comboBoxTradingSite = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridViewCryptoAlert = new System.Windows.Forms.DataGridView();
            this.btnAddAlert = new System.Windows.Forms.Button();
            this.comboBoxCryptoAlert = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMinVal = new System.Windows.Forms.TextBox();
            this.txtMaxVal = new System.Windows.Forms.TextBox();
            this.tabMarketSum = new System.Windows.Forms.TabPage();
            this.btnAddMarketSum = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSummaryInterval = new System.Windows.Forms.TextBox();
            this.gridViewMarketSummary = new System.Windows.Forms.DataGridView();
            this.tabBinanceTrade = new System.Windows.Forms.TabPage();
            this.dataGridViewBinanceOpenOrders = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBoxBidType = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBidAmount = new System.Windows.Forms.TextBox();
            this.btnAddUpdate = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBidPrice = new System.Windows.Forms.TextBox();
            this.comboBoxBinanceMarketList = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridViewBinanceTrade = new System.Windows.Forms.DataGridView();
            this.tabBittrexTrade = new System.Windows.Forms.TabPage();
            this.tabConfiguration = new System.Windows.Forms.TabPage();
            this.btnUpdateConfiguration = new System.Windows.Forms.Button();
            this.txtTradeInterval = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAlertInterval = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabAlert.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCryptoAlert)).BeginInit();
            this.tabMarketSum.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMarketSummary)).BeginInit();
            this.tabBinanceTrade.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBinanceOpenOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBinanceTrade)).BeginInit();
            this.tabConfiguration.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxCryptoList
            // 
            this.comboBoxCryptoList.FormattingEnabled = true;
            this.comboBoxCryptoList.Location = new System.Drawing.Point(5, 31);
            this.comboBoxCryptoList.Name = "comboBoxCryptoList";
            this.comboBoxCryptoList.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCryptoList.TabIndex = 0;
            this.comboBoxCryptoList.SelectedIndexChanged += new System.EventHandler(this.ComboBoxCryptoList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Coin / Token";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(360, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabAlert);
            this.tabControl1.Controls.Add(this.tabMarketSum);
            this.tabControl1.Controls.Add(this.tabBinanceTrade);
            this.tabControl1.Controls.Add(this.tabBittrexTrade);
            this.tabControl1.Controls.Add(this.tabConfiguration);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(710, 637);
            this.tabControl1.TabIndex = 1;
            // 
            // tabAlert
            // 
            this.tabAlert.Controls.Add(this.comboBoxTradingSite);
            this.tabAlert.Controls.Add(this.label6);
            this.tabAlert.Controls.Add(this.dataGridViewCryptoAlert);
            this.tabAlert.Controls.Add(this.btnAddAlert);
            this.tabAlert.Controls.Add(this.comboBoxCryptoAlert);
            this.tabAlert.Controls.Add(this.label4);
            this.tabAlert.Controls.Add(this.label3);
            this.tabAlert.Controls.Add(this.label2);
            this.tabAlert.Controls.Add(this.txtMinVal);
            this.tabAlert.Controls.Add(this.txtMaxVal);
            this.tabAlert.Location = new System.Drawing.Point(4, 22);
            this.tabAlert.Name = "tabAlert";
            this.tabAlert.Padding = new System.Windows.Forms.Padding(3);
            this.tabAlert.Size = new System.Drawing.Size(702, 611);
            this.tabAlert.TabIndex = 1;
            this.tabAlert.Text = "Alert";
            this.tabAlert.UseVisualStyleBackColor = true;
            // 
            // comboBoxTradingSite
            // 
            this.comboBoxTradingSite.FormattingEnabled = true;
            this.comboBoxTradingSite.Items.AddRange(new object[] {
            "Bittrex",
            "Binance",
            "CryptoCompare"});
            this.comboBoxTradingSite.Location = new System.Drawing.Point(7, 183);
            this.comboBoxTradingSite.Name = "comboBoxTradingSite";
            this.comboBoxTradingSite.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTradingSite.TabIndex = 9;
            this.comboBoxTradingSite.SelectedIndexChanged += new System.EventHandler(this.comboBoxTradingSite_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Trading Site";
            // 
            // dataGridViewCryptoAlert
            // 
            this.dataGridViewCryptoAlert.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCryptoAlert.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCryptoAlert.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCryptoAlert.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewCryptoAlert.Location = new System.Drawing.Point(145, 18);
            this.dataGridViewCryptoAlert.Name = "dataGridViewCryptoAlert";
            this.dataGridViewCryptoAlert.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCryptoAlert.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewCryptoAlert.Size = new System.Drawing.Size(551, 587);
            this.dataGridViewCryptoAlert.TabIndex = 7;
            this.dataGridViewCryptoAlert.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.cryptoAlertGridView_UserDeletingRow);
            // 
            // btnAddAlert
            // 
            this.btnAddAlert.Location = new System.Drawing.Point(6, 218);
            this.btnAddAlert.Name = "btnAddAlert";
            this.btnAddAlert.Size = new System.Drawing.Size(121, 23);
            this.btnAddAlert.TabIndex = 6;
            this.btnAddAlert.Text = "Add/Update";
            this.btnAddAlert.UseVisualStyleBackColor = true;
            this.btnAddAlert.Click += new System.EventHandler(this.btnAddAlert_Click);
            // 
            // comboBoxCryptoAlert
            // 
            this.comboBoxCryptoAlert.FormattingEnabled = true;
            this.comboBoxCryptoAlert.Location = new System.Drawing.Point(6, 34);
            this.comboBoxCryptoAlert.Name = "comboBoxCryptoAlert";
            this.comboBoxCryptoAlert.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCryptoAlert.TabIndex = 5;
            this.comboBoxCryptoAlert.SelectedIndexChanged += new System.EventHandler(this.comboBoxCryptoAlert_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Coin Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Min Value (USD)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Max Value (USD)";
            // 
            // txtMinVal
            // 
            this.txtMinVal.Location = new System.Drawing.Point(7, 133);
            this.txtMinVal.Name = "txtMinVal";
            this.txtMinVal.Size = new System.Drawing.Size(121, 20);
            this.txtMinVal.TabIndex = 1;
            this.txtMinVal.Text = "0";
            // 
            // txtMaxVal
            // 
            this.txtMaxVal.Location = new System.Drawing.Point(7, 84);
            this.txtMaxVal.Name = "txtMaxVal";
            this.txtMaxVal.Size = new System.Drawing.Size(121, 20);
            this.txtMaxVal.TabIndex = 0;
            this.txtMaxVal.Text = "0";
            // 
            // tabMarketSum
            // 
            this.tabMarketSum.Controls.Add(this.btnAddMarketSum);
            this.tabMarketSum.Controls.Add(this.label5);
            this.tabMarketSum.Controls.Add(this.txtSummaryInterval);
            this.tabMarketSum.Controls.Add(this.label1);
            this.tabMarketSum.Controls.Add(this.gridViewMarketSummary);
            this.tabMarketSum.Controls.Add(this.button1);
            this.tabMarketSum.Controls.Add(this.comboBoxCryptoList);
            this.tabMarketSum.Location = new System.Drawing.Point(4, 22);
            this.tabMarketSum.Name = "tabMarketSum";
            this.tabMarketSum.Padding = new System.Windows.Forms.Padding(3);
            this.tabMarketSum.Size = new System.Drawing.Size(702, 611);
            this.tabMarketSum.TabIndex = 0;
            this.tabMarketSum.Text = "Market Summary";
            this.tabMarketSum.UseVisualStyleBackColor = true;
            // 
            // btnAddMarketSum
            // 
            this.btnAddMarketSum.Location = new System.Drawing.Point(144, 31);
            this.btnAddMarketSum.Name = "btnAddMarketSum";
            this.btnAddMarketSum.Size = new System.Drawing.Size(75, 23);
            this.btnAddMarketSum.TabIndex = 6;
            this.btnAddMarketSum.Text = "Add";
            this.btnAddMarketSum.UseVisualStyleBackColor = true;
            this.btnAddMarketSum.Click += new System.EventHandler(this.btnAddMarketSum_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(232, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Refresh Interval (s)";
            // 
            // txtSummaryInterval
            // 
            this.txtSummaryInterval.Location = new System.Drawing.Point(235, 34);
            this.txtSummaryInterval.Name = "txtSummaryInterval";
            this.txtSummaryInterval.Size = new System.Drawing.Size(104, 20);
            this.txtSummaryInterval.TabIndex = 4;
            // 
            // gridViewMarketSummary
            // 
            this.gridViewMarketSummary.AllowUserToAddRows = false;
            this.gridViewMarketSummary.AllowUserToDeleteRows = false;
            this.gridViewMarketSummary.AllowUserToOrderColumns = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewMarketSummary.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridViewMarketSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridViewMarketSummary.DefaultCellStyle = dataGridViewCellStyle5;
            this.gridViewMarketSummary.Location = new System.Drawing.Point(9, 71);
            this.gridViewMarketSummary.Name = "gridViewMarketSummary";
            this.gridViewMarketSummary.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewMarketSummary.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gridViewMarketSummary.Size = new System.Drawing.Size(577, 310);
            this.gridViewMarketSummary.TabIndex = 2;
            // 
            // tabBinanceTrade
            // 
            this.tabBinanceTrade.Controls.Add(this.dataGridViewBinanceOpenOrders);
            this.tabBinanceTrade.Controls.Add(this.label13);
            this.tabBinanceTrade.Controls.Add(this.textBox1);
            this.tabBinanceTrade.Controls.Add(this.comboBoxBidType);
            this.tabBinanceTrade.Controls.Add(this.label12);
            this.tabBinanceTrade.Controls.Add(this.label11);
            this.tabBinanceTrade.Controls.Add(this.txtBidAmount);
            this.tabBinanceTrade.Controls.Add(this.btnAddUpdate);
            this.tabBinanceTrade.Controls.Add(this.label10);
            this.tabBinanceTrade.Controls.Add(this.txtBidPrice);
            this.tabBinanceTrade.Controls.Add(this.comboBoxBinanceMarketList);
            this.tabBinanceTrade.Controls.Add(this.label9);
            this.tabBinanceTrade.Controls.Add(this.dataGridViewBinanceTrade);
            this.tabBinanceTrade.Location = new System.Drawing.Point(4, 22);
            this.tabBinanceTrade.Name = "tabBinanceTrade";
            this.tabBinanceTrade.Size = new System.Drawing.Size(702, 611);
            this.tabBinanceTrade.TabIndex = 3;
            this.tabBinanceTrade.Text = "Binance Trade";
            this.tabBinanceTrade.UseVisualStyleBackColor = true;
            // 
            // dataGridViewBinanceOpenOrders
            // 
            this.dataGridViewBinanceOpenOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBinanceOpenOrders.Location = new System.Drawing.Point(13, 356);
            this.dataGridViewBinanceOpenOrders.Name = "dataGridViewBinanceOpenOrders";
            this.dataGridViewBinanceOpenOrders.Size = new System.Drawing.Size(682, 255);
            this.dataGridViewBinanceOpenOrders.TabIndex = 12;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(161, 66);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 13);
            this.label13.TabIndex = 11;
            this.label13.Text = "Profit";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(158, 86);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 10;
            // 
            // comboBoxBidType
            // 
            this.comboBoxBidType.FormattingEnabled = true;
            this.comboBoxBidType.Items.AddRange(new object[] {
            "Buy",
            "Sell"});
            this.comboBoxBidType.Location = new System.Drawing.Point(408, 33);
            this.comboBoxBidType.Name = "comboBoxBidType";
            this.comboBoxBidType.Size = new System.Drawing.Size(99, 21);
            this.comboBoxBidType.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(405, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Buy/Sell";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(280, 14);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "Bid Amount";
            // 
            // txtBidAmount
            // 
            this.txtBidAmount.Location = new System.Drawing.Point(281, 34);
            this.txtBidAmount.Name = "txtBidAmount";
            this.txtBidAmount.Size = new System.Drawing.Size(100, 20);
            this.txtBidAmount.TabIndex = 6;
            // 
            // btnAddUpdate
            // 
            this.btnAddUpdate.Location = new System.Drawing.Point(529, 31);
            this.btnAddUpdate.Name = "btnAddUpdate";
            this.btnAddUpdate.Size = new System.Drawing.Size(80, 23);
            this.btnAddUpdate.TabIndex = 5;
            this.btnAddUpdate.Text = "Add/Update";
            this.btnAddUpdate.UseVisualStyleBackColor = true;
            this.btnAddUpdate.Click += new System.EventHandler(this.btnAddUpdate_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(159, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Bid Price";
            // 
            // txtBidPrice
            // 
            this.txtBidPrice.Location = new System.Drawing.Point(158, 34);
            this.txtBidPrice.Name = "txtBidPrice";
            this.txtBidPrice.Size = new System.Drawing.Size(100, 20);
            this.txtBidPrice.TabIndex = 3;
            // 
            // comboBoxBinanceMarketList
            // 
            this.comboBoxBinanceMarketList.FormattingEnabled = true;
            this.comboBoxBinanceMarketList.Location = new System.Drawing.Point(16, 34);
            this.comboBoxBinanceMarketList.Name = "comboBoxBinanceMarketList";
            this.comboBoxBinanceMarketList.Size = new System.Drawing.Size(121, 21);
            this.comboBoxBinanceMarketList.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Market Name";
            // 
            // dataGridViewBinanceTrade
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBinanceTrade.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewBinanceTrade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewBinanceTrade.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewBinanceTrade.Location = new System.Drawing.Point(13, 112);
            this.dataGridViewBinanceTrade.Name = "dataGridViewBinanceTrade";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBinanceTrade.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewBinanceTrade.Size = new System.Drawing.Size(682, 238);
            this.dataGridViewBinanceTrade.TabIndex = 0;
            this.dataGridViewBinanceTrade.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridViewBinanceTrade_UserDeletingRow);
            // 
            // tabBittrexTrade
            // 
            this.tabBittrexTrade.Location = new System.Drawing.Point(4, 22);
            this.tabBittrexTrade.Name = "tabBittrexTrade";
            this.tabBittrexTrade.Size = new System.Drawing.Size(702, 611);
            this.tabBittrexTrade.TabIndex = 4;
            this.tabBittrexTrade.Text = "Bittrex Trade";
            this.tabBittrexTrade.UseVisualStyleBackColor = true;
            // 
            // tabConfiguration
            // 
            this.tabConfiguration.Controls.Add(this.btnUpdateConfiguration);
            this.tabConfiguration.Controls.Add(this.txtTradeInterval);
            this.tabConfiguration.Controls.Add(this.label8);
            this.tabConfiguration.Controls.Add(this.txtAlertInterval);
            this.tabConfiguration.Controls.Add(this.label7);
            this.tabConfiguration.Location = new System.Drawing.Point(4, 22);
            this.tabConfiguration.Name = "tabConfiguration";
            this.tabConfiguration.Size = new System.Drawing.Size(702, 611);
            this.tabConfiguration.TabIndex = 2;
            this.tabConfiguration.Text = "Configuration";
            this.tabConfiguration.UseVisualStyleBackColor = true;
            // 
            // btnUpdateConfiguration
            // 
            this.btnUpdateConfiguration.Location = new System.Drawing.Point(21, 133);
            this.btnUpdateConfiguration.Name = "btnUpdateConfiguration";
            this.btnUpdateConfiguration.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateConfiguration.TabIndex = 4;
            this.btnUpdateConfiguration.Text = "Update";
            this.btnUpdateConfiguration.UseVisualStyleBackColor = true;
            this.btnUpdateConfiguration.Click += new System.EventHandler(this.btnUpdateConfiguration_Click);
            // 
            // txtTradeInterval
            // 
            this.txtTradeInterval.Location = new System.Drawing.Point(21, 93);
            this.txtTradeInterval.Name = "txtTradeInterval";
            this.txtTradeInterval.Size = new System.Drawing.Size(100, 20);
            this.txtTradeInterval.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Trade Interval";
            // 
            // txtAlertInterval
            // 
            this.txtAlertInterval.Location = new System.Drawing.Point(21, 36);
            this.txtAlertInterval.Name = "txtAlertInterval";
            this.txtAlertInterval.Size = new System.Drawing.Size(100, 20);
            this.txtAlertInterval.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Alert Interval";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 661);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Cryptocurrency";
            this.tabControl1.ResumeLayout(false);
            this.tabAlert.ResumeLayout(false);
            this.tabAlert.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCryptoAlert)).EndInit();
            this.tabMarketSum.ResumeLayout(false);
            this.tabMarketSum.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMarketSummary)).EndInit();
            this.tabBinanceTrade.ResumeLayout(false);
            this.tabBinanceTrade.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBinanceOpenOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBinanceTrade)).EndInit();
            this.tabConfiguration.ResumeLayout(false);
            this.tabConfiguration.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.ComboBox comboBoxCryptoList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabMarketSum;
        private System.Windows.Forms.DataGridView gridViewMarketSummary;
        private System.Windows.Forms.TabPage tabAlert;
        private System.Windows.Forms.ComboBox comboBoxCryptoAlert;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMinVal;
        private System.Windows.Forms.TextBox txtMaxVal;
        private System.Windows.Forms.Button btnAddAlert;
        private System.Windows.Forms.DataGridView dataGridViewCryptoAlert;
        private System.Windows.Forms.TabPage tabConfiguration;
        private System.Windows.Forms.TabPage tabBinanceTrade;
        private System.Windows.Forms.TabPage tabBittrexTrade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSummaryInterval;
        private System.Windows.Forms.Button btnAddMarketSum;
        private System.Windows.Forms.Button btnUpdateConfiguration;
        private System.Windows.Forms.TextBox txtTradeInterval;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAlertInterval;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxTradingSite;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBidAmount;
        private System.Windows.Forms.Button btnAddUpdate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBidPrice;
        private System.Windows.Forms.ComboBox comboBoxBinanceMarketList;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridViewBinanceTrade;
        private System.Windows.Forms.ComboBox comboBoxBidType;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dataGridViewBinanceOpenOrders;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox1;
    }
}


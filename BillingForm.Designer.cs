namespace BeerPalaceEPOSApp
{
    partial class BillingForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillingForm));
            this.BeerNamesListBox = new System.Windows.Forms.ListBox();
            this.BeerTypeHeadingLabel = new System.Windows.Forms.Label();
            this.BeerSubTypeListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddToCartButton = new System.Windows.Forms.Button();
            this.ItemQuantityLabel = new System.Windows.Forms.Label();
            this.QuantityValuesTextBox = new System.Windows.Forms.TextBox();
            this.DataGridCart = new System.Windows.Forms.DataGridView();
            this.Item_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceForBeerListBox = new System.Windows.Forms.ListBox();
            this.PriceListBox = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.TotalCostValueTextBox = new System.Windows.Forms.TextBox();
            this.TotalcostLabel = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.ManagementReportButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.DailySalesReportButton = new System.Windows.Forms.Button();
            this.SearchTransactionsButton = new System.Windows.Forms.Button();
            this.DataGridViewPanel = new System.Windows.Forms.Panel();
            this.ProductPanel = new System.Windows.Forms.Panel();
            this.ButtonPanelOne = new System.Windows.Forms.Panel();
            this.SaveToFileButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ExitButtonTwo = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridCart)).BeginInit();
            this.DataGridViewPanel.SuspendLayout();
            this.ProductPanel.SuspendLayout();
            this.ButtonPanelOne.SuspendLayout();
            this.SuspendLayout();
            // 
            // BeerNamesListBox
            // 
            this.BeerNamesListBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.BeerNamesListBox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BeerNamesListBox.FormattingEnabled = true;
            this.BeerNamesListBox.ItemHeight = 17;
            this.BeerNamesListBox.Items.AddRange(new object[] {
            "Guinness Irish Stout",
            "Beamish Genuine Irish Stout",
            "Murphy\'s Irish Stout",
            "McGargles Francis’ Big Bangin’ IPA",
            "Kilkenny Irish Cream Ale",
            "Smithwick’s Red Ale",
            "Harp Lager",
            "O’ Hara’s Irish Stout",
            "Porterhouse Temple Lager",
            "Rascals Happy Days Session Pale Ale",
            "Wicklow Wolf Elevation Pale Ale",
            "Galway Bay Althea APA",
            "Irish Red ale",
            "White Hag Black Boar "});
            this.BeerNamesListBox.Location = new System.Drawing.Point(3, 36);
            this.BeerNamesListBox.Name = "BeerNamesListBox";
            this.BeerNamesListBox.Size = new System.Drawing.Size(288, 123);
            this.BeerNamesListBox.TabIndex = 1;
            this.BeerNamesListBox.SelectedIndexChanged += new System.EventHandler(this.BeerNamesListBox_SelectedIndexChanged);
            // 
            // BeerTypeHeadingLabel
            // 
            this.BeerTypeHeadingLabel.AutoSize = true;
            this.BeerTypeHeadingLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BeerTypeHeadingLabel.ForeColor = System.Drawing.Color.Brown;
            this.BeerTypeHeadingLabel.Location = new System.Drawing.Point(38, 14);
            this.BeerTypeHeadingLabel.Name = "BeerTypeHeadingLabel";
            this.BeerTypeHeadingLabel.Size = new System.Drawing.Size(129, 19);
            this.BeerTypeHeadingLabel.TabIndex = 2;
            this.BeerTypeHeadingLabel.Text = "Available Beers";
            // 
            // BeerSubTypeListBox
            // 
            this.BeerSubTypeListBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.BeerSubTypeListBox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BeerSubTypeListBox.FormattingEnabled = true;
            this.BeerSubTypeListBox.ItemHeight = 17;
            this.BeerSubTypeListBox.Items.AddRange(new object[] {
            "Half pint/glass\t284ml ",
            "Small can\t\t330ml",
            "Large can\t\t500ml",
            "Pint\t\t568ml",
            "Keg of beer\t5,000 ml"});
            this.BeerSubTypeListBox.Location = new System.Drawing.Point(312, 36);
            this.BeerSubTypeListBox.Name = "BeerSubTypeListBox";
            this.BeerSubTypeListBox.Size = new System.Drawing.Size(194, 89);
            this.BeerSubTypeListBox.TabIndex = 3;
            this.BeerSubTypeListBox.SelectedIndexChanged += new System.EventHandler(this.BeerSubTypeListBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(317, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Types";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Brown;
            this.label2.Location = new System.Drawing.Point(411, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Quantity";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // AddToCartButton
            // 
            this.AddToCartButton.AutoSize = true;
            this.AddToCartButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddToCartButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddToCartButton.ForeColor = System.Drawing.Color.DarkRed;
            this.AddToCartButton.Location = new System.Drawing.Point(763, 96);
            this.AddToCartButton.Name = "AddToCartButton";
            this.AddToCartButton.Size = new System.Drawing.Size(91, 29);
            this.AddToCartButton.TabIndex = 6;
            this.AddToCartButton.Text = "A&dd";
            this.toolTip1.SetToolTip(this.AddToCartButton, "Press to add items to cart");
            this.AddToCartButton.UseVisualStyleBackColor = false;
            this.AddToCartButton.Click += new System.EventHandler(this.AddToCartButton_Click);
            // 
            // ItemQuantityLabel
            // 
            this.ItemQuantityLabel.AutoEllipsis = true;
            this.ItemQuantityLabel.AutoSize = true;
            this.ItemQuantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemQuantityLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.ItemQuantityLabel.Location = new System.Drawing.Point(643, 53);
            this.ItemQuantityLabel.Name = "ItemQuantityLabel";
            this.ItemQuantityLabel.Size = new System.Drawing.Size(70, 18);
            this.ItemQuantityLabel.TabIndex = 7;
            this.ItemQuantityLabel.Text = "Quantity";
            this.ItemQuantityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ItemQuantityLabel.Click += new System.EventHandler(this.ItemQuantityLabel_Click);
            // 
            // QuantityValuesTextBox
            // 
            this.QuantityValuesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityValuesTextBox.Location = new System.Drawing.Point(719, 53);
            this.QuantityValuesTextBox.Name = "QuantityValuesTextBox";
            this.QuantityValuesTextBox.Size = new System.Drawing.Size(38, 22);
            this.QuantityValuesTextBox.TabIndex = 8;
            this.QuantityValuesTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.QuantityValuesTextBox.TextChanged += new System.EventHandler(this.QuantityValuesTextBox_TextChanged);
            // 
            // DataGridCart
            // 
            this.DataGridCart.AllowUserToAddRows = false;
            this.DataGridCart.AllowUserToDeleteRows = false;
            this.DataGridCart.AllowUserToOrderColumns = true;
            this.DataGridCart.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DataGridCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item_Name,
            this.Column1,
            this.Quantity,
            this.Total_Price});
            this.DataGridCart.GridColor = System.Drawing.SystemColors.HighlightText;
            this.DataGridCart.Location = new System.Drawing.Point(42, 3);
            this.DataGridCart.Name = "DataGridCart";
            this.DataGridCart.ReadOnly = true;
            this.DataGridCart.Size = new System.Drawing.Size(443, 127);
            this.DataGridCart.TabIndex = 9;
            this.DataGridCart.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ItemCartGridView_CellContentClick);
            // 
            // Item_Name
            // 
            this.Item_Name.HeaderText = "Item_Name";
            this.Item_Name.Name = "Item_Name";
            this.Item_Name.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ItemType";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quanity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // Total_Price
            // 
            this.Total_Price.HeaderText = "Total_Price";
            this.Total_Price.Name = "Total_Price";
            this.Total_Price.ReadOnly = true;
            // 
            // PriceForBeerListBox
            // 
            this.PriceForBeerListBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.PriceForBeerListBox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceForBeerListBox.ForeColor = System.Drawing.Color.Black;
            this.PriceForBeerListBox.FormattingEnabled = true;
            this.PriceForBeerListBox.ItemHeight = 17;
            this.PriceForBeerListBox.Location = new System.Drawing.Point(558, 36);
            this.PriceForBeerListBox.Name = "PriceForBeerListBox";
            this.PriceForBeerListBox.Size = new System.Drawing.Size(79, 89);
            this.PriceForBeerListBox.TabIndex = 10;
            this.PriceForBeerListBox.SelectedIndexChanged += new System.EventHandler(this.PriceForBeerListBox_SelectedIndexChanged);
            // 
            // PriceListBox
            // 
            this.PriceListBox.AutoSize = true;
            this.PriceListBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceListBox.ForeColor = System.Drawing.Color.Brown;
            this.PriceListBox.Location = new System.Drawing.Point(577, 14);
            this.PriceListBox.Name = "PriceListBox";
            this.PriceListBox.Size = new System.Drawing.Size(47, 19);
            this.PriceListBox.TabIndex = 11;
            this.PriceListBox.Text = "Price";
            this.PriceListBox.Click += new System.EventHandler(this.PriceListBox_Click);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(763, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 36);
            this.button1.TabIndex = 12;
            this.button1.Text = "R&educe";
            this.toolTip2.SetToolTip(this.button1, "Press to reduce single quantity at once");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.AutoSize = true;
            this.ConfirmButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ConfirmButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmButton.ForeColor = System.Drawing.Color.DarkRed;
            this.ConfirmButton.Location = new System.Drawing.Point(17, 13);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(99, 29);
            this.ConfirmButton.TabIndex = 13;
            this.ConfirmButton.Text = "Co&nfirm";
            this.toolTip1.SetToolTip(this.ConfirmButton, "Press to confirm the purchase and generate transactions.");
            this.ConfirmButton.UseVisualStyleBackColor = false;
            this.ConfirmButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // TotalCostValueTextBox
            // 
            this.TotalCostValueTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalCostValueTextBox.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalCostValueTextBox.Location = new System.Drawing.Point(411, 136);
            this.TotalCostValueTextBox.Name = "TotalCostValueTextBox";
            this.TotalCostValueTextBox.Size = new System.Drawing.Size(74, 25);
            this.TotalCostValueTextBox.TabIndex = 14;
            this.TotalCostValueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TotalCostValueTextBox.TextChanged += new System.EventHandler(this.TotalCostValueTextBox_TextChanged);
            // 
            // TotalcostLabel
            // 
            this.TotalcostLabel.AutoEllipsis = true;
            this.TotalcostLabel.AutoSize = true;
            this.TotalcostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalcostLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.TotalcostLabel.Location = new System.Drawing.Point(318, 138);
            this.TotalcostLabel.Name = "TotalcostLabel";
            this.TotalcostLabel.Size = new System.Drawing.Size(87, 18);
            this.TotalcostLabel.TabIndex = 15;
            this.TotalcostLabel.Text = "Total Cost";
            this.TotalcostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TotalcostLabel.Click += new System.EventHandler(this.TotalcostLabel_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CancelButton.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.ForeColor = System.Drawing.Color.DarkRed;
            this.CancelButton.Location = new System.Drawing.Point(133, 12);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(102, 29);
            this.CancelButton.TabIndex = 16;
            this.CancelButton.Text = "Ca&ncel";
            this.toolTip1.SetToolTip(this.CancelButton, "Press to cancel the cart items.");
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ManagementReportButton
            // 
            this.ManagementReportButton.AutoSize = true;
            this.ManagementReportButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ManagementReportButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManagementReportButton.ForeColor = System.Drawing.Color.DarkRed;
            this.ManagementReportButton.Location = new System.Drawing.Point(319, 156);
            this.ManagementReportButton.Name = "ManagementReportButton";
            this.ManagementReportButton.Size = new System.Drawing.Size(166, 29);
            this.ManagementReportButton.TabIndex = 23;
            this.ManagementReportButton.Text = "M&anagement Report";
            this.toolTip2.SetToolTip(this.ManagementReportButton, "Press to generate Management Report");
            this.ManagementReportButton.UseVisualStyleBackColor = false;
            this.ManagementReportButton.Click += new System.EventHandler(this.ManagementReportButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Footlight MT Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Brown;
            this.label5.Location = new System.Drawing.Point(401, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 36);
            this.label5.TabIndex = 24;
            this.label5.Text = "BEER PALACE";
            // 
            // ClearButton
            // 
            this.ClearButton.AutoSize = true;
            this.ClearButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClearButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.ForeColor = System.Drawing.Color.DarkRed;
            this.ClearButton.Location = new System.Drawing.Point(264, 13);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(102, 29);
            this.ClearButton.TabIndex = 22;
            this.ClearButton.Text = "C&lear";
            this.toolTip1.SetToolTip(this.ClearButton, "Press to clear the cart items.");
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // DailySalesReportButton
            // 
            this.DailySalesReportButton.AutoSize = true;
            this.DailySalesReportButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DailySalesReportButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DailySalesReportButton.ForeColor = System.Drawing.Color.DarkRed;
            this.DailySalesReportButton.Location = new System.Drawing.Point(511, 156);
            this.DailySalesReportButton.Name = "DailySalesReportButton";
            this.DailySalesReportButton.Size = new System.Drawing.Size(166, 29);
            this.DailySalesReportButton.TabIndex = 34;
            this.DailySalesReportButton.Text = "Sa&les Report";
            this.toolTip2.SetToolTip(this.DailySalesReportButton, "Press to generate daily Sales Report.");
            this.DailySalesReportButton.UseVisualStyleBackColor = false;
            this.DailySalesReportButton.Click += new System.EventHandler(this.DailySalesReportButton_Click);
            // 
            // SearchTransactionsButton
            // 
            this.SearchTransactionsButton.AutoSize = true;
            this.SearchTransactionsButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SearchTransactionsButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTransactionsButton.ForeColor = System.Drawing.Color.DarkRed;
            this.SearchTransactionsButton.Location = new System.Drawing.Point(689, 157);
            this.SearchTransactionsButton.Name = "SearchTransactionsButton";
            this.SearchTransactionsButton.Size = new System.Drawing.Size(166, 29);
            this.SearchTransactionsButton.TabIndex = 36;
            this.SearchTransactionsButton.Text = "Se&arch Transactions";
            this.SearchTransactionsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip2.SetToolTip(this.SearchTransactionsButton, "Press to search transactions by Date or Transaction ID");
            this.SearchTransactionsButton.UseVisualStyleBackColor = false;
            this.SearchTransactionsButton.Click += new System.EventHandler(this.SearchTransactionsButton_Click);
            // 
            // DataGridViewPanel
            // 
            this.DataGridViewPanel.Controls.Add(this.TotalcostLabel);
            this.DataGridViewPanel.Controls.Add(this.TotalCostValueTextBox);
            this.DataGridViewPanel.Controls.Add(this.DataGridCart);
            this.DataGridViewPanel.Location = new System.Drawing.Point(62, 248);
            this.DataGridViewPanel.Name = "DataGridViewPanel";
            this.DataGridViewPanel.Size = new System.Drawing.Size(551, 185);
            this.DataGridViewPanel.TabIndex = 39;
            // 
            // ProductPanel
            // 
            this.ProductPanel.Controls.Add(this.BeerNamesListBox);
            this.ProductPanel.Controls.Add(this.SearchTransactionsButton);
            this.ProductPanel.Controls.Add(this.DailySalesReportButton);
            this.ProductPanel.Controls.Add(this.ManagementReportButton);
            this.ProductPanel.Controls.Add(this.BeerTypeHeadingLabel);
            this.ProductPanel.Controls.Add(this.label1);
            this.ProductPanel.Controls.Add(this.BeerSubTypeListBox);
            this.ProductPanel.Controls.Add(this.PriceListBox);
            this.ProductPanel.Controls.Add(this.PriceForBeerListBox);
            this.ProductPanel.Controls.Add(this.label2);
            this.ProductPanel.Controls.Add(this.ItemQuantityLabel);
            this.ProductPanel.Controls.Add(this.QuantityValuesTextBox);
            this.ProductPanel.Controls.Add(this.button1);
            this.ProductPanel.Controls.Add(this.AddToCartButton);
            this.ProductPanel.Location = new System.Drawing.Point(62, 43);
            this.ProductPanel.Name = "ProductPanel";
            this.ProductPanel.Size = new System.Drawing.Size(878, 199);
            this.ProductPanel.TabIndex = 40;
            // 
            // ButtonPanelOne
            // 
            this.ButtonPanelOne.Controls.Add(this.SaveToFileButton);
            this.ButtonPanelOne.Controls.Add(this.ConfirmButton);
            this.ButtonPanelOne.Controls.Add(this.ClearButton);
            this.ButtonPanelOne.Controls.Add(this.CancelButton);
            this.ButtonPanelOne.Controls.Add(this.ExitButton);
            this.ButtonPanelOne.Location = new System.Drawing.Point(65, 439);
            this.ButtonPanelOne.Name = "ButtonPanelOne";
            this.ButtonPanelOne.Size = new System.Drawing.Size(647, 47);
            this.ButtonPanelOne.TabIndex = 41;
            // 
            // SaveToFileButton
            // 
            this.SaveToFileButton.AutoSize = true;
            this.SaveToFileButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SaveToFileButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveToFileButton.ForeColor = System.Drawing.Color.DarkRed;
            this.SaveToFileButton.Location = new System.Drawing.Point(519, 12);
            this.SaveToFileButton.Name = "SaveToFileButton";
            this.SaveToFileButton.Size = new System.Drawing.Size(102, 29);
            this.SaveToFileButton.TabIndex = 45;
            this.SaveToFileButton.Text = "S&ave to Fie";
            this.toolTip1.SetToolTip(this.SaveToFileButton, "Press to Save  stock to File");
            this.SaveToFileButton.UseVisualStyleBackColor = false;
            this.SaveToFileButton.Click += new System.EventHandler(this.SaveToFileButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.AutoSize = true;
            this.ExitButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ExitButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.Color.DarkRed;
            this.ExitButton.Location = new System.Drawing.Point(392, 12);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(102, 29);
            this.ExitButton.TabIndex = 21;
            this.ExitButton.Text = "E&xit";
            this.toolTip1.SetToolTip(this.ExitButton, "Press to exit the application.");
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ExitButtonTwo
            // 
            this.ExitButtonTwo.AutoSize = true;
            this.ExitButtonTwo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ExitButtonTwo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButtonTwo.ForeColor = System.Drawing.Color.DarkRed;
            this.ExitButtonTwo.Location = new System.Drawing.Point(694, 298);
            this.ExitButtonTwo.Name = "ExitButtonTwo";
            this.ExitButtonTwo.Size = new System.Drawing.Size(102, 29);
            this.ExitButtonTwo.TabIndex = 44;
            this.ExitButtonTwo.Text = "E&xit";
            this.toolTip2.SetToolTip(this.ExitButtonTwo, "Press to exit the application");
            this.ExitButtonTwo.UseVisualStyleBackColor = false;
            this.ExitButtonTwo.Click += new System.EventHandler(this.ExitButtonTwo_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.toolTip1.InitialDelay = 100;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 100;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // toolTip2
            // 
            this.toolTip2.AutomaticDelay = 100;
            this.toolTip2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.toolTip2.IsBalloon = true;
            this.toolTip2.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // BillingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(965, 495);
            this.Controls.Add(this.ExitButtonTwo);
            this.Controls.Add(this.ButtonPanelOne);
            this.Controls.Add(this.DataGridViewPanel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ProductPanel);
            this.ForeColor = System.Drawing.Color.Chocolate;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BillingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Beer Palace Billing";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BillingForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridCart)).EndInit();
            this.DataGridViewPanel.ResumeLayout(false);
            this.DataGridViewPanel.PerformLayout();
            this.ProductPanel.ResumeLayout(false);
            this.ProductPanel.PerformLayout();
            this.ButtonPanelOne.ResumeLayout(false);
            this.ButtonPanelOne.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox BeerNamesListBox;
        private System.Windows.Forms.Label BeerTypeHeadingLabel;
        private System.Windows.Forms.ListBox BeerSubTypeListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddToCartButton;
        private System.Windows.Forms.Label ItemQuantityLabel;
        private System.Windows.Forms.TextBox QuantityValuesTextBox;
        private System.Windows.Forms.DataGridView DataGridCart;
        private System.Windows.Forms.ListBox PriceForBeerListBox;
        private System.Windows.Forms.Label PriceListBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.TextBox TotalCostValueTextBox;
        private System.Windows.Forms.Label TotalcostLabel;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_Price;
        private System.Windows.Forms.Button ManagementReportButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button DailySalesReportButton;
        private System.Windows.Forms.Button SearchTransactionsButton;
        private System.Windows.Forms.Panel DataGridViewPanel;
        private System.Windows.Forms.Panel ProductPanel;
        private System.Windows.Forms.Panel ButtonPanelOne;
        private System.Windows.Forms.Button ExitButtonTwo;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.Button SaveToFileButton;
        private System.Windows.Forms.Button ExitButton;
    }
}


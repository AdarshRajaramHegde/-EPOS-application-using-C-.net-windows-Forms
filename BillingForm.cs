using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeerPalaceEPOSApp
{
    public partial class BillingForm : Form
    {
        public BillingForm()
        {
            InitializeComponent();
        }
        //global variable declaration and assigned to specific values.
        DateTime GetDateTime = DateTime.Now.Date;
        double[,] PriceArray = new double[14, 5] { { 1.8, 2.4, 4, 5.5, 12 }, { 1.9, 2.5, 4.1, 5.6, 12.2 }, { 1.84, 2.45, 4.3, 5.56, 12.8 }, { 1.83, 2.45, 4.5, 5.5, 16 }, { 1.9, 2.5, 4.5, 5.3, 12.7 }, { 1.83, 2.44, 4.56, 5.54, 14.8 }, { 1.84, 2.46, 4.57, 5.58, 13.6 }, { 1.93, 2.64, 4.66, 5.64, 16.8 }, { 1.9, 2.43, 4.76, 5.74, 15.8 }, { 1.83, 2.54, 4.76, 5.94, 13.8 }, { 1.93, 2.48, 4.58, 5.94, 18.8 }, { 1.93, 2.94, 4.96, 5.94, 19.8 }, { 1.893, 2.84, 4.86, 5.84, 19.68 }, { 1.53, 2.44, 4.86, 6.54, 18.8 } };
        public string[] BeerNameArray { get;private set; } = new string[] { "Guinness Irish Stout", "Beamish Genuine Irish Stout", "Murphy's Irish Stout", "McGargles Francis’ Big Bangin’ IPA", "Kilkenny Irish Cream Ale", "Smithwick’s Red Ale", "Harp Lager", "O’ Hara’s Irish Stout", "Porterhouse Temple Lager", "Rascals Happy Days Session Pale Ale", "Wicklow Wolf Elevation Pale Ale", "Galway Bay Althea APA", "Irish Red ale ", "White Hag Black Boar" };
        string[] BeerSizeArray = new string[] { "Half pint/glass 284ml", "Small can 330ml", "Large can 500ml", "Pint 568ml", "Keg of beer 5,000 ml" };
        int[,] StockArray = new int[14,5];
        int[,] DefaultStock = new int[14, 5];
        public static int[,] TempStockArray { get; private set; } = new int[14, 5];
        //Currency is constant which holds Euro currency sybol.
        public const string CURRENCY = "€";
        double FinalValue = 0;
        
        string ProductName,ProductType;
        
        private void ItemQuantityLabel_Click(object sender, EventArgs e)
        {
            
        }

        private void PriceListBox_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void PriceForBeerListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ItemCartGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BeerNamesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //dynamic price display for selected Beer names from list box.
            int BeerNameIndex = BeerNamesListBox.SelectedIndex;
            switch (BeerNameIndex)
            {
                case 0:
                    PriceForBeerListBox.Items.Clear();
                    for (int x = 0; x < 1; x++)
                    {
                        for (int y = 0; y <= 4; y++)
                        {
                            PriceForBeerListBox.Items.Add(CURRENCY + PriceArray[x, y]);
                        }
                    }

                    break;
                case 1:
                    PriceForBeerListBox.Items.Clear();
                    for (int x = 1; x < 2; x++)
                    {
                        for (int y = 0; y <= 4; y++)
                        {
                            PriceForBeerListBox.Items.Add(CURRENCY + PriceArray[x, y]);
                        }
                    }
                    break;
                case 2:
                    PriceForBeerListBox.Items.Clear();
                    for (int x = 2; x < 3; x++)
                    {
                        for (int y = 0; y <= 4; y++)
                        {
                            PriceForBeerListBox.Items.Add(CURRENCY + PriceArray[x, y]);
                        }
                    }
                    break;
                case 3:
                    PriceForBeerListBox.Items.Clear();
                    for (int x = 3; x < 4; x++)
                    {
                        for (int y = 0; y <= 4; y++)
                        {
                            PriceForBeerListBox.Items.Add(CURRENCY + PriceArray[x, y]);
                        }
                    }
                    break;
                case 4:
                    PriceForBeerListBox.Items.Clear();
                    for (int x = 4; x < 5; x++)
                    {
                        for (int y = 0; y <= 4; y++)
                        {
                            PriceForBeerListBox.Items.Add(CURRENCY + PriceArray[x, y]);
                        }
                    }
                    break;
                case 5:
                    PriceForBeerListBox.Items.Clear();
                    for (int x = 5; x < 6; x++)
                    {
                        for (int y = 0; y <= 4; y++)
                        {
                            PriceForBeerListBox.Items.Add(CURRENCY + PriceArray[x, y]);
                        }
                    }
                    break;
                case 6:
                    PriceForBeerListBox.Items.Clear();
                    for (int x = 6; x < 7; x++)
                    {
                        for (int y = 0; y <= 4; y++)
                        {
                            PriceForBeerListBox.Items.Add(CURRENCY + PriceArray[x, y]);
                        }
                    }
                    break;
                case 7:
                    PriceForBeerListBox.Items.Clear();
                    for (int x = 7; x < 8; x++)
                    {
                        for (int y = 0; y <= 4; y++)
                        {
                            PriceForBeerListBox.Items.Add(CURRENCY + PriceArray[x, y]);
                        }
                    }
                    break;
                case 8:
                    PriceForBeerListBox.Items.Clear();
                    for (int x = 8; x < 9; x++)
                    {
                        for (int y = 0; y <= 4; y++)
                        {
                            PriceForBeerListBox.Items.Add(CURRENCY + PriceArray[x, y]);
                        }
                    }
                    break;
                case 9:
                    PriceForBeerListBox.Items.Clear();
                    for (int x = 9; x < 10; x++)
                    {
                        for (int y = 0; y <= 4; y++)
                        {
                            PriceForBeerListBox.Items.Add(CURRENCY + PriceArray[x, y]);
                        }
                    }
                    break;
                case 10:
                    PriceForBeerListBox.Items.Clear();
                    for (int x = 10; x < 11; x++)
                    {
                        for (int y = 0; y <= 4; y++)
                        {
                            PriceForBeerListBox.Items.Add(CURRENCY + PriceArray[x, y]);
                        }
                    }
                    break;
                case 11:
                    PriceForBeerListBox.Items.Clear();
                    for (int x = 11; x < 12; x++)
                    {
                        for (int y = 0; y <= 4; y++)
                        {
                            PriceForBeerListBox.Items.Add(CURRENCY + PriceArray[x, y]);
                        }
                    }
                    break;
                case 12:
                    PriceForBeerListBox.Items.Clear();
                    for (int x = 12; x < 13; x++)
                    {
                        for (int y = 0; y <= 4; y++)
                        {
                            PriceForBeerListBox.Items.Add(CURRENCY + PriceArray[x, y]);
                        }
                    }
                    break;
                case 13:
                    PriceForBeerListBox.Items.Clear();
                    for (int x = 13; x < 14; x++)
                    {
                        for (int y = 0; y <= 4; y++)
                        {
                            PriceForBeerListBox.Items.Add(CURRENCY + PriceArray[x, y]);
                        }
                    }
                    break;
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Code which Changes the visibility of Form.
            ProductPanel.Visible = true;
            ButtonPanelOne.Visible = false;
            ExitButtonTwo.Visible = true ;
            DataGridViewPanel.Visible = false;
            //The Opening stock is loaded from the file and stored in stock array.
            StreamReader InFile;
            InFile = File.OpenText("StockFile.txt");
            for(int i=0; i<14;i++)
            {
                for(int j=0; j<5;j++)
                {
                    StockArray[i, j] = int.Parse(InFile.ReadLine());
                   
                }
            }
            InFile.Close();
            //code in which loaded Stock is copied to Temporary Array for daily operation. 
            Array.Copy(StockArray, TempStockArray, StockArray.Length); 

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Local variable declaration.
            int QuantityReducedValue = int.Parse(QuantityValuesTextBox.Text);
            try
            {
                // decison construct to check quantity reduced is 0.
                if (QuantityReducedValue <=0)
                {
                    MessageBox.Show("Please input the appropriate Value to Quantity of items");
                }
                //decison construct to check the quatity is greater than 0.
                else 
                {
                    //code to reduce the quantity entered by one at a time.
                    QuantityReducedValue = QuantityReducedValue - 1;
                    //code to display the reduced quantity to textbox.
                    QuantityValuesTextBox.Text = QuantityReducedValue.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please input the appropriate Value to Quantity of items");
            }
        }
       
        public void DisplayDataGrid(string ProductName, string ProductType, int ProductQuanity, double TotalCostValue)
        {
            //  DataGridCart.SelectedCells[0].Value.ToString(TransactionID);

            DataGridCart.Rows.Add(ProductName, ProductType, ProductQuanity,CURRENCY + TotalCostValue);
   

        }

        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            // Code which changes visibility of the Billing Form.
            ClearButton.Visible = false;
            DataGridViewPanel.Visible = true;
            DataGridCart.Visible = true;
            TotalCostValueTextBox.Visible = true;
            TotalcostLabel.Visible = true;
            ProductPanel.Visible = true;
            ButtonPanelOne.Visible = true;
            ConfirmButton.Focus();
            ExitButtonTwo.Visible = false;
          

            try
            {
                // Local Variable declaration section.
                int QuantityEntered = int.Parse(QuantityValuesTextBox.Text);
                // Decision construct to check wetaher quantity entered is greater than 0.
                if (QuantityEntered > 0)
                {
                    // Local Variable declaration.
                    int BeerNameIndexSelected = int.Parse(BeerNamesListBox.SelectedIndex.ToString());
                    //Decision construct to check wetaher Beer Name is selected.
                    if (BeerNameIndexSelected >= 0)
                    {
                        // Local Variable declaration.
                        int BeerSizeIndexSelected = int.Parse(BeerSubTypeListBox.SelectedIndex.ToString());
                        //Decision construct to check wetaher Beer Type is selected.
                        if (BeerSizeIndexSelected >= 0)
                        {
                            //Decision construct to check wetaher selected Beer and Beer Type is available.
                            if (TempStockArray[BeerNameIndexSelected, BeerSizeIndexSelected] < QuantityEntered)
                            {
                                // If stock is not available.
                                DataGridViewPanel.Visible = false;
                                MessageBox.Show("Sorry the product is out of stock and Please select other product available", "Out of Stock Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                            else
                            {
                                double InitialTotalCost = 0;
                               
                                // If stock is available then reduce the quantity from stock available.
                                TempStockArray[BeerNameIndexSelected, BeerSizeIndexSelected] = TempStockArray[BeerNameIndexSelected, BeerSizeIndexSelected] - QuantityEntered;
                                //Code which calculates Basic cost.
                                InitialTotalCost = PriceArray[BeerNameIndexSelected, BeerSizeIndexSelected] * QuantityEntered;
                                ProductName = BeerNameArray[BeerNameIndexSelected];
                                ProductType = BeerSizeArray[BeerSizeIndexSelected];
                                //Calling Display method through call by value procedure.
                                DisplayDataGrid(ProductName, ProductType, QuantityEntered, InitialTotalCost);
                                FinalValue = FinalValue + InitialTotalCost;
                                TotalCostValueTextBox.Text = CURRENCY + FinalValue.ToString();
                            }

                        }
                        //decison construct if Beer Name is not selected from listbox.
                        else
                        {
                            ButtonPanelOne.Visible = false;
                            DataGridViewPanel.Visible = false;
                            MessageBox.Show("Please select Beer Size Type", "Select Beer Type Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    //decison construct if Beer type is not selected from listbox.
                    else
                    {
                        ButtonPanelOne.Visible = false;
                        DataGridViewPanel.Visible = false;
                        MessageBox.Show("Please select Beer Name", "Select Beer Name Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    }
                //decison construct executed if quanity is less than 0.
                else
                {
                    ButtonPanelOne.Visible = false;
                    DataGridViewPanel.Visible = false;
                    MessageBox.Show("Qunatity should be greater than 0", "Select Quantity eroor Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            // catch block which catches the exception thrown by try block.
            catch
            {
                ButtonPanelOne.Visible = false;
                DataGridViewPanel.Visible = false;

                MessageBox.Show("Please select Non Negative and greater than 0 Quantity","Negative Qunatity Box Error ",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        // Confirm button which send transaction details to text file.
        private void button2_Click(object sender, EventArgs e)
        {
            ClearButton.Visible = true;
            CancelButton.Visible = false;
            // Code to shift the focus to ClearButton.
            ClearButton.Focus();
            // Code to create string builder and formatted into Text File.
            StringBuilder sb = new StringBuilder();
            //Local variable declaration section.
            int DataGridCartLength = DataGridCart.RowCount;
            for (int i = 0; i < DataGridCartLength; i++)
            {
                // code to format the string and appended from datagrid view.
                sb.AppendLine(DataGridCart[0, i].Value?.ToString()+" 0f "+DataGridCart[2, i].Value?.ToString()+" "+DataGridCart[1, i].Value?.ToString()+" "+ DataGridCart[3, i].Value?.ToString());
                
            }
            //decision construct to write the transaction text file.
            if (MessageBox.Show(string.Format(sb.ToString()+"Total Transaction Cost is"+CURRENCY+FinalValue.ToString()), "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //code which instanciates streamwriter class.
                StreamWriter OutputFile;
                //code to append the string to file.
                OutputFile = File.AppendText("TransactionsFile.txt");
                OutputFile.Close();
                // Local Variable declaration restriceted to this decision construct.
                string Temp;
                int RandomNumber = 0; 
                int BeerConfirmIndex = BeerNamesListBox.SelectedIndex;
                int BeerSizeConfirmed = BeerSubTypeListBox.SelectedIndex;
                //Code which copy the contents of original array to destination array. 
                Array.Copy(TempStockArray, StockArray, TempStockArray.Length);
                //StockArray[BeerConfirmIndex, BeerSizeConfirmed] = TempStockArray[BeerConfirmIndex, BeerSizeConfirmed];
                // calling random number generation method. 
                RandomNumberGenerator(ref RandomNumber);
                StreamReader InputFile;
                InputFile = File.OpenText("TransactionsFile.txt");               
                while (!InputFile.EndOfStream)
                {
                    Temp = InputFile.ReadLine();
                    // To check and generate unique random number. 
                    if (Temp == RandomNumber.ToString())
                    {
                        RandomNumberGenerator(ref RandomNumber);
                    }
                }
                InputFile.Close();
                //Code which appends transaction details from gridview to text file.
                StreamWriter FileOpen;
                FileOpen = File.AppendText("TransactionsFile.txt");
                FileOpen.WriteLine(RandomNumber);
                FileOpen.WriteLine(GetDateTime.ToShortDateString());
                for (int i = 0; i < DataGridCart.Rows.Count; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {

                        FileOpen.WriteLine(DataGridCart[j, i].Value?.ToString());
                    }
                }
                FileOpen.WriteLine("123");
                FileOpen.Close();
                
            }
            // Decision construct if selected cart items will not be purchased.
            else
            {
                // code to clear the gridview cells.
                DataGridCart.ClearSelection();
                DataGridCart.Rows.Clear();
                TotalCostValueTextBox.Clear();
                QuantityValuesTextBox.Clear();
                ClearButton.Focus();
                
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            //Code which changes visisbilty of Form.
            QuantityValuesTextBox.Focus();
            QuantityValuesTextBox.SelectAll();
            AddToCartButton.Focus();
            DataGridViewPanel.Visible = false;
            DataGridCart.Rows.Clear();
            TotalCostValueTextBox.Clear();
            
            // Local variable declaraion.
            int BeerNameIndexSelected = int.Parse(BeerNamesListBox.SelectedIndex.ToString());
            int BeerSizeIndexSelected = int.Parse(BeerSubTypeListBox.SelectedIndex.ToString());
            int QuantityEntered = int.Parse(QuantityValuesTextBox.Text);
            //Decison construct to check quantity is more than 0.
            if (QuantityEntered > 0)
            {
                //code to reduce the stock added while confirming.
                TempStockArray[BeerNameIndexSelected, BeerSizeIndexSelected] = TempStockArray[BeerNameIndexSelected, BeerSizeIndexSelected] + QuantityEntered;
                FinalValue = 0;
                DataGridCart.Rows.Clear();
                QuantityValuesTextBox.Clear();
            }
            //decison construct to check qunatity is less than 0.
            else if(QuantityEntered<=0)
            {
                MessageBox.Show("Please input qunatity correctly", "Input quantity box", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            // code which clears the selected value and changes visisbility of form.
            QuantityValuesTextBox.Focus();
            QuantityValuesTextBox.SelectAll();
            ButtonPanelOne.Visible = true;
            CancelButton.Visible = true;
            DataGridViewPanel.Visible = false;
            DataGridCart.ClearSelection();
            DataGridCart.Rows.Clear();
            TotalCostValueTextBox.Text="0";
            FinalValue = 0;
            QuantityValuesTextBox.Clear();
            ExitButton.Focus();
            BeerNamesListBox.SelectedItems.Clear();
            BeerSubTypeListBox.SelectedItems.Clear();
            PriceForBeerListBox.SelectedItems.Clear();
            DataGridCart.Visible = false;
            TotalCostValueTextBox.Visible = false;
            TotalcostLabel.Visible = false;

            DataGridCart.ClearSelection();
            DataGridCart.Rows.Clear();
        }

        private void ManagementReportButton_Click(object sender, EventArgs e)
        {
            // Code to create Management Report Form.
            SalesReportForm ManagementReport = new SalesReportForm();
            //Code which displays Mangement Report Form.
            ManagementReport.ShowDialog();
        }

       
        // Daily Sales button creates daily sales report and stores in Text file.
        private void DailySalesReportButton_Click(object sender, EventArgs e)
        {
            //Local variable declaration.
            double TotalPriceValue = 0;
            string today = GetDateTime.ToString("dd-MM-yy");
            int[,] SoldItemArray = new int[14, 5];
            //an object of straemreader is created.
            StreamReader InputFile;
            // code to Open the stockFile.
            InputFile = File.OpenText("StockFile.txt");
            //code which uses Loop to read from file and stores in array.
            for (int i = 0; i < 14; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    DefaultStock[i, j] = int.Parse(InputFile.ReadLine());

                }
            }
            InputFile.Close();
            //code to find out the daily sales of item and stored in SoldItem array.
            for (int i=0;i<14;i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    SoldItemArray[i, j] = DefaultStock[i, j] - TempStockArray[i, j];
                    
                }
            }

            // object of StreamWriter class is created to write to the file.
            StreamWriter OutputFile = File.CreateText(today + "DailyTranscationReport.txt");
            OutputFile.WriteLine("Beer Palace Sales Report -- Daily salses \nTime Stamp --- " +GetDateTime);
            OutputFile.Write("\t\t\t\t\t");
            for (int k = 0; k <= 4; k++)
            {

            if(k==1)
                {
                    OutputFile.Write(BeerSizeArray[k] + "\t\t");
                }
               
                else if (k == 3)
                {
                    OutputFile.Write("\t"+BeerSizeArray[k] + "\t\t");
                }
                else
                {
                    OutputFile.Write(BeerSizeArray[k] + "\t");
                }
                
            }
            OutputFile.Write("\tSale Value");
            for (int x = 0; x < 14; x++)
            {
                double saleperitem = 0;
                OutputFile.WriteLine();
                if (x == 1 || x == 4 || x == 8 || x == 10)
                {
                    OutputFile.Write(BeerNameArray[x] + "\t\t");
                }
                else if (x == 2 || x == 5 || x == 0 || x == 7 || x == 11||x==13)
                {
                    OutputFile.Write(BeerNameArray[x] + "\t\t\t");
                }
                else if (x == 3 || x == 9)
                {
                    OutputFile.Write(BeerNameArray[x] + "\t");
                }
                else if(x==6)
                {
                    OutputFile.Write(BeerNameArray[x] + "\t\t\t\t");
                }
                
                
                else {
                    OutputFile.Write(BeerNameArray[x] + "\t\t\t\t");
                }

                for (int y = 0; y <= 4; y++)
                {
                    
                    OutputFile.Write("\t" + SoldItemArray[x, y].ToString()+"\t\t");
                    if (SoldItemArray[x, y] != 0)
                    {
                                                
                        TotalPriceValue += SoldItemArray[x, y] * PriceArray[x, y]; }
                    else
                    {
                        TotalPriceValue+= 0;
                    }
                    saleperitem += SoldItemArray[x, y] * PriceArray[x, y];
                }
                OutputFile.Write("\t\t" + saleperitem);
            }
            OutputFile.WriteLine("\n"+"Total Sold Price :" +CURRENCY+ TotalPriceValue);
            OutputFile.Close();
            MessageBox.Show("Sale Report generated for today", "Confirmation Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SearchTransactionsButton_Click(object sender, EventArgs e)
        {
            // Code to create Search transactions Form.
            SearchForm searchObject = new SearchForm();
            //Code which displays search transactions Form.
            searchObject.ShowDialog();
        }

        private void SearchPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ExitButtonTwo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TotalcostLabel_Click(object sender, EventArgs e)
        {

        }

        private void BeerSubTypeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SaveToFileButton_Click(object sender, EventArgs e)
        {
            //Code to save the daily transactions everyday.
            File.Delete("StockFile.txt");
            StreamWriter FileWrite;
            FileWrite = File.AppendText("StockFile.txt");
            for (int i = 0; i < 14; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    // MessageBox.Show(StockArray[i, j].ToString());
                    FileWrite.WriteLine(StockArray[i, j].ToString());


                }
            }
            FileWrite.Close();
        }

        private void QuantityValuesTextBox_TextChanged(object sender, EventArgs e)
        {

            
        }

        private void TotalCostValueTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void BillingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // daily sale report generated by dafault if staff by mistake closes the application.
            DailySalesReportButton_Click(sender, e);
            DialogResult Message = MessageBox.Show("do yo want to Update the stock ?","Confiramtion Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (Message == DialogResult.Yes)
            {
                //Code to save the daily transactions everyday.
                File.Delete("StockFile.txt");
                StreamWriter FileWrite;
                FileWrite = File.AppendText("StockFile.txt");
                for (int i = 0; i < 14; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                       
                        FileWrite.WriteLine(StockArray[i, j].ToString());


                    }
                }
                FileWrite.Close();
            }
            else
            {
                e.Cancel = true;
                ExitButton.Focus();
            }
            
        }

        private void RandomNumberGenerator(ref int number)
        { // method to generate random number. 
            Random rd = new Random();
            number = rd.Next(100000, 999999);
        }
    }
}
        


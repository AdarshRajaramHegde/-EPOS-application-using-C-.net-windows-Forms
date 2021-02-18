using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BeerPalaceEPOSApp
{
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        private void TransactionIDRadioButton_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void DateRadioButton_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            //Code to change the visibility of the form.
            ClearButton.Visible = true; ;
            ClearButton.Focus();
            SearchDetailsListBox.Items.Clear();
            Searchpanel.Visible = true;
            SearchListBoxPanel.Visible = true;
            //Code to create an instance of Stream reader class.
            StreamReader IntFile;
            IntFile = File.OpenText("TransactionsFile.txt");
            string line;
            //List stores the transacton details stored in File.
            List<string> list = new List<string>();
            int counter = 0;
            while ((line = IntFile.ReadLine()) != null)

            {
                list.Add(line);
                counter++;

            }
            IntFile.Close();
            // code which list elements are added to array.
            string[] TransactionArraySearch = list.ToArray();
            //decision construct to check TransactionId entered.
            if (TransactionIDTextBox.Text!="" && TransactionDateTextBox.Text=="")
            {
                //Local variables declaration.
                string ID = TransactionIDTextBox.Text;
                string[] content = new string[500];
                //123 is like delimitter for file. helps to retrive specific data.
                string result = "123";
                //Decision construct check whether array contains Transaction ID.
                if (TransactionArraySearch.Any(x => x == ID))
                {
                    //code to fetch the index of the Transaction ID presrent in Array.
                    var index = Array.IndexOf(TransactionArraySearch, ID);
                    for (int i = index; i < TransactionArraySearch.Length; i++)
                    {
                        //Decision construct to retrive specific lines.
                        if (TransactionArraySearch[i] != result)
                        {
                            //code to add the details to listbox and Content array.
                            content[i] = TransactionArraySearch[i];
                            SearchDetailsListBox.Items.Add(content[i]);

                        }
                        else
                        {
                            break;
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Transaction ID is not found", "Please Enter Valid Transaction ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            //decison construct if date is provided.
            else if (TransactionIDTextBox.Text =="" && TransactionDateTextBox.Text !="")
            {//Local variable declaration.
                string[] TransactionArrayDuplicate = list.ToArray();
                string Date = TransactionDateTextBox.Text;
                string[] contentTwo = new string[500];
                string result = "123";
                //Code to find whether Array contains the date.
                if (TransactionArrayDuplicate.Any(x => x == Date))
                {
                    //code to fetch the index of the transactiondate.
                    var index = Array.IndexOf(TransactionArrayDuplicate, Date);
                    for (int i = index - 1; i < TransactionArrayDuplicate.Length; i++)
                    {
                        if (TransactionArrayDuplicate[i] != result)
                        {
                            //code to add the details to listbox and Content array.
                            contentTwo[i] = TransactionArrayDuplicate[i];
                            SearchDetailsListBox.Items.Add(contentTwo[i]);

                        }
                        else
                        {
                            continue;
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Transcations not found for provided date", "Please Enter Valid Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please provide Date or TransactionId to search", "Please Enter Valid details ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            //Code to chnage the visisbility of the code.
            ExitButton.Focus();
            Searchpanel.Visible = true;
            TransactionDateTextBox.Clear();
            TransactionIDTextBox.Clear();   
            SearchDetailsListBox.Items.Clear();
            SearchListBoxPanel.Visible = false;

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            //Code to Exits the application.
            this.Close();
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            //Loads the form and changes the visibility of the code.
            TransactionIDTextBox.Focus();
             SearchListBoxPanel.Visible = false;
            ClearButton.Visible = false;
            Searchpanel.Visible = true;
            ExitButton.Visible = true;
        }
    }
}

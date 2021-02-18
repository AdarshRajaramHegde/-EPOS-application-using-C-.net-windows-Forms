using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeerPalaceEPOSApp
{

    public partial class SalesReportForm : Form
    {
        public SalesReportForm()
        {

            InitializeComponent();
        }

        private void SalesReportForm_Load(object sender, EventArgs e)
        {
            // Billing form isntance is created.
            BillingForm Obj = new BillingForm();
            // branching statement for appending values to data grid view.
            for (int i = 0; i < 14; i++)
            {

                    ManagementReportDataGrid.Rows.Add(Obj.BeerNameArray[i],
                    BillingForm.TempStockArray[i, 0],
                    BillingForm.TempStockArray[i, 1],
                    BillingForm.TempStockArray[i, 2],
                    BillingForm.TempStockArray[i, 3],
                    BillingForm.TempStockArray[i, 4]);
                }

            }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ManagementReportDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
  
        }
    }
    }



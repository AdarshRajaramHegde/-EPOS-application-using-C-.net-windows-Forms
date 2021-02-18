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
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }
  
        private void StartBillingButton_Click(object sender, EventArgs e)
        {
            //Code which instanticiates BillingForm (Object creation).
            BillingForm BillingObject = new BillingForm();
            // Code to dispaly the content of the Billing Form on StartBilling button click.
            BillingObject.ShowDialog();
        }

        private void billingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            //Code to close the application.
            this.Close();
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {
            //Code which changes the visibiltiy of MainForm.
            HeadLabel.Visible = true;
            StartBillingButton.Visible = true;
            ExitButton.Visible = true;
        }
    }
}

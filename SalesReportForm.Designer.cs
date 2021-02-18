namespace BeerPalaceEPOSApp
{
    partial class SalesReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesReportForm));
            this.ManagementReportDataGrid = new System.Windows.Forms.DataGridView();
            this.Product_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Size1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SearchTransactionsLabel = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ManagementReportDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ManagementReportDataGrid
            // 
            this.ManagementReportDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ManagementReportDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product_Name,
            this.Product_Size,
            this.Product_Size1,
            this.Column1,
            this.Column2,
            this.Column3});
            this.ManagementReportDataGrid.Location = new System.Drawing.Point(88, 97);
            this.ManagementReportDataGrid.Name = "ManagementReportDataGrid";
            this.ManagementReportDataGrid.Size = new System.Drawing.Size(646, 278);
            this.ManagementReportDataGrid.TabIndex = 0;
            this.ManagementReportDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ManagementReportDataGrid_CellContentClick);
            // 
            // Product_Name
            // 
            this.Product_Name.HeaderText = "Product Name";
            this.Product_Name.Name = "Product_Name";
            // 
            // Product_Size
            // 
            this.Product_Size.HeaderText = "Half pint";
            this.Product_Size.Name = "Product_Size";
            // 
            // Product_Size1
            // 
            this.Product_Size1.HeaderText = "Small Can ";
            this.Product_Size1.Name = "Product_Size1";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Large can ";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Pint ";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Keg of beer 5,000 ml";
            this.Column3.Name = "Column3";
            // 
            // ExitButton
            // 
            this.ExitButton.AutoSize = true;
            this.ExitButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(363, 409);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(70, 29);
            this.ExitButton.TabIndex = 22;
            this.ExitButton.Text = "E&xit";
            this.toolTip1.SetToolTip(this.ExitButton, "Press to Exit the application");
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // SearchTransactionsLabel
            // 
            this.SearchTransactionsLabel.AutoSize = true;
            this.SearchTransactionsLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.SearchTransactionsLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SearchTransactionsLabel.Font = new System.Drawing.Font("Footlight MT Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTransactionsLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.SearchTransactionsLabel.Location = new System.Drawing.Point(162, 9);
            this.SearchTransactionsLabel.Name = "SearchTransactionsLabel";
            this.SearchTransactionsLabel.Size = new System.Drawing.Size(489, 41);
            this.SearchTransactionsLabel.TabIndex = 46;
            this.SearchTransactionsLabel.Text = "Beer Palace Stock Management";
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.toolTip1.InitialDelay = 100;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 100;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Press to exit the application";
            // 
            // SalesReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SearchTransactionsLabel);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ManagementReportDataGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SalesReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SalesReport";
            this.Load += new System.EventHandler(this.SalesReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ManagementReportDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ManagementReportDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Size;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Size1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label SearchTransactionsLabel;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
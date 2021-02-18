namespace BeerPalaceEPOSApp
{
    partial class SearchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchForm));
            this.SearchListBoxPanel = new System.Windows.Forms.Panel();
            this.SearchDetailsListBox = new System.Windows.Forms.ListBox();
            this.SearchDetailsLabel = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.TransactionIDTextBox = new System.Windows.Forms.TextBox();
            this.TransactionDateTextBox = new System.Windows.Forms.TextBox();
            this.SearchByLabel = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.Searchpanel = new System.Windows.Forms.Panel();
            this.TransactionIdLabel = new System.Windows.Forms.Label();
            this.SearchByDateLabel = new System.Windows.Forms.Label();
            this.SearchTransactionsLabel = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SearchListBoxPanel.SuspendLayout();
            this.Searchpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SearchListBoxPanel
            // 
            this.SearchListBoxPanel.Controls.Add(this.SearchDetailsListBox);
            this.SearchListBoxPanel.Controls.Add(this.SearchDetailsLabel);
            this.SearchListBoxPanel.Location = new System.Drawing.Point(460, 139);
            this.SearchListBoxPanel.Name = "SearchListBoxPanel";
            this.SearchListBoxPanel.Size = new System.Drawing.Size(364, 241);
            this.SearchListBoxPanel.TabIndex = 44;
            // 
            // SearchDetailsListBox
            // 
            this.SearchDetailsListBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchDetailsListBox.ForeColor = System.Drawing.Color.DarkRed;
            this.SearchDetailsListBox.FormattingEnabled = true;
            this.SearchDetailsListBox.ItemHeight = 24;
            this.SearchDetailsListBox.Location = new System.Drawing.Point(6, 23);
            this.SearchDetailsListBox.Name = "SearchDetailsListBox";
            this.SearchDetailsListBox.Size = new System.Drawing.Size(355, 196);
            this.SearchDetailsListBox.TabIndex = 30;
            // 
            // SearchDetailsLabel
            // 
            this.SearchDetailsLabel.AutoEllipsis = true;
            this.SearchDetailsLabel.AutoSize = true;
            this.SearchDetailsLabel.BackColor = System.Drawing.Color.White;
            this.SearchDetailsLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SearchDetailsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchDetailsLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.SearchDetailsLabel.Location = new System.Drawing.Point(57, 0);
            this.SearchDetailsLabel.Name = "SearchDetailsLabel";
            this.SearchDetailsLabel.Size = new System.Drawing.Size(145, 18);
            this.SearchDetailsLabel.TabIndex = 31;
            this.SearchDetailsLabel.Text = "Transaction Details";
            this.SearchDetailsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ExitButton
            // 
            this.ExitButton.AutoSize = true;
            this.ExitButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ExitButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.Color.DarkRed;
            this.ExitButton.Location = new System.Drawing.Point(355, 435);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(141, 42);
            this.ExitButton.TabIndex = 36;
            this.ExitButton.Text = "E&xit";
            this.toolTip1.SetToolTip(this.ExitButton, "Press to exit the Application");
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // TransactionIDTextBox
            // 
            this.TransactionIDTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TransactionIDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TransactionIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransactionIDTextBox.Location = new System.Drawing.Point(256, 52);
            this.TransactionIDTextBox.Name = "TransactionIDTextBox";
            this.TransactionIDTextBox.Size = new System.Drawing.Size(100, 15);
            this.TransactionIDTextBox.TabIndex = 28;
            // 
            // TransactionDateTextBox
            // 
            this.TransactionDateTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TransactionDateTextBox.Location = new System.Drawing.Point(256, 90);
            this.TransactionDateTextBox.Name = "TransactionDateTextBox";
            this.TransactionDateTextBox.Size = new System.Drawing.Size(100, 13);
            this.TransactionDateTextBox.TabIndex = 29;
            // 
            // SearchByLabel
            // 
            this.SearchByLabel.AutoEllipsis = true;
            this.SearchByLabel.AutoSize = true;
            this.SearchByLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.SearchByLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SearchByLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchByLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.SearchByLabel.Location = new System.Drawing.Point(36, 13);
            this.SearchByLabel.Name = "SearchByLabel";
            this.SearchByLabel.Size = new System.Drawing.Size(87, 20);
            this.SearchByLabel.TabIndex = 35;
            this.SearchByLabel.Text = "Search By";
            this.SearchByLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SearchButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.ForeColor = System.Drawing.Color.DarkRed;
            this.SearchButton.Location = new System.Drawing.Point(81, 128);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(114, 27);
            this.SearchButton.TabIndex = 25;
            this.SearchButton.Text = "Se&arch ";
            this.toolTip1.SetToolTip(this.SearchButton, "Press to Serach the Transactions");
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.AutoSize = true;
            this.ClearButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClearButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.ForeColor = System.Drawing.Color.DarkRed;
            this.ClearButton.Location = new System.Drawing.Point(256, 128);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(100, 29);
            this.ClearButton.TabIndex = 32;
            this.ClearButton.Text = "C&lear";
            this.toolTip1.SetToolTip(this.ClearButton, "Press to clear the  searched transactions");
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // Searchpanel
            // 
            this.Searchpanel.Controls.Add(this.SearchByDateLabel);
            this.Searchpanel.Controls.Add(this.TransactionIdLabel);
            this.Searchpanel.Controls.Add(this.ClearButton);
            this.Searchpanel.Controls.Add(this.SearchButton);
            this.Searchpanel.Controls.Add(this.SearchByLabel);
            this.Searchpanel.Controls.Add(this.TransactionDateTextBox);
            this.Searchpanel.Controls.Add(this.TransactionIDTextBox);
            this.Searchpanel.Location = new System.Drawing.Point(43, 139);
            this.Searchpanel.Name = "Searchpanel";
            this.Searchpanel.Size = new System.Drawing.Size(378, 178);
            this.Searchpanel.TabIndex = 0;
            // 
            // TransactionIdLabel
            // 
            this.TransactionIdLabel.AutoEllipsis = true;
            this.TransactionIdLabel.AutoSize = true;
            this.TransactionIdLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TransactionIdLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TransactionIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransactionIdLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.TransactionIdLabel.Location = new System.Drawing.Point(81, 52);
            this.TransactionIdLabel.Name = "TransactionIdLabel";
            this.TransactionIdLabel.Size = new System.Drawing.Size(115, 20);
            this.TransactionIdLabel.TabIndex = 36;
            this.TransactionIdLabel.Text = "TransactionID";
            this.TransactionIdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SearchByDateLabel
            // 
            this.SearchByDateLabel.AutoEllipsis = true;
            this.SearchByDateLabel.AutoSize = true;
            this.SearchByDateLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.SearchByDateLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchByDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchByDateLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.SearchByDateLabel.Location = new System.Drawing.Point(80, 90);
            this.SearchByDateLabel.Name = "SearchByDateLabel";
            this.SearchByDateLabel.Size = new System.Drawing.Size(139, 20);
            this.SearchByDateLabel.TabIndex = 37;
            this.SearchByDateLabel.Text = "Transaction Date";
            this.SearchByDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SearchTransactionsLabel
            // 
            this.SearchTransactionsLabel.AutoSize = true;
            this.SearchTransactionsLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.SearchTransactionsLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SearchTransactionsLabel.Font = new System.Drawing.Font("Footlight MT Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTransactionsLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.SearchTransactionsLabel.Location = new System.Drawing.Point(133, 24);
            this.SearchTransactionsLabel.Name = "SearchTransactionsLabel";
            this.SearchTransactionsLabel.Size = new System.Drawing.Size(585, 41);
            this.SearchTransactionsLabel.TabIndex = 45;
            this.SearchTransactionsLabel.Text = "Beer Palace Transaction Management";
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.toolTip1.InitialDelay = 100;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 100;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(860, 511);
            this.Controls.Add(this.SearchTransactionsLabel);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.SearchListBoxPanel);
            this.Controls.Add(this.Searchpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SearchForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchForm";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            this.SearchListBoxPanel.ResumeLayout(false);
            this.SearchListBoxPanel.PerformLayout();
            this.Searchpanel.ResumeLayout(false);
            this.Searchpanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel SearchListBoxPanel;
        private System.Windows.Forms.ListBox SearchDetailsListBox;
        private System.Windows.Forms.Label SearchDetailsLabel;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.TextBox TransactionIDTextBox;
        private System.Windows.Forms.TextBox TransactionDateTextBox;
        private System.Windows.Forms.Label SearchByLabel;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Panel Searchpanel;
        private System.Windows.Forms.Label SearchByDateLabel;
        private System.Windows.Forms.Label TransactionIdLabel;
        private System.Windows.Forms.Label SearchTransactionsLabel;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
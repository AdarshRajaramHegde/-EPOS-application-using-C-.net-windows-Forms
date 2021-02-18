namespace BeerPalaceEPOSApp
{
    partial class MainMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            this.HeadLabel = new System.Windows.Forms.Label();
            this.receiptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startBillingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StartBillingButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // HeadLabel
            // 
            this.HeadLabel.AutoSize = true;
            this.HeadLabel.BackColor = System.Drawing.Color.White;
            this.HeadLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HeadLabel.Font = new System.Drawing.Font("Footlight MT Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeadLabel.ForeColor = System.Drawing.Color.Brown;
            this.HeadLabel.Location = new System.Drawing.Point(320, 9);
            this.HeadLabel.Name = "HeadLabel";
            this.HeadLabel.Size = new System.Drawing.Size(224, 41);
            this.HeadLabel.TabIndex = 1;
            this.HeadLabel.Text = "BEER PALACE";
            // 
            // receiptToolStripMenuItem
            // 
            this.receiptToolStripMenuItem.Name = "receiptToolStripMenuItem";
            this.receiptToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.receiptToolStripMenuItem.Text = "Receipt";
            // 
            // startBillingToolStripMenuItem
            // 
            this.startBillingToolStripMenuItem.Name = "startBillingToolStripMenuItem";
            this.startBillingToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.startBillingToolStripMenuItem.Text = "Start Billing";
            // 
            // StartBillingButton
            // 
            this.StartBillingButton.BackColor = System.Drawing.Color.White;
            this.StartBillingButton.Font = new System.Drawing.Font("Footlight MT Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartBillingButton.ForeColor = System.Drawing.Color.DarkRed;
            this.StartBillingButton.Location = new System.Drawing.Point(60, 394);
            this.StartBillingButton.Name = "StartBillingButton";
            this.StartBillingButton.Size = new System.Drawing.Size(224, 44);
            this.StartBillingButton.TabIndex = 3;
            this.StartBillingButton.Text = "S&tart Billing";
            this.toolTip1.SetToolTip(this.StartBillingButton, "Please press to start billing.");
            this.StartBillingButton.UseVisualStyleBackColor = false;
            this.StartBillingButton.Click += new System.EventHandler(this.StartBillingButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.AutoSize = true;
            this.ExitButton.BackColor = System.Drawing.Color.White;
            this.ExitButton.Font = new System.Drawing.Font("Footlight MT Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.Color.DarkRed;
            this.ExitButton.Location = new System.Drawing.Point(639, 394);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(224, 44);
            this.ExitButton.TabIndex = 22;
            this.ExitButton.Text = "E&xit";
            this.toolTip1.SetToolTip(this.ExitButton, "Please click to Exit the application");
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.toolTip1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolTip1.InitialDelay = 100;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 100;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(927, 450);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.StartBillingButton);
            this.Controls.Add(this.HeadLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "MainMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenuForm";
            this.Load += new System.EventHandler(this.MainMenuForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeadLabel;
        private System.Windows.Forms.ToolStripMenuItem receiptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startBillingToolStripMenuItem;
        private System.Windows.Forms.Button StartBillingButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
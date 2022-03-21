namespace Session_11
{
    partial class ManagerForm
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
            this.RadioTransactionHistory = new System.Windows.Forms.RadioButton();
            this.RadioMonthlyLedger = new System.Windows.Forms.RadioButton();
            this.RadioPetReports = new System.Windows.Forms.RadioButton();
            this.ManagerConfirmbtn = new System.Windows.Forms.Button();
            this.petBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.petBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // RadioTransactionHistory
            // 
            this.RadioTransactionHistory.AutoSize = true;
            this.RadioTransactionHistory.Location = new System.Drawing.Point(12, 12);
            this.RadioTransactionHistory.Name = "RadioTransactionHistory";
            this.RadioTransactionHistory.Size = new System.Drawing.Size(118, 17);
            this.RadioTransactionHistory.TabIndex = 0;
            this.RadioTransactionHistory.TabStop = true;
            this.RadioTransactionHistory.Text = "Transaction History";
            this.RadioTransactionHistory.UseVisualStyleBackColor = true;
            // 
            // RadioMonthlyLedger
            // 
            this.RadioMonthlyLedger.AutoSize = true;
            this.RadioMonthlyLedger.Location = new System.Drawing.Point(12, 35);
            this.RadioMonthlyLedger.Name = "RadioMonthlyLedger";
            this.RadioMonthlyLedger.Size = new System.Drawing.Size(99, 17);
            this.RadioMonthlyLedger.TabIndex = 1;
            this.RadioMonthlyLedger.TabStop = true;
            this.RadioMonthlyLedger.Text = "Monthly Ledger";
            this.RadioMonthlyLedger.UseVisualStyleBackColor = true;
            // 
            // RadioPetReports
            // 
            this.RadioPetReports.AutoSize = true;
            this.RadioPetReports.Location = new System.Drawing.Point(12, 58);
            this.RadioPetReports.Name = "RadioPetReports";
            this.RadioPetReports.Size = new System.Drawing.Size(82, 17);
            this.RadioPetReports.TabIndex = 2;
            this.RadioPetReports.TabStop = true;
            this.RadioPetReports.Text = "Pet Reports";
            this.RadioPetReports.UseVisualStyleBackColor = true;
            // 
            // ManagerConfirmbtn
            // 
            this.ManagerConfirmbtn.Location = new System.Drawing.Point(131, 12);
            this.ManagerConfirmbtn.Name = "ManagerConfirmbtn";
            this.ManagerConfirmbtn.Size = new System.Drawing.Size(108, 63);
            this.ManagerConfirmbtn.TabIndex = 3;
            this.ManagerConfirmbtn.Text = "Confirm";
            this.ManagerConfirmbtn.UseVisualStyleBackColor = true;
            this.ManagerConfirmbtn.Click += new System.EventHandler(this.ManagerConfirmbtn_Click);
            // 
            // petBindingSource
            // 
            this.petBindingSource.DataSource = typeof(PetShopLib.Impl.Pet);
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 99);
            this.Controls.Add(this.ManagerConfirmbtn);
            this.Controls.Add(this.RadioPetReports);
            this.Controls.Add(this.RadioMonthlyLedger);
            this.Controls.Add(this.RadioTransactionHistory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager";
            ((System.ComponentModel.ISupportInitialize)(this.petBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RadioButton RadioTransactionHistory;
        private RadioButton RadioMonthlyLedger;
        private RadioButton RadioPetReports;
        private Button ManagerConfirmbtn;
        private BindingSource petBindingSource;
    }
}
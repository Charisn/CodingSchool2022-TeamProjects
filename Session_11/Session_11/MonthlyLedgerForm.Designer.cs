namespace Session_11
{
    partial class MonthlyLedgerForm
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.grdMonthlyLedger = new DevExpress.XtraGrid.GridControl();
            this.grvMonthlyLedger = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIncome = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExpenses = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBalance = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMonthlyLedger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvMonthlyLedger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.grdMonthlyLedger);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(774, 443);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // grdMonthlyLedger
            // 
            this.grdMonthlyLedger.Location = new System.Drawing.Point(12, 12);
            this.grdMonthlyLedger.MainView = this.grvMonthlyLedger;
            this.grdMonthlyLedger.Name = "grdMonthlyLedger";
            this.grdMonthlyLedger.Size = new System.Drawing.Size(750, 419);
            this.grdMonthlyLedger.TabIndex = 4;
            this.grdMonthlyLedger.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvMonthlyLedger});
            // 
            // grvMonthlyLedger
            // 
            this.grvMonthlyLedger.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIncome,
            this.colExpenses,
            this.colBalance});
            this.grvMonthlyLedger.GridControl = this.grdMonthlyLedger;
            this.grvMonthlyLedger.Name = "grvMonthlyLedger";
            // 
            // colIncome
            // 
            this.colIncome.Caption = "Income";
            this.colIncome.FieldName = "Income";
            this.colIncome.Name = "colIncome";
            this.colIncome.OptionsColumn.AllowEdit = false;
            this.colIncome.Visible = true;
            this.colIncome.VisibleIndex = 0;
            // 
            // colExpenses
            // 
            this.colExpenses.Caption = "Expenses";
            this.colExpenses.FieldName = "Expenses";
            this.colExpenses.Name = "colExpenses";
            this.colExpenses.OptionsColumn.AllowEdit = false;
            this.colExpenses.Visible = true;
            this.colExpenses.VisibleIndex = 1;
            // 
            // colBalance
            // 
            this.colBalance.Caption = "Balance";
            this.colBalance.FieldName = "Total";
            this.colBalance.Name = "colBalance";
            this.colBalance.OptionsColumn.AllowEdit = false;
            this.colBalance.Visible = true;
            this.colBalance.VisibleIndex = 2;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(774, 443);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.grdMonthlyLedger;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(754, 423);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // MonthlyLedgerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 443);
            this.Controls.Add(this.layoutControl1);
            this.Name = "MonthlyLedgerForm";
            this.Text = "MonthlyLedgerForm";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdMonthlyLedger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvMonthlyLedger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl grdMonthlyLedger;
        private DevExpress.XtraGrid.Views.Grid.GridView grvMonthlyLedger;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn colIncome;
        private DevExpress.XtraGrid.Columns.GridColumn colExpenses;
        private DevExpress.XtraGrid.Columns.GridColumn colBalance;
    }
}
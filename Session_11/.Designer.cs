namespace Session_11
{
    partial class TransactionsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing && (components != null))
        //    {
        //        components.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.grdTransaction = new DevExpress.XtraGrid.GridControl();
            this.grvTransaction = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.TransactionID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CustomerID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EmployeeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PetID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PetFoodID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PetFoodQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PetFoodPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PetPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TotalPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemTextEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemTextEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemTextEdit5 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTransaction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvTransaction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.grdTransaction);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(816, 440);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // grdTransaction
            // 
            this.grdTransaction.Location = new System.Drawing.Point(12, 12);
            this.grdTransaction.MainView = this.grvTransaction;
            this.grdTransaction.Name = "grdTransaction";
            this.grdTransaction.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1,
            this.repositoryItemTextEdit2,
            this.repositoryItemTextEdit3,
            this.repositoryItemTextEdit4,
            this.repositoryItemTextEdit5});
            this.grdTransaction.Size = new System.Drawing.Size(792, 416);
            this.grdTransaction.TabIndex = 4;
            this.grdTransaction.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvTransaction});
            // 
            // grvTransaction
            // 
            this.grvTransaction.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.TransactionID,
            this.CustomerID,
            this.EmployeeID,
            this.PetID,
            this.PetFoodID,
            this.PetFoodQuantity,
            this.Date,
            this.PetFoodPrice,
            this.PetPrice,
            this.TotalPrice});
            this.grvTransaction.GridControl = this.grdTransaction;
            this.grvTransaction.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.None, "", null, ""),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.None, "", null, ""),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.None, "", null, "")});
            this.grvTransaction.Name = "grvTransaction";
            // 
            // TransactionID
            // 
            this.TransactionID.Caption = "Transaction ID";
            this.TransactionID.Name = "TransactionID";
            // 
            // CustomerID
            // 
            this.CustomerID.Caption = "Customer ID";
            this.CustomerID.Name = "CustomerID";
            // 
            // EmployeeID
            // 
            this.EmployeeID.Caption = "Employee ID";
            this.EmployeeID.Name = "EmployeeID";
            // 
            // PetID
            // 
            this.PetID.Caption = "Pet ID";
            this.PetID.Name = "PetID";
            // 
            // PetFoodID
            // 
            this.PetFoodID.Caption = "Pet Food ID";
            this.PetFoodID.Name = "PetFoodID";
            // 
            // PetFoodQuantity
            // 
            this.PetFoodQuantity.Caption = "Pet Food Quantity";
            this.PetFoodQuantity.Name = "PetFoodQuantity";
            // 
            // Date
            // 
            this.Date.Caption = "Date";
            this.Date.Name = "Date";
            // 
            // PetFoodPrice
            // 
            this.PetFoodPrice.Caption = "Pet Food Price";
            this.PetFoodPrice.Name = "PetFoodPrice";
            // 
            // PetPrice
            // 
            this.PetPrice.Caption = "Pet Price";
            this.PetPrice.Name = "PetPrice";
            // 
            // TotalPrice
            // 
            this.TotalPrice.Caption = "Total Price";
            this.TotalPrice.Name = "TotalPrice";
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // repositoryItemTextEdit2
            // 
            this.repositoryItemTextEdit2.AutoHeight = false;
            this.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2";
            // 
            // repositoryItemTextEdit3
            // 
            this.repositoryItemTextEdit3.AutoHeight = false;
            this.repositoryItemTextEdit3.Name = "repositoryItemTextEdit3";
            // 
            // repositoryItemTextEdit4
            // 
            this.repositoryItemTextEdit4.AutoHeight = false;
            this.repositoryItemTextEdit4.Name = "repositoryItemTextEdit4";
            // 
            // repositoryItemTextEdit5
            // 
            this.repositoryItemTextEdit5.AutoHeight = false;
            this.repositoryItemTextEdit5.Name = "repositoryItemTextEdit5";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(816, 440);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.grdTransaction;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(796, 420);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // TransactionsForm
            // 
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdTransaction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvTransaction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl grdTransaction;
        private DevExpress.XtraGrid.Views.Grid.GridView grvTransaction;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn TransactionID;
        private DevExpress.XtraGrid.Columns.GridColumn CustomerID;
        private DevExpress.XtraGrid.Columns.GridColumn EmployeeID;
        private DevExpress.XtraGrid.Columns.GridColumn PetID;
        private DevExpress.XtraGrid.Columns.GridColumn PetFoodID;
        private DevExpress.XtraGrid.Columns.GridColumn PetFoodQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn Date;
        private DevExpress.XtraGrid.Columns.GridColumn PetFoodPrice;
        private DevExpress.XtraGrid.Columns.GridColumn PetPrice;
        private DevExpress.XtraGrid.Columns.GridColumn TotalPrice;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit3;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit4;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit5;
    }
}
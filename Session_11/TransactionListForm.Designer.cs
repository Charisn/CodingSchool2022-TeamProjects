namespace Session_11
{
    partial class TransactionListForm
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.grdTransaction = new DevExpress.XtraGrid.GridControl();
            this.grvTransaction = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.TotalPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PetPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PetFoodPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PetFoodQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PetFood = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Pet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Employee = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Customer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCustomer = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.TransactionID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.bsTrans = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTransaction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvTransaction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTrans)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.grdTransaction);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(820, 508);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // grdTransaction
            // 
            this.grdTransaction.Location = new System.Drawing.Point(12, 12);
            this.grdTransaction.MainView = this.grvTransaction;
            this.grdTransaction.Name = "grdTransaction";
            this.grdTransaction.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCustomer,
            this.repositoryItemLookUpEdit1});
            this.grdTransaction.Size = new System.Drawing.Size(796, 484);
            this.grdTransaction.TabIndex = 4;
            this.grdTransaction.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvTransaction});
            // 
            // grvTransaction
            // 
            this.grvTransaction.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.TotalPrice,
            this.Date,
            this.PetPrice,
            this.PetFoodPrice,
            this.PetFoodQty,
            this.PetFood,
            this.Pet,
            this.Employee,
            this.Customer,
            this.TransactionID});
            this.grvTransaction.GridControl = this.grdTransaction;
            this.grvTransaction.Name = "grvTransaction";
            // 
            // TotalPrice
            // 
            this.TotalPrice.Caption = "Total Price";
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.Visible = true;
            this.TotalPrice.VisibleIndex = 0;
            // 
            // Date
            // 
            this.Date.Caption = "Date";
            this.Date.Name = "Date";
            this.Date.Visible = true;
            this.Date.VisibleIndex = 1;
            // 
            // PetPrice
            // 
            this.PetPrice.Caption = "Pet Price";
            this.PetPrice.Name = "PetPrice";
            this.PetPrice.Visible = true;
            this.PetPrice.VisibleIndex = 2;
            // 
            // PetFoodPrice
            // 
            this.PetFoodPrice.Caption = "Pet Food Price";
            this.PetFoodPrice.Name = "PetFoodPrice";
            this.PetFoodPrice.Visible = true;
            this.PetFoodPrice.VisibleIndex = 3;
            // 
            // PetFoodQty
            // 
            this.PetFoodQty.Caption = "Pet Food Qty";
            this.PetFoodQty.Name = "PetFoodQty";
            this.PetFoodQty.Visible = true;
            this.PetFoodQty.VisibleIndex = 4;
            // 
            // PetFood
            // 
            this.PetFood.Caption = "Pet Food";
            this.PetFood.Name = "PetFood";
            this.PetFood.Visible = true;
            this.PetFood.VisibleIndex = 5;
            // 
            // Pet
            // 
            this.Pet.Caption = "Pet";
            this.Pet.Name = "Pet";
            this.Pet.Visible = true;
            this.Pet.VisibleIndex = 6;
            // 
            // Employee
            // 
            this.Employee.Caption = "Employee";
            this.Employee.Name = "Employee";
            this.Employee.Visible = true;
            this.Employee.VisibleIndex = 7;
            // 
            // Customer
            // 
            this.Customer.Caption = "Customer";
            this.Customer.ColumnEdit = this.repositoryItemCustomer;
            this.Customer.Name = "Customer";
            this.Customer.Visible = true;
            this.Customer.VisibleIndex = 8;
            // 
            // repositoryItemCustomer
            // 
            this.repositoryItemCustomer.AccessibleDescription = "Customer";
            this.repositoryItemCustomer.AutoHeight = false;
            this.repositoryItemCustomer.Name = "repositoryItemCustomer";
            this.repositoryItemCustomer.Tag = "<Null>";
            // 
            // TransactionID
            // 
            this.TransactionID.Caption = "Transaction ID";
            this.TransactionID.Name = "TransactionID";
            this.TransactionID.Visible = true;
            this.TransactionID.VisibleIndex = 9;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(820, 508);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.grdTransaction;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(800, 488);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // TransactionListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 508);
            this.Controls.Add(this.layoutControl1);
            this.Name = "TransactionListForm";
            this.Text = "Transactions";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdTransaction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvTransaction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTrans)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl grdTransaction;
        private DevExpress.XtraGrid.Views.Grid.GridView grvTransaction;
        private DevExpress.XtraGrid.Columns.GridColumn TotalPrice;
        private DevExpress.XtraGrid.Columns.GridColumn Date;
        private DevExpress.XtraGrid.Columns.GridColumn PetPrice;
        private DevExpress.XtraGrid.Columns.GridColumn PetFoodPrice;
        private DevExpress.XtraGrid.Columns.GridColumn PetFoodQty;
        private DevExpress.XtraGrid.Columns.GridColumn PetFood;
        private DevExpress.XtraGrid.Columns.GridColumn Pet;
        private DevExpress.XtraGrid.Columns.GridColumn Employee;
        private DevExpress.XtraGrid.Columns.GridColumn Customer;
        private DevExpress.XtraGrid.Columns.GridColumn TransactionID;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemCustomer;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private BindingSource bsTrans;
    }
}
namespace Session_11
{
    partial class EmployeeListForm
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
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.grdEmployees = new DevExpress.XtraGrid.GridControl();
            this.grvEmployees = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSurname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSalaryPerMonth = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmployeeType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repEmployeeType = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.bsPetShop = new System.Windows.Forms.BindingSource(this.components);
            this.bsEmployees = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grdEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repEmployeeType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPetShop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(369, 412);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(87, 43);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(462, 412);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(87, 43);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit..";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(554, 412);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(87, 43);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "New";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(646, 412);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 43);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            // 
            // grdEmployees
            // 
            this.grdEmployees.Location = new System.Drawing.Point(76, 12);
            this.grdEmployees.MainView = this.grvEmployees;
            this.grdEmployees.Name = "grdEmployees";
            this.grdEmployees.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repEmployeeType});
            this.grdEmployees.Size = new System.Drawing.Size(586, 302);
            this.grdEmployees.TabIndex = 4;
            this.grdEmployees.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvEmployees});
            // 
            // grvEmployees
            // 
            this.grvEmployees.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colSurname,
            this.colSalaryPerMonth,
            this.colEmployeeType});
            this.grvEmployees.GridControl = this.grdEmployees;
            this.grvEmployees.Name = "grvEmployees";
            // 
            // colName
            // 
            this.colName.Caption = "Name";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.OptionsColumn.AllowEdit = false;
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            // 
            // colSurname
            // 
            this.colSurname.Caption = "Surname";
            this.colSurname.FieldName = "SurName";
            this.colSurname.Name = "colSurname";
            this.colSurname.OptionsColumn.AllowEdit = false;
            this.colSurname.Visible = true;
            this.colSurname.VisibleIndex = 1;
            // 
            // colSalaryPerMonth
            // 
            this.colSalaryPerMonth.Caption = "Salary Per Month";
            this.colSalaryPerMonth.FieldName = "SalaryPerMonth";
            this.colSalaryPerMonth.Name = "colSalaryPerMonth";
            this.colSalaryPerMonth.OptionsColumn.AllowEdit = false;
            this.colSalaryPerMonth.Visible = true;
            this.colSalaryPerMonth.VisibleIndex = 2;
            // 
            // colEmployeeType
            // 
            this.colEmployeeType.Caption = "Employee Type";
            this.colEmployeeType.ColumnEdit = this.repEmployeeType;
            this.colEmployeeType.FieldName = "EmployeeType";
            this.colEmployeeType.Name = "colEmployeeType";
            this.colEmployeeType.OptionsColumn.AllowEdit = false;
            this.colEmployeeType.Visible = true;
            this.colEmployeeType.VisibleIndex = 3;
            // 
            // repEmployeeType
            // 
            this.repEmployeeType.AutoHeight = false;
            this.repEmployeeType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repEmployeeType.Name = "repEmployeeType";
            // 
            // EmployeeListForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 467);
            this.Controls.Add(this.grdEmployees);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Name = "EmployeeListForm";
            this.Text = "EmployeeListForm";
            this.Load += new System.EventHandler(this.EmployeeListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repEmployeeType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPetShop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEmployees)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraGrid.GridControl grdEmployees;
        private DevExpress.XtraGrid.Views.Grid.GridView grvEmployees;
        private BindingSource bsPetShop;
        private BindingSource bsEmployees;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colSurname;
        private DevExpress.XtraGrid.Columns.GridColumn colSalaryPerMonth;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repEmployeeType;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeType;
    }
}
namespace Session_11
{
    partial class PetFoodListForm
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
            this.grdPetFoods = new DevExpress.XtraGrid.GridControl();
            this.grvPetFoods = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAnimalType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repAnimalTypes = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.bsPetShop = new System.Windows.Forms.BindingSource(this.components);
            this.bsPetFoods = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grdPetFoods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvPetFoods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repAnimalTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPetShop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPetFoods)).BeginInit();
            this.SuspendLayout();
            // 
            // grdPetFoods
            // 
            this.grdPetFoods.Location = new System.Drawing.Point(53, 25);
            this.grdPetFoods.MainView = this.grvPetFoods;
            this.grdPetFoods.Name = "grdPetFoods";
            this.grdPetFoods.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repAnimalTypes});
            this.grdPetFoods.Size = new System.Drawing.Size(712, 361);
            this.grdPetFoods.TabIndex = 0;
            this.grdPetFoods.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvPetFoods});
            // 
            // grvPetFoods
            // 
            this.grvPetFoods.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.White;
            this.grvPetFoods.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.White;
            this.grvPetFoods.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.White;
            this.grvPetFoods.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.grvPetFoods.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.grvPetFoods.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.grvPetFoods.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.grvPetFoods.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPrice,
            this.colCost,
            this.colAnimalType});
            this.grvPetFoods.GridControl = this.grdPetFoods;
            this.grvPetFoods.Name = "grvPetFoods";
            // 
            // colPrice
            // 
            this.colPrice.Caption = "colPrice";
            this.colPrice.FieldName = "Price";
            this.colPrice.Name = "colPrice";
            this.colPrice.OptionsColumn.AllowEdit = false;
            this.colPrice.Visible = true;
            this.colPrice.VisibleIndex = 0;
            // 
            // colCost
            // 
            this.colCost.Caption = "colCost";
            this.colCost.FieldName = "Cost";
            this.colCost.Name = "colCost";
            this.colCost.OptionsColumn.AllowEdit = false;
            this.colCost.Visible = true;
            this.colCost.VisibleIndex = 1;
            // 
            // colAnimalType
            // 
            this.colAnimalType.Caption = "Animal Type";
            this.colAnimalType.FieldName = "AnimalType";
            this.colAnimalType.Name = "colAnimalType";
            this.colAnimalType.OptionsColumn.AllowEdit = false;
            this.colAnimalType.Visible = true;
            this.colAnimalType.VisibleIndex = 2;
            // 
            // repAnimalTypes
            // 
            this.repAnimalTypes.AutoHeight = false;
            this.repAnimalTypes.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repAnimalTypes.Name = "repAnimalTypes";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(713, 429);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 43);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(621, 429);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(87, 43);
            this.btnNew.TabIndex = 6;
            this.btnNew.Text = "New";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(529, 429);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(87, 43);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Edit..";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(437, 429);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(87, 43);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // PetFoodListForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 493);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.grdPetFoods);
            this.Name = "PetFoodListForm";
            this.Text = "PetFoodListForm";
            this.Load += new System.EventHandler(this.PetFoodListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdPetFoods)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvPetFoods)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repAnimalTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPetShop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPetFoods)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdPetFoods;
        private DevExpress.XtraGrid.Views.Grid.GridView grvPetFoods;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraGrid.Columns.GridColumn colPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colCost;
        private BindingSource bsPetShop;
        private BindingSource bsPetFoods;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repAnimalTypes;
        private DevExpress.XtraGrid.Columns.GridColumn colAnimalType;
    }
}
namespace Session_11
{
    partial class TransactionNewForm
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
            this.ctrlCustomer = new DevExpress.XtraEditors.LookUpEdit();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.ctrlEmployee = new DevExpress.XtraEditors.LookUpEdit();
            this.lblPetID = new System.Windows.Forms.Label();
            this.ctrlPet = new DevExpress.XtraEditors.LookUpEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.ctrlPetPrice = new DevExpress.XtraEditors.SpinEdit();
            this.ctrlPetFoodQty = new DevExpress.XtraEditors.SpinEdit();
            this.PetPrice = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblPetFoodPrice = new System.Windows.Forms.Label();
            this.ctrlPetFoodPrice = new DevExpress.XtraEditors.SpinEdit();
            this.CustomerForm = new System.Windows.Forms.LinkLabel();
            this.bsPet = new System.Windows.Forms.BindingSource(this.components);
            this.bsPetShop = new System.Windows.Forms.BindingSource(this.components);
            this.btnSaveNewTrans = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelNewTrans = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.bsTransactions = new System.Windows.Forms.BindingSource(this.components);
            this.ctrlTotalPrice = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlCustomer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlEmployee.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlPet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlPetPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlPetFoodQty.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlPetFoodPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPetShop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlTotalPrice.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrlCustomer
            // 
            this.ctrlCustomer.Location = new System.Drawing.Point(343, 38);
            this.ctrlCustomer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ctrlCustomer.Name = "ctrlCustomer";
            this.ctrlCustomer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ctrlCustomer.Size = new System.Drawing.Size(169, 20);
            this.ctrlCustomer.TabIndex = 0;
            this.ctrlCustomer.ButtonPressed += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.ctrlCustomer_ButtonPressed);
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Location = new System.Drawing.Point(274, 41);
            this.lblCustomer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(59, 15);
            this.lblCustomer.TabIndex = 1;
            this.lblCustomer.Text = "Customer";
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Location = new System.Drawing.Point(274, 71);
            this.lblEmployee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(59, 15);
            this.lblEmployee.TabIndex = 3;
            this.lblEmployee.Text = "Employee";
            // 
            // ctrlEmployee
            // 
            this.ctrlEmployee.Location = new System.Drawing.Point(343, 68);
            this.ctrlEmployee.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ctrlEmployee.Name = "ctrlEmployee";
            this.ctrlEmployee.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ctrlEmployee.Size = new System.Drawing.Size(169, 20);
            this.ctrlEmployee.TabIndex = 2;
            // 
            // lblPetID
            // 
            this.lblPetID.AutoSize = true;
            this.lblPetID.Location = new System.Drawing.Point(309, 101);
            this.lblPetID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPetID.Name = "lblPetID";
            this.lblPetID.Size = new System.Drawing.Size(24, 15);
            this.lblPetID.TabIndex = 5;
            this.lblPetID.Text = "Pet";
            // 
            // ctrlPet
            // 
            this.ctrlPet.Location = new System.Drawing.Point(343, 98);
            this.ctrlPet.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ctrlPet.Name = "ctrlPet";
            this.ctrlPet.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ctrlPet.Size = new System.Drawing.Size(169, 20);
            this.ctrlPet.TabIndex = 4;
            this.ctrlPet.EditValueChanged += new System.EventHandler(this.ctrlPet_EditValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 19);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Pet Food Qty";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ctrlPetPrice
            // 
            this.ctrlPetPrice.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ctrlPetPrice.Location = new System.Drawing.Point(118, 76);
            this.ctrlPetPrice.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ctrlPetPrice.Name = "ctrlPetPrice";
            this.ctrlPetPrice.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ctrlPetPrice.Size = new System.Drawing.Size(117, 20);
            this.ctrlPetPrice.TabIndex = 9;
            // 
            // ctrlPetFoodQty
            // 
            this.ctrlPetFoodQty.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ctrlPetFoodQty.Location = new System.Drawing.Point(118, 16);
            this.ctrlPetFoodQty.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ctrlPetFoodQty.Name = "ctrlPetFoodQty";
            this.ctrlPetFoodQty.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ctrlPetFoodQty.Properties.Name = "ctrlPetFoodQty";
            this.ctrlPetFoodQty.Size = new System.Drawing.Size(117, 20);
            this.ctrlPetFoodQty.TabIndex = 10;
            this.ctrlPetFoodQty.EditValueChanged += new System.EventHandler(this.ctrlPetFoodQty_EditValueChanged);
            // 
            // PetPrice
            // 
            this.PetPrice.AutoSize = true;
            this.PetPrice.Location = new System.Drawing.Point(53, 79);
            this.PetPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PetPrice.Name = "PetPrice";
            this.PetPrice.Size = new System.Drawing.Size(53, 15);
            this.PetPrice.TabIndex = 12;
            this.PetPrice.Text = "Pet Price";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotal.Location = new System.Drawing.Point(134, 101);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(76, 18);
            this.lblTotal.TabIndex = 13;
            this.lblTotal.Text = "Total Price";
            // 
            // lblPetFoodPrice
            // 
            this.lblPetFoodPrice.AutoSize = true;
            this.lblPetFoodPrice.Location = new System.Drawing.Point(28, 49);
            this.lblPetFoodPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPetFoodPrice.Name = "lblPetFoodPrice";
            this.lblPetFoodPrice.Size = new System.Drawing.Size(83, 15);
            this.lblPetFoodPrice.TabIndex = 15;
            this.lblPetFoodPrice.Text = "Pet Food Price";
            // 
            // ctrlPetFoodPrice
            // 
            this.ctrlPetFoodPrice.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ctrlPetFoodPrice.Location = new System.Drawing.Point(118, 46);
            this.ctrlPetFoodPrice.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ctrlPetFoodPrice.Name = "ctrlPetFoodPrice";
            this.ctrlPetFoodPrice.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ctrlPetFoodPrice.Size = new System.Drawing.Size(117, 20);
            this.ctrlPetFoodPrice.TabIndex = 14;
            // 
            // CustomerForm
            // 
            this.CustomerForm.AutoSize = true;
            this.CustomerForm.Location = new System.Drawing.Point(343, 19);
            this.CustomerForm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CustomerForm.Name = "CustomerForm";
            this.CustomerForm.Size = new System.Drawing.Size(143, 15);
            this.CustomerForm.TabIndex = 17;
            this.CustomerForm.TabStop = true;
            this.CustomerForm.Text = "Can\'t Find The Customer?";
            this.CustomerForm.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AddNewCustomer);
            // 
            // btnSaveNewTrans
            // 
            this.btnSaveNewTrans.Location = new System.Drawing.Point(309, 124);
            this.btnSaveNewTrans.Name = "btnSaveNewTrans";
            this.btnSaveNewTrans.Size = new System.Drawing.Size(92, 41);
            this.btnSaveNewTrans.TabIndex = 19;
            this.btnSaveNewTrans.Text = "Save";
            this.btnSaveNewTrans.Click += new System.EventHandler(this.btnSaveNewTrans_Click);
            // 
            // btnCancelNewTrans
            // 
            this.btnCancelNewTrans.Location = new System.Drawing.Point(420, 124);
            this.btnCancelNewTrans.Name = "btnCancelNewTrans";
            this.btnCancelNewTrans.Size = new System.Drawing.Size(92, 41);
            this.btnCancelNewTrans.TabIndex = 20;
            this.btnCancelNewTrans.Text = "Exit";
            this.btnCancelNewTrans.Click += new System.EventHandler(this.btnCancelNewTrans_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(70, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "1 Free Bag of Food for Every Pet Sold!";
            // 
            // ctrlTotalPrice
            // 
            this.ctrlTotalPrice.Location = new System.Drawing.Point(118, 121);
            this.ctrlTotalPrice.Name = "ctrlTotalPrice";
            this.ctrlTotalPrice.Properties.ReadOnly = true;
            this.ctrlTotalPrice.Size = new System.Drawing.Size(117, 20);
            this.ctrlTotalPrice.TabIndex = 22;
            // 
            // TransactionNewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 174);
            this.Controls.Add(this.ctrlTotalPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelNewTrans);
            this.Controls.Add(this.btnSaveNewTrans);
            this.Controls.Add(this.CustomerForm);
            this.Controls.Add(this.lblPetFoodPrice);
            this.Controls.Add(this.ctrlPetFoodPrice);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.PetPrice);
            this.Controls.Add(this.ctrlPetFoodQty);
            this.Controls.Add(this.ctrlPetPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblPetID);
            this.Controls.Add(this.ctrlPet);
            this.Controls.Add(this.lblEmployee);
            this.Controls.Add(this.ctrlEmployee);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.ctrlCustomer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TransactionNewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Transaction";
            this.Load += new System.EventHandler(this.TransactionNewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ctrlCustomer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlEmployee.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlPet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlPetPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlPetFoodQty.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlPetFoodPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPetShop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlTotalPrice.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LookUpEdit ctrlCustomer;
        private Label lblCustomer;
        private Label lblEmployee;
        private DevExpress.XtraEditors.LookUpEdit ctrlEmployee;
        private Label lblPetID;
        private DevExpress.XtraEditors.LookUpEdit ctrlPet;
        private Label label4;
        private DevExpress.XtraEditors.SpinEdit ctrlPetPrice;
        private DevExpress.XtraEditors.SpinEdit ctrlPetFoodQty;
        private Label PetPrice;
        private Label lblTotal;
        private Label lblPetFoodPrice;
        private DevExpress.XtraEditors.SpinEdit ctrlPetFoodPrice;
        private LinkLabel CustomerForm;
        private BindingSource bsPet;
        private BindingSource bsPetShop;
        private DevExpress.XtraEditors.SimpleButton btnSaveNewTrans;
        private DevExpress.XtraEditors.SimpleButton btnCancelNewTrans;
        private Label label1;
        private BindingSource bsTransactions;
        private DevExpress.XtraEditors.TextEdit ctrlTotalPrice;
    }
}
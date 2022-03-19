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
            this.txtTotalPrice = new DevExpress.XtraEditors.TextEdit();
            this.CustomerForm = new System.Windows.Forms.LinkLabel();
            this.bsPetshop = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ctrlCustomer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlEmployee.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlPet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlPetPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlPetFoodQty.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlPetFoodPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPetshop)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrlCustomer
            // 
            this.ctrlCustomer.Location = new System.Drawing.Point(327, 37);
            this.ctrlCustomer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ctrlCustomer.Name = "ctrlCustomer";
            this.ctrlCustomer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ctrlCustomer.Size = new System.Drawing.Size(169, 20);
            this.ctrlCustomer.TabIndex = 0;
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Location = new System.Drawing.Point(258, 40);
            this.lblCustomer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(59, 15);
            this.lblCustomer.TabIndex = 1;
            this.lblCustomer.Text = "Customer";
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Location = new System.Drawing.Point(258, 70);
            this.lblEmployee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(59, 15);
            this.lblEmployee.TabIndex = 3;
            this.lblEmployee.Text = "Employee";
            // 
            // ctrlEmployee
            // 
            this.ctrlEmployee.Location = new System.Drawing.Point(327, 67);
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
            this.lblPetID.Location = new System.Drawing.Point(293, 100);
            this.lblPetID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPetID.Name = "lblPetID";
            this.lblPetID.Size = new System.Drawing.Size(24, 15);
            this.lblPetID.TabIndex = 5;
            this.lblPetID.Text = "Pet";
            // 
            // ctrlPet
            // 
            this.ctrlPet.Location = new System.Drawing.Point(327, 97);
            this.ctrlPet.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ctrlPet.Name = "ctrlPet";
            this.ctrlPet.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ctrlPet.Size = new System.Drawing.Size(169, 20);
            this.ctrlPet.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 40);
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
            this.ctrlPetPrice.Location = new System.Drawing.Point(124, 97);
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
            this.ctrlPetFoodQty.Location = new System.Drawing.Point(124, 37);
            this.ctrlPetFoodQty.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ctrlPetFoodQty.Name = "ctrlPetFoodQty";
            this.ctrlPetFoodQty.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ctrlPetFoodQty.Properties.Name = "ctrlPetFoodQty";
            this.ctrlPetFoodQty.Size = new System.Drawing.Size(117, 20);
            this.ctrlPetFoodQty.TabIndex = 10;
            // 
            // PetPrice
            // 
            this.PetPrice.AutoSize = true;
            this.PetPrice.Location = new System.Drawing.Point(59, 100);
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
            this.lblTotal.Location = new System.Drawing.Point(241, 125);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(41, 18);
            this.lblTotal.TabIndex = 13;
            this.lblTotal.Text = "Total";
            // 
            // lblPetFoodPrice
            // 
            this.lblPetFoodPrice.AutoSize = true;
            this.lblPetFoodPrice.Location = new System.Drawing.Point(34, 70);
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
            this.ctrlPetFoodPrice.Location = new System.Drawing.Point(124, 67);
            this.ctrlPetFoodPrice.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ctrlPetFoodPrice.Name = "ctrlPetFoodPrice";
            this.ctrlPetFoodPrice.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ctrlPetFoodPrice.Size = new System.Drawing.Size(117, 20);
            this.ctrlPetFoodPrice.TabIndex = 14;
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Location = new System.Drawing.Point(210, 149);
            this.txtTotalPrice.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(117, 20);
            this.txtTotalPrice.TabIndex = 16;
            // 
            // CustomerForm
            // 
            this.CustomerForm.AutoSize = true;
            this.CustomerForm.Location = new System.Drawing.Point(327, 18);
            this.CustomerForm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CustomerForm.Name = "CustomerForm";
            this.CustomerForm.Size = new System.Drawing.Size(143, 15);
            this.CustomerForm.TabIndex = 17;
            this.CustomerForm.TabStop = true;
            this.CustomerForm.Text = "Can\'t Find The Customer?";
            this.CustomerForm.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AddNewCustomer);
            // 
            // TransactionNewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 185);
            this.Controls.Add(this.CustomerForm);
            this.Controls.Add(this.txtTotalPrice);
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
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "TransactionNewForm";
            this.Text = "New Transaction";
            this.Load += new System.EventHandler(this.TransactionNewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ctrlCustomer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlEmployee.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlPet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlPetPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlPetFoodQty.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlPetFoodPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPetshop)).EndInit();
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
        private DevExpress.XtraEditors.TextEdit txtTotalPrice;
        private LinkLabel CustomerForm;
        private BindingSource bsPetshop;
    }
}
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
            this.ctrlCustomer = new DevExpress.XtraEditors.LookUpEdit();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.ctrlEmployee = new DevExpress.XtraEditors.LookUpEdit();
            this.lblPetID = new System.Windows.Forms.Label();
            this.ctrlPet = new DevExpress.XtraEditors.LookUpEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.spinEditPetPrice = new DevExpress.XtraEditors.SpinEdit();
            this.spinEditPetFoodQty = new DevExpress.XtraEditors.SpinEdit();
            this.PetPrice = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblPetFoodPrice = new System.Windows.Forms.Label();
            this.spinEditPetFoodPrice = new DevExpress.XtraEditors.SpinEdit();
            this.txtTotalPrice = new DevExpress.XtraEditors.TextEdit();
            this.CustomerForm = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlCustomer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlEmployee.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlPet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditPetPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditPetFoodQty.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditPetFoodPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalPrice.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrlCustomer
            // 
            this.ctrlCustomer.Location = new System.Drawing.Point(280, 32);
            this.ctrlCustomer.Name = "ctrlCustomer";
            this.ctrlCustomer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ctrlCustomer.Size = new System.Drawing.Size(145, 20);
            this.ctrlCustomer.TabIndex = 0;
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Location = new System.Drawing.Point(221, 35);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(53, 13);
            this.lblCustomer.TabIndex = 1;
            this.lblCustomer.Text = "Customer";
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Location = new System.Drawing.Point(221, 61);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(53, 13);
            this.lblEmployee.TabIndex = 3;
            this.lblEmployee.Text = "Employee";
            // 
            // ctrlEmployee
            // 
            this.ctrlEmployee.Location = new System.Drawing.Point(280, 58);
            this.ctrlEmployee.Name = "ctrlEmployee";
            this.ctrlEmployee.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ctrlEmployee.Size = new System.Drawing.Size(145, 20);
            this.ctrlEmployee.TabIndex = 2;
            // 
            // lblPetID
            // 
            this.lblPetID.AutoSize = true;
            this.lblPetID.Location = new System.Drawing.Point(251, 87);
            this.lblPetID.Name = "lblPetID";
            this.lblPetID.Size = new System.Drawing.Size(23, 13);
            this.lblPetID.TabIndex = 5;
            this.lblPetID.Text = "Pet";
            // 
            // ctrlPet
            // 
            this.ctrlPet.Location = new System.Drawing.Point(280, 84);
            this.ctrlPet.Name = "ctrlPet";
            this.ctrlPet.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ctrlPet.Size = new System.Drawing.Size(145, 20);
            this.ctrlPet.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Pet Food Qty";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // spinEditPetPrice
            // 
            this.spinEditPetPrice.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEditPetPrice.Location = new System.Drawing.Point(106, 84);
            this.spinEditPetPrice.Name = "spinEditPetPrice";
            this.spinEditPetPrice.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEditPetPrice.Size = new System.Drawing.Size(100, 20);
            this.spinEditPetPrice.TabIndex = 9;
            // 
            // spinEditPetFoodQty
            // 
            this.spinEditPetFoodQty.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEditPetFoodQty.Location = new System.Drawing.Point(106, 32);
            this.spinEditPetFoodQty.Name = "spinEditPetFoodQty";
            this.spinEditPetFoodQty.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEditPetFoodQty.Size = new System.Drawing.Size(100, 20);
            this.spinEditPetFoodQty.TabIndex = 10;
            // 
            // PetPrice
            // 
            this.PetPrice.AutoSize = true;
            this.PetPrice.Location = new System.Drawing.Point(51, 87);
            this.PetPrice.Name = "PetPrice";
            this.PetPrice.Size = new System.Drawing.Size(49, 13);
            this.PetPrice.TabIndex = 12;
            this.PetPrice.Text = "Pet Price";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotal.Location = new System.Drawing.Point(207, 108);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(41, 18);
            this.lblTotal.TabIndex = 13;
            this.lblTotal.Text = "Total";
            // 
            // lblPetFoodPrice
            // 
            this.lblPetFoodPrice.AutoSize = true;
            this.lblPetFoodPrice.Location = new System.Drawing.Point(29, 61);
            this.lblPetFoodPrice.Name = "lblPetFoodPrice";
            this.lblPetFoodPrice.Size = new System.Drawing.Size(76, 13);
            this.lblPetFoodPrice.TabIndex = 15;
            this.lblPetFoodPrice.Text = "Pet Food Price";
            // 
            // spinEditPetFoodPrice
            // 
            this.spinEditPetFoodPrice.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEditPetFoodPrice.Location = new System.Drawing.Point(106, 58);
            this.spinEditPetFoodPrice.Name = "spinEditPetFoodPrice";
            this.spinEditPetFoodPrice.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEditPetFoodPrice.Size = new System.Drawing.Size(100, 20);
            this.spinEditPetFoodPrice.TabIndex = 14;
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Location = new System.Drawing.Point(180, 129);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(100, 20);
            this.txtTotalPrice.TabIndex = 16;
            // 
            // CustomerForm
            // 
            this.CustomerForm.AutoSize = true;
            this.CustomerForm.Location = new System.Drawing.Point(280, 16);
            this.CustomerForm.Name = "CustomerForm";
            this.CustomerForm.Size = new System.Drawing.Size(130, 13);
            this.CustomerForm.TabIndex = 17;
            this.CustomerForm.TabStop = true;
            this.CustomerForm.Text = "Can\'t Find The Customer?";
            this.CustomerForm.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AddNewCustomer);
            // 
            // TransactionNewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 160);
            this.Controls.Add(this.CustomerForm);
            this.Controls.Add(this.txtTotalPrice);
            this.Controls.Add(this.lblPetFoodPrice);
            this.Controls.Add(this.spinEditPetFoodPrice);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.PetPrice);
            this.Controls.Add(this.spinEditPetFoodQty);
            this.Controls.Add(this.spinEditPetPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblPetID);
            this.Controls.Add(this.ctrlPet);
            this.Controls.Add(this.lblEmployee);
            this.Controls.Add(this.ctrlEmployee);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.ctrlCustomer);
            this.Name = "TransactionNewForm";
            this.Text = "New Transaction";
            this.Load += new System.EventHandler(this.TransactionNewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ctrlCustomer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlEmployee.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlPet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditPetPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditPetFoodQty.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditPetFoodPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalPrice.Properties)).EndInit();
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
        private DevExpress.XtraEditors.SpinEdit spinEditPetPrice;
        private DevExpress.XtraEditors.SpinEdit spinEditPetFoodQty;
        private Label PetPrice;
        private Label lblTotal;
        private Label lblPetFoodPrice;
        private DevExpress.XtraEditors.SpinEdit spinEditPetFoodPrice;
        private DevExpress.XtraEditors.TextEdit txtTotalPrice;
        private LinkLabel CustomerForm;
    }
}
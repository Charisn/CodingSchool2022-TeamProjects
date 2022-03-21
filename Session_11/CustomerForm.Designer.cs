namespace Session_11
{
    partial class CustomerForm
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
            this.ctrlTIN = new DevExpress.XtraEditors.TextEdit();
            this.ctrlPhone = new DevExpress.XtraEditors.TextEdit();
            this.ctrlSurName = new DevExpress.XtraEditors.TextEdit();
            this.ctrlName = new DevExpress.XtraEditors.TextEdit();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.bsCustomers = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlTIN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlSurName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.ctrlTIN);
            this.layoutControl1.Controls.Add(this.ctrlPhone);
            this.layoutControl1.Controls.Add(this.ctrlSurName);
            this.layoutControl1.Controls.Add(this.ctrlName);
            this.layoutControl1.Controls.Add(this.btnOK);
            this.layoutControl1.Controls.Add(this.btnCancel);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(526, 366);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // ctrlTIN
            // 
            this.ctrlTIN.Location = new System.Drawing.Point(66, 84);
            this.ctrlTIN.Name = "ctrlTIN";
            this.ctrlTIN.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.ctrlTIN.Properties.MaxLength = 9;
            this.ctrlTIN.Size = new System.Drawing.Size(448, 20);
            this.ctrlTIN.StyleController = this.layoutControl1;
            this.ctrlTIN.TabIndex = 11;
            // 
            // ctrlPhone
            // 
            this.ctrlPhone.Location = new System.Drawing.Point(66, 60);
            this.ctrlPhone.Name = "ctrlPhone";
            this.ctrlPhone.Properties.MaxLength = 10;
            this.ctrlPhone.Size = new System.Drawing.Size(448, 20);
            this.ctrlPhone.StyleController = this.layoutControl1;
            this.ctrlPhone.TabIndex = 10;
            // 
            // ctrlSurName
            // 
            this.ctrlSurName.Location = new System.Drawing.Point(66, 36);
            this.ctrlSurName.Name = "ctrlSurName";
            this.ctrlSurName.Size = new System.Drawing.Size(448, 20);
            this.ctrlSurName.StyleController = this.layoutControl1;
            this.ctrlSurName.TabIndex = 9;
            // 
            // ctrlName
            // 
            this.ctrlName.Location = new System.Drawing.Point(66, 12);
            this.ctrlName.Name = "ctrlName";
            this.ctrlName.Size = new System.Drawing.Size(448, 20);
            this.ctrlName.StyleController = this.layoutControl1;
            this.ctrlName.TabIndex = 8;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(263, 332);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(108, 22);
            this.btnOK.StyleController = this.layoutControl1;
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "Save";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(375, 332);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(139, 22);
            this.btnCancel.StyleController = this.layoutControl1;
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Root
            // 
            this.Root.AppearanceGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Root.AppearanceGroup.Options.UseBackColor = true;
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.emptySpaceItem2,
            this.layoutControlItem3,
            this.layoutControlItem6,
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(526, 366);
            this.Root.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 96);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(506, 224);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnCancel;
            this.layoutControlItem4.Location = new System.Drawing.Point(363, 320);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(143, 26);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btnOK;
            this.layoutControlItem5.Location = new System.Drawing.Point(251, 320);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(112, 26);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 320);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(251, 26);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.ctrlName;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(506, 24);
            this.layoutControlItem3.Text = "Name";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(42, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.ctrlSurName;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(506, 24);
            this.layoutControlItem6.Text = "Surname";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(42, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.ctrlPhone;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(506, 24);
            this.layoutControlItem1.Text = "Phone";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(42, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.ctrlTIN;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(506, 24);
            this.layoutControlItem2.Text = "TIN";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(42, 13);
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 366);
            this.Controls.Add(this.layoutControl1);
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ctrlTIN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlSurName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCustomers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private BindingSource bsCustomers;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraEditors.TextEdit ctrlSurName;
        private DevExpress.XtraEditors.TextEdit ctrlName;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraEditors.TextEdit ctrlTIN;
        private DevExpress.XtraEditors.TextEdit ctrlPhone;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    }
}
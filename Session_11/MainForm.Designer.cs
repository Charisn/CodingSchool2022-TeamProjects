namespace Session_11
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.petToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mamalsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.petFoodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainButtonManager = new System.Windows.Forms.Button();
            this.MainButtonExit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.SystemColors.Highlight;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.customerToolStripMenuItem,
            this.petToolStripMenuItem,
            this.petFoodToolStripMenuItem,
            this.employeeToolStripMenuItem});
            resources.ApplyResources(this.menuStrip2, "menuStrip2");
            this.menuStrip2.Name = "menuStrip2";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem1});
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            resources.ApplyResources(this.customerToolStripMenuItem, "customerToolStripMenuItem");
            this.customerToolStripMenuItem.Click += new System.EventHandler(this.MenuStripCustomer);
            // 
            // editToolStripMenuItem1
            // 
            this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            resources.ApplyResources(this.editToolStripMenuItem1, "editToolStripMenuItem1");
            // 
            // petToolStripMenuItem
            // 
            this.petToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mamalsToolStripMenuItem});
            this.petToolStripMenuItem.Name = "petToolStripMenuItem";
            resources.ApplyResources(this.petToolStripMenuItem, "petToolStripMenuItem");
            // 
            // mamalsToolStripMenuItem
            // 
            this.mamalsToolStripMenuItem.Name = "mamalsToolStripMenuItem";
            resources.ApplyResources(this.mamalsToolStripMenuItem, "mamalsToolStripMenuItem");
            this.mamalsToolStripMenuItem.Click += new System.EventHandler(this.Menu_PetClick);
            // 
            // petFoodToolStripMenuItem
            // 
            this.petFoodToolStripMenuItem.Name = "petFoodToolStripMenuItem";
            resources.ApplyResources(this.petFoodToolStripMenuItem, "petFoodToolStripMenuItem");
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem});
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            resources.ApplyResources(this.employeeToolStripMenuItem, "employeeToolStripMenuItem");
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            resources.ApplyResources(this.editToolStripMenuItem, "editToolStripMenuItem");
            this.editToolStripMenuItem.Click += new System.EventHandler(this.MenuStripEmployee);
            // 
            // MainButtonManager
            // 
            this.MainButtonManager.BackColor = System.Drawing.Color.LightSkyBlue;
            resources.ApplyResources(this.MainButtonManager, "MainButtonManager");
            this.MainButtonManager.Name = "MainButtonManager";
            this.MainButtonManager.UseVisualStyleBackColor = false;
            this.MainButtonManager.Click += new System.EventHandler(this.MainButtonManager_Click);
            // 
            // MainButtonExit
            // 
            this.MainButtonExit.BackColor = System.Drawing.Color.LightSkyBlue;
            resources.ApplyResources(this.MainButtonExit, "MainButtonExit");
            this.MainButtonExit.Name = "MainButtonExit";
            this.MainButtonExit.UseVisualStyleBackColor = false;
            this.MainButtonExit.Click += new System.EventHandler(this.MainButtonExit_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SkyBlue;
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Session_11.Properties.Resources.PetShop_Image;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MainButtonExit);
            this.Controls.Add(this.MainButtonManager);
            this.Controls.Add(this.menuStrip2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MenuStrip menuStrip2;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem customerToolStripMenuItem;
        private ToolStripMenuItem petToolStripMenuItem;
        private ToolStripMenuItem petFoodToolStripMenuItem;
        private ToolStripMenuItem employeeToolStripMenuItem;
        private ToolStripMenuItem mamalsToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem1;
        private Button MainButtonManager;
        private Button MainButtonExit;
        private Button button1;
    }
}
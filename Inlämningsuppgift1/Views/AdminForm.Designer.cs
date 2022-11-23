namespace Inlämningsuppgift1.Views
{
    partial class AdminForm
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
            this.cbSortAdminForm = new System.Windows.Forms.ComboBox();
            this.cbCategoryAdminForm = new System.Windows.Forms.ComboBox();
            this.listBoxAdminForm = new System.Windows.Forms.ListBox();
            this.txtAdminForm = new System.Windows.Forms.TextBox();
            this.LogOutAdminForm = new System.Windows.Forms.Button();
            this.lblCategoryAdminForm = new System.Windows.Forms.Label();
            this.lblPriceAdminForm = new System.Windows.Forms.Label();
            this.lblTitleAdminForm = new System.Windows.Forms.Label();
            this.lblDescriptionAdminForm = new System.Windows.Forms.Label();
            this.btnAddAdminForm = new System.Windows.Forms.Button();
            this.btnDeleteAdminForm = new System.Windows.Forms.Button();
            this.btnUpdateAdminForm = new System.Windows.Forms.Button();
            this.btnShowAdvAdminForm = new System.Windows.Forms.Button();
            this.txtPriceAdminForm = new System.Windows.Forms.TextBox();
            this.txtTitleAdminForm = new System.Windows.Forms.TextBox();
            this.txtDescriptionAdminForm = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cbSortAdminForm
            // 
            this.cbSortAdminForm.FormattingEnabled = true;
            this.cbSortAdminForm.Items.AddRange(new object[] {
            "Price: Low",
            "Price: High",
            "Date: New",
            "Date: Old"});
            this.cbSortAdminForm.Location = new System.Drawing.Point(620, 14);
            this.cbSortAdminForm.Name = "cbSortAdminForm";
            this.cbSortAdminForm.Size = new System.Drawing.Size(121, 28);
            this.cbSortAdminForm.TabIndex = 8;
            this.cbSortAdminForm.Text = "Sortera";
            this.cbSortAdminForm.SelectedIndexChanged += new System.EventHandler(this.cbSortAdminForm_SelectedIndexChanged);
            // 
            // cbCategoryAdminForm
            // 
            this.cbCategoryAdminForm.FormattingEnabled = true;
            this.cbCategoryAdminForm.Items.AddRange(new object[] {
            "Phone",
            "Computer",
            "Cars",
            "Clothes"});
            this.cbCategoryAdminForm.Location = new System.Drawing.Point(620, 61);
            this.cbCategoryAdminForm.Name = "cbCategoryAdminForm";
            this.cbCategoryAdminForm.Size = new System.Drawing.Size(121, 28);
            this.cbCategoryAdminForm.TabIndex = 7;
            this.cbCategoryAdminForm.Text = "Kategori";
            this.cbCategoryAdminForm.SelectedIndexChanged += new System.EventHandler(this.cbCategoryAdminForm_SelectedIndexChanged);
            // 
            // listBoxAdminForm
            // 
            this.listBoxAdminForm.FormattingEnabled = true;
            this.listBoxAdminForm.ItemHeight = 20;
            this.listBoxAdminForm.Location = new System.Drawing.Point(12, 61);
            this.listBoxAdminForm.Name = "listBoxAdminForm";
            this.listBoxAdminForm.Size = new System.Drawing.Size(587, 324);
            this.listBoxAdminForm.TabIndex = 6;
            this.listBoxAdminForm.DoubleClick += new System.EventHandler(this.listBoxAdminForm_DoubleClick);
            // 
            // txtAdminForm
            // 
            this.txtAdminForm.Location = new System.Drawing.Point(12, 14);
            this.txtAdminForm.Multiline = true;
            this.txtAdminForm.Name = "txtAdminForm";
            this.txtAdminForm.Size = new System.Drawing.Size(587, 32);
            this.txtAdminForm.TabIndex = 5;
            this.txtAdminForm.TextChanged += new System.EventHandler(this.txtAdminForm_TextChanged);
            // 
            // LogOutAdminForm
            // 
            this.LogOutAdminForm.Location = new System.Drawing.Point(620, 349);
            this.LogOutAdminForm.Name = "LogOutAdminForm";
            this.LogOutAdminForm.Size = new System.Drawing.Size(121, 36);
            this.LogOutAdminForm.TabIndex = 9;
            this.LogOutAdminForm.Text = "Logga ut";
            this.LogOutAdminForm.UseVisualStyleBackColor = true;
            this.LogOutAdminForm.Click += new System.EventHandler(this.LogOutAdminForm_Click);
            // 
            // lblCategoryAdminForm
            // 
            this.lblCategoryAdminForm.AutoSize = true;
            this.lblCategoryAdminForm.Location = new System.Drawing.Point(793, 248);
            this.lblCategoryAdminForm.Name = "lblCategoryAdminForm";
            this.lblCategoryAdminForm.Size = new System.Drawing.Size(68, 20);
            this.lblCategoryAdminForm.TabIndex = 23;
            this.lblCategoryAdminForm.Text = "Kategori";
            // 
            // lblPriceAdminForm
            // 
            this.lblPriceAdminForm.AutoSize = true;
            this.lblPriceAdminForm.Location = new System.Drawing.Point(793, 183);
            this.lblPriceAdminForm.Name = "lblPriceAdminForm";
            this.lblPriceAdminForm.Size = new System.Drawing.Size(35, 20);
            this.lblPriceAdminForm.TabIndex = 22;
            this.lblPriceAdminForm.Text = "Pris";
            // 
            // lblTitleAdminForm
            // 
            this.lblTitleAdminForm.AutoSize = true;
            this.lblTitleAdminForm.Location = new System.Drawing.Point(793, 120);
            this.lblTitleAdminForm.Name = "lblTitleAdminForm";
            this.lblTitleAdminForm.Size = new System.Drawing.Size(38, 20);
            this.lblTitleAdminForm.TabIndex = 21;
            this.lblTitleAdminForm.Text = "Titel";
            // 
            // lblDescriptionAdminForm
            // 
            this.lblDescriptionAdminForm.AutoSize = true;
            this.lblDescriptionAdminForm.Location = new System.Drawing.Point(793, 60);
            this.lblDescriptionAdminForm.Name = "lblDescriptionAdminForm";
            this.lblDescriptionAdminForm.Size = new System.Drawing.Size(90, 20);
            this.lblDescriptionAdminForm.TabIndex = 20;
            this.lblDescriptionAdminForm.Text = "Beskrivning";
            // 
            // btnAddAdminForm
            // 
            this.btnAddAdminForm.Location = new System.Drawing.Point(620, 292);
            this.btnAddAdminForm.Name = "btnAddAdminForm";
            this.btnAddAdminForm.Size = new System.Drawing.Size(121, 34);
            this.btnAddAdminForm.TabIndex = 19;
            this.btnAddAdminForm.Text = "Skapa";
            this.btnAddAdminForm.UseVisualStyleBackColor = true;
            this.btnAddAdminForm.Click += new System.EventHandler(this.btnAddAdminForm_Click);
            // 
            // btnDeleteAdminForm
            // 
            this.btnDeleteAdminForm.Location = new System.Drawing.Point(620, 232);
            this.btnDeleteAdminForm.Name = "btnDeleteAdminForm";
            this.btnDeleteAdminForm.Size = new System.Drawing.Size(121, 34);
            this.btnDeleteAdminForm.TabIndex = 18;
            this.btnDeleteAdminForm.Text = "Ta bort";
            this.btnDeleteAdminForm.UseVisualStyleBackColor = true;
            this.btnDeleteAdminForm.Click += new System.EventHandler(this.btnDeleteAdminForm_Click);
            // 
            // btnUpdateAdminForm
            // 
            this.btnUpdateAdminForm.Location = new System.Drawing.Point(620, 167);
            this.btnUpdateAdminForm.Name = "btnUpdateAdminForm";
            this.btnUpdateAdminForm.Size = new System.Drawing.Size(121, 34);
            this.btnUpdateAdminForm.TabIndex = 17;
            this.btnUpdateAdminForm.Text = "Uppdatera";
            this.btnUpdateAdminForm.UseVisualStyleBackColor = true;
            this.btnUpdateAdminForm.Click += new System.EventHandler(this.btnUpdateAdminForm_Click);
            // 
            // btnShowAdvAdminForm
            // 
            this.btnShowAdvAdminForm.Location = new System.Drawing.Point(620, 104);
            this.btnShowAdvAdminForm.Name = "btnShowAdvAdminForm";
            this.btnShowAdvAdminForm.Size = new System.Drawing.Size(121, 34);
            this.btnShowAdvAdminForm.TabIndex = 16;
            this.btnShowAdvAdminForm.Text = "Visa annonser";
            this.btnShowAdvAdminForm.UseVisualStyleBackColor = true;
            this.btnShowAdvAdminForm.Click += new System.EventHandler(this.btnShowAdvAdminForm_Click);
            // 
            // txtPriceAdminForm
            // 
            this.txtPriceAdminForm.Location = new System.Drawing.Point(797, 211);
            this.txtPriceAdminForm.Multiline = true;
            this.txtPriceAdminForm.Name = "txtPriceAdminForm";
            this.txtPriceAdminForm.Size = new System.Drawing.Size(256, 34);
            this.txtPriceAdminForm.TabIndex = 14;
            // 
            // txtTitleAdminForm
            // 
            this.txtTitleAdminForm.Location = new System.Drawing.Point(797, 146);
            this.txtTitleAdminForm.Multiline = true;
            this.txtTitleAdminForm.Name = "txtTitleAdminForm";
            this.txtTitleAdminForm.Size = new System.Drawing.Size(256, 34);
            this.txtTitleAdminForm.TabIndex = 13;
            // 
            // txtDescriptionAdminForm
            // 
            this.txtDescriptionAdminForm.Location = new System.Drawing.Point(797, 83);
            this.txtDescriptionAdminForm.Multiline = true;
            this.txtDescriptionAdminForm.Name = "txtDescriptionAdminForm";
            this.txtDescriptionAdminForm.Size = new System.Drawing.Size(256, 34);
            this.txtDescriptionAdminForm.TabIndex = 12;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Phone",
            "Computer",
            "Cars",
            "Clothes"});
            this.comboBox1.Location = new System.Drawing.Point(797, 271);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(256, 28);
            this.comboBox1.TabIndex = 24;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 397);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblCategoryAdminForm);
            this.Controls.Add(this.lblPriceAdminForm);
            this.Controls.Add(this.lblTitleAdminForm);
            this.Controls.Add(this.lblDescriptionAdminForm);
            this.Controls.Add(this.btnAddAdminForm);
            this.Controls.Add(this.btnDeleteAdminForm);
            this.Controls.Add(this.btnUpdateAdminForm);
            this.Controls.Add(this.btnShowAdvAdminForm);
            this.Controls.Add(this.txtPriceAdminForm);
            this.Controls.Add(this.txtTitleAdminForm);
            this.Controls.Add(this.txtDescriptionAdminForm);
            this.Controls.Add(this.LogOutAdminForm);
            this.Controls.Add(this.cbSortAdminForm);
            this.Controls.Add(this.cbCategoryAdminForm);
            this.Controls.Add(this.listBoxAdminForm);
            this.Controls.Add(this.txtAdminForm);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbSortAdminForm;
        private System.Windows.Forms.ComboBox cbCategoryAdminForm;
        private System.Windows.Forms.ListBox listBoxAdminForm;
        private System.Windows.Forms.TextBox txtAdminForm;
        private System.Windows.Forms.Button LogOutAdminForm;
        private System.Windows.Forms.Label lblCategoryAdminForm;
        private System.Windows.Forms.Label lblPriceAdminForm;
        private System.Windows.Forms.Label lblTitleAdminForm;
        private System.Windows.Forms.Label lblDescriptionAdminForm;
        private System.Windows.Forms.Button btnAddAdminForm;
        private System.Windows.Forms.Button btnDeleteAdminForm;
        private System.Windows.Forms.Button btnUpdateAdminForm;
        private System.Windows.Forms.Button btnShowAdvAdminForm;
        private System.Windows.Forms.TextBox txtPriceAdminForm;
        private System.Windows.Forms.TextBox txtTitleAdminForm;
        private System.Windows.Forms.TextBox txtDescriptionAdminForm;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
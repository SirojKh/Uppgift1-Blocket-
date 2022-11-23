namespace Inlämningsuppgift1.Views
{
    partial class StartForm
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
            this.txtStartForm = new System.Windows.Forms.TextBox();
            this.listBoxStartForm = new System.Windows.Forms.ListBox();
            this.cbCategoryStartForm = new System.Windows.Forms.ComboBox();
            this.cbSortStartForm = new System.Windows.Forms.ComboBox();
            this.lblLoggin = new System.Windows.Forms.Label();
            this.btnShowStartForm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtStartForm
            // 
            this.txtStartForm.Location = new System.Drawing.Point(12, 12);
            this.txtStartForm.Multiline = true;
            this.txtStartForm.Name = "txtStartForm";
            this.txtStartForm.Size = new System.Drawing.Size(587, 32);
            this.txtStartForm.TabIndex = 0;
            this.txtStartForm.TextChanged += new System.EventHandler(this.txtStartForm_TextChanged);
            // 
            // listBoxStartForm
            // 
            this.listBoxStartForm.FormattingEnabled = true;
            this.listBoxStartForm.ItemHeight = 20;
            this.listBoxStartForm.Location = new System.Drawing.Point(12, 59);
            this.listBoxStartForm.Name = "listBoxStartForm";
            this.listBoxStartForm.Size = new System.Drawing.Size(587, 324);
            this.listBoxStartForm.TabIndex = 1;
            this.listBoxStartForm.SelectedIndexChanged += new System.EventHandler(this.listBoxStartForm_SelectedIndexChanged);
            this.listBoxStartForm.DoubleClick += new System.EventHandler(this.listBoxStartForm_DoubleClick);
            // 
            // cbCategoryStartForm
            // 
            this.cbCategoryStartForm.FormattingEnabled = true;
            this.cbCategoryStartForm.Items.AddRange(new object[] {
            "Phone",
            "Computers",
            "Cars",
            "Clothes"});
            this.cbCategoryStartForm.Location = new System.Drawing.Point(620, 59);
            this.cbCategoryStartForm.Name = "cbCategoryStartForm";
            this.cbCategoryStartForm.Size = new System.Drawing.Size(121, 28);
            this.cbCategoryStartForm.TabIndex = 3;
            this.cbCategoryStartForm.Text = "Kategori";
            this.cbCategoryStartForm.SelectedIndexChanged += new System.EventHandler(this.cbCategoryStartForm_SelectedIndexChanged);
            // 
            // cbSortStartForm
            // 
            this.cbSortStartForm.FormattingEnabled = true;
            this.cbSortStartForm.Items.AddRange(new object[] {
            "Price: Low",
            "Price: High",
            "Date: New",
            "Date: Old"});
            this.cbSortStartForm.Location = new System.Drawing.Point(620, 12);
            this.cbSortStartForm.Name = "cbSortStartForm";
            this.cbSortStartForm.Size = new System.Drawing.Size(121, 28);
            this.cbSortStartForm.TabIndex = 4;
            this.cbSortStartForm.Text = "Sortera";
            this.cbSortStartForm.SelectedIndexChanged += new System.EventHandler(this.cbSortStartForm_SelectedIndexChanged);
            // 
            // lblLoggin
            // 
            this.lblLoggin.AutoSize = true;
            this.lblLoggin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoggin.Location = new System.Drawing.Point(638, 358);
            this.lblLoggin.Name = "lblLoggin";
            this.lblLoggin.Size = new System.Drawing.Size(87, 25);
            this.lblLoggin.TabIndex = 5;
            this.lblLoggin.Text = "Logga in";
            this.lblLoggin.DoubleClick += new System.EventHandler(this.lblLoggin_DoubleClick);
            // 
            // btnShowStartForm
            // 
            this.btnShowStartForm.Location = new System.Drawing.Point(620, 106);
            this.btnShowStartForm.Name = "btnShowStartForm";
            this.btnShowStartForm.Size = new System.Drawing.Size(121, 37);
            this.btnShowStartForm.TabIndex = 6;
            this.btnShowStartForm.Text = "Visa annonser";
            this.btnShowStartForm.UseVisualStyleBackColor = true;
            this.btnShowStartForm.Click += new System.EventHandler(this.btnShowStartForm_Click);
            // 
            // label1
            // 
            this.label1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(620, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 122);
            this.label1.TabIndex = 7;
            this.label1.Text = "OBS! Du kan endast söka och kolla på annonser!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 408);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnShowStartForm);
            this.Controls.Add(this.lblLoggin);
            this.Controls.Add(this.cbSortStartForm);
            this.Controls.Add(this.cbCategoryStartForm);
            this.Controls.Add(this.listBoxStartForm);
            this.Controls.Add(this.txtStartForm);
            this.Name = "StartForm";
            this.Text = "StartForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStartForm;
        private System.Windows.Forms.ListBox listBoxStartForm;
        private System.Windows.Forms.ComboBox cbCategoryStartForm;
        private System.Windows.Forms.ComboBox cbSortStartForm;
        private System.Windows.Forms.Label lblLoggin;
        private System.Windows.Forms.Button btnShowStartForm;
        private System.Windows.Forms.Label label1;
    }
}
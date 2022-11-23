namespace Inlämningsuppgift1.Views
{
    partial class LogForm
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
            this.lblRegLogForm = new System.Windows.Forms.Label();
            this.btnLoginLogForm = new System.Windows.Forms.Button();
            this.lblNameLogForm = new System.Windows.Forms.Label();
            this.lblPasswordLogForm = new System.Windows.Forms.Label();
            this.txtPasswordLogForm = new System.Windows.Forms.TextBox();
            this.txtNameLogForm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRegLogForm
            // 
            this.lblRegLogForm.AutoSize = true;
            this.lblRegLogForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegLogForm.Location = new System.Drawing.Point(111, 308);
            this.lblRegLogForm.Name = "lblRegLogForm";
            this.lblRegLogForm.Size = new System.Drawing.Size(176, 22);
            this.lblRegLogForm.TabIndex = 11;
            this.lblRegLogForm.Text = "Tryck för registrering";
            this.lblRegLogForm.DoubleClick += new System.EventHandler(this.lblRegLogForm_DoubleClick);
            // 
            // btnLoginLogForm
            // 
            this.btnLoginLogForm.Location = new System.Drawing.Point(148, 243);
            this.btnLoginLogForm.Name = "btnLoginLogForm";
            this.btnLoginLogForm.Size = new System.Drawing.Size(101, 35);
            this.btnLoginLogForm.TabIndex = 10;
            this.btnLoginLogForm.Text = "Logga in";
            this.btnLoginLogForm.UseVisualStyleBackColor = true;
            this.btnLoginLogForm.Click += new System.EventHandler(this.btnLoginLogForm_Click);
            // 
            // lblNameLogForm
            // 
            this.lblNameLogForm.AutoSize = true;
            this.lblNameLogForm.Location = new System.Drawing.Point(82, 88);
            this.lblNameLogForm.Name = "lblNameLogForm";
            this.lblNameLogForm.Size = new System.Drawing.Size(51, 20);
            this.lblNameLogForm.TabIndex = 9;
            this.lblNameLogForm.Text = "Namn";
            // 
            // lblPasswordLogForm
            // 
            this.lblPasswordLogForm.AutoSize = true;
            this.lblPasswordLogForm.Location = new System.Drawing.Point(82, 160);
            this.lblPasswordLogForm.Name = "lblPasswordLogForm";
            this.lblPasswordLogForm.Size = new System.Drawing.Size(76, 20);
            this.lblPasswordLogForm.TabIndex = 8;
            this.lblPasswordLogForm.Text = "Lösenord";
            // 
            // txtPasswordLogForm
            // 
            this.txtPasswordLogForm.Location = new System.Drawing.Point(86, 183);
            this.txtPasswordLogForm.Multiline = true;
            this.txtPasswordLogForm.Name = "txtPasswordLogForm";
            this.txtPasswordLogForm.Size = new System.Drawing.Size(238, 31);
            this.txtPasswordLogForm.TabIndex = 7;
            // 
            // txtNameLogForm
            // 
            this.txtNameLogForm.Location = new System.Drawing.Point(86, 111);
            this.txtNameLogForm.Multiline = true;
            this.txtNameLogForm.Name = "txtNameLogForm";
            this.txtNameLogForm.Size = new System.Drawing.Size(238, 31);
            this.txtNameLogForm.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 350);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 22);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tryck för att fortsätta som gäst";
            this.label1.DoubleClick += new System.EventHandler(this.label1_DoubleClick);
            // 
            // LogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 452);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRegLogForm);
            this.Controls.Add(this.btnLoginLogForm);
            this.Controls.Add(this.lblNameLogForm);
            this.Controls.Add(this.lblPasswordLogForm);
            this.Controls.Add(this.txtPasswordLogForm);
            this.Controls.Add(this.txtNameLogForm);
            this.Name = "LogForm";
            this.Text = "LogForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRegLogForm;
        private System.Windows.Forms.Button btnLoginLogForm;
        private System.Windows.Forms.Label lblNameLogForm;
        private System.Windows.Forms.Label lblPasswordLogForm;
        private System.Windows.Forms.TextBox txtPasswordLogForm;
        private System.Windows.Forms.TextBox txtNameLogForm;
        private System.Windows.Forms.Label label1;
    }
}
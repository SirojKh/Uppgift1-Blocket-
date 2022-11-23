namespace Inlämningsuppgift1.Views
{
    partial class RegForm
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
            this.btnLoginRegForm = new System.Windows.Forms.Button();
            this.lblNameRegForm = new System.Windows.Forms.Label();
            this.lblPasswordRegForm = new System.Windows.Forms.Label();
            this.txtPasswordRegForm = new System.Windows.Forms.TextBox();
            this.txtNameRegForm = new System.Windows.Forms.TextBox();
            this.txtPassword2RegForm = new System.Windows.Forms.TextBox();
            this.lblPassword2RegForm = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLoginRegForm
            // 
            this.btnLoginRegForm.Location = new System.Drawing.Point(90, 267);
            this.btnLoginRegForm.Name = "btnLoginRegForm";
            this.btnLoginRegForm.Size = new System.Drawing.Size(101, 35);
            this.btnLoginRegForm.TabIndex = 9;
            this.btnLoginRegForm.Text = "Registrera";
            this.btnLoginRegForm.UseVisualStyleBackColor = true;
            this.btnLoginRegForm.Click += new System.EventHandler(this.btnLoginRegForm_Click);
            // 
            // lblNameRegForm
            // 
            this.lblNameRegForm.AutoSize = true;
            this.lblNameRegForm.Location = new System.Drawing.Point(25, 42);
            this.lblNameRegForm.Name = "lblNameRegForm";
            this.lblNameRegForm.Size = new System.Drawing.Size(51, 20);
            this.lblNameRegForm.TabIndex = 8;
            this.lblNameRegForm.Text = "Namn";
            // 
            // lblPasswordRegForm
            // 
            this.lblPasswordRegForm.AutoSize = true;
            this.lblPasswordRegForm.Location = new System.Drawing.Point(25, 114);
            this.lblPasswordRegForm.Name = "lblPasswordRegForm";
            this.lblPasswordRegForm.Size = new System.Drawing.Size(76, 20);
            this.lblPasswordRegForm.TabIndex = 7;
            this.lblPasswordRegForm.Text = "Lösenord";
            // 
            // txtPasswordRegForm
            // 
            this.txtPasswordRegForm.Location = new System.Drawing.Point(29, 137);
            this.txtPasswordRegForm.Multiline = true;
            this.txtPasswordRegForm.Name = "txtPasswordRegForm";
            this.txtPasswordRegForm.Size = new System.Drawing.Size(238, 31);
            this.txtPasswordRegForm.TabIndex = 6;
            // 
            // txtNameRegForm
            // 
            this.txtNameRegForm.Location = new System.Drawing.Point(29, 65);
            this.txtNameRegForm.Multiline = true;
            this.txtNameRegForm.Name = "txtNameRegForm";
            this.txtNameRegForm.Size = new System.Drawing.Size(238, 31);
            this.txtNameRegForm.TabIndex = 5;
            // 
            // txtPassword2RegForm
            // 
            this.txtPassword2RegForm.Location = new System.Drawing.Point(29, 211);
            this.txtPassword2RegForm.Multiline = true;
            this.txtPassword2RegForm.Name = "txtPassword2RegForm";
            this.txtPassword2RegForm.Size = new System.Drawing.Size(238, 31);
            this.txtPassword2RegForm.TabIndex = 10;
            // 
            // lblPassword2RegForm
            // 
            this.lblPassword2RegForm.AutoSize = true;
            this.lblPassword2RegForm.Location = new System.Drawing.Point(25, 188);
            this.lblPassword2RegForm.Name = "lblPassword2RegForm";
            this.lblPassword2RegForm.Size = new System.Drawing.Size(76, 20);
            this.lblPassword2RegForm.TabIndex = 11;
            this.lblPassword2RegForm.Text = "Lösenord";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 331);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tryck här för att backa";
            this.label1.DoubleClick += new System.EventHandler(this.label1_DoubleClick);
            // 
            // RegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 384);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPassword2RegForm);
            this.Controls.Add(this.txtPassword2RegForm);
            this.Controls.Add(this.btnLoginRegForm);
            this.Controls.Add(this.lblNameRegForm);
            this.Controls.Add(this.lblPasswordRegForm);
            this.Controls.Add(this.txtPasswordRegForm);
            this.Controls.Add(this.txtNameRegForm);
            this.Name = "RegForm";
            this.Text = "RegForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoginRegForm;
        private System.Windows.Forms.Label lblNameRegForm;
        private System.Windows.Forms.Label lblPasswordRegForm;
        private System.Windows.Forms.TextBox txtPasswordRegForm;
        private System.Windows.Forms.TextBox txtNameRegForm;
        private System.Windows.Forms.TextBox txtPassword2RegForm;
        private System.Windows.Forms.Label lblPassword2RegForm;
        private System.Windows.Forms.Label label1;
    }
}
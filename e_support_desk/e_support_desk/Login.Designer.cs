
namespace e_support_desk
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.fjalekalimi = new System.Windows.Forms.TextBox();
            this.btn_hyr = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "HYR NE SISTEM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fjalekalim";
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(143, 129);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(245, 26);
            this.email.TabIndex = 3;
            // 
            // fjalekalimi
            // 
            this.fjalekalimi.Location = new System.Drawing.Point(143, 174);
            this.fjalekalimi.Name = "fjalekalimi";
            this.fjalekalimi.PasswordChar = '*';
            this.fjalekalimi.Size = new System.Drawing.Size(245, 26);
            this.fjalekalimi.TabIndex = 4;
            // 
            // btn_hyr
            // 
            this.btn_hyr.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_hyr.Location = new System.Drawing.Point(176, 233);
            this.btn_hyr.Name = "btn_hyr";
            this.btn_hyr.Size = new System.Drawing.Size(146, 40);
            this.btn_hyr.TabIndex = 5;
            this.btn_hyr.Text = "Hyr";
            this.btn_hyr.UseVisualStyleBackColor = false;
            this.btn_hyr.Click += new System.EventHandler(this.btn_hyr_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_hyr);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.fjalekalimi);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.email);
            this.panel1.Location = new System.Drawing.Point(391, 138);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(481, 324);
            this.panel1.TabIndex = 7;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 678);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hyr";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox fjalekalimi;
        private System.Windows.Forms.Button btn_hyr;
        private System.Windows.Forms.Panel panel1;
    }
}


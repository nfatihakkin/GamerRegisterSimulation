
namespace GamerRegisterSimulation
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.UsernameLbl = new System.Windows.Forms.Label();
            this.Password1Lbl = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConfirm = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdentityNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBirthYear = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(471, 615);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(278, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "REGISTER";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtUsername.Location = new System.Drawing.Point(573, 143);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(176, 31);
            this.txtUsername.TabIndex = 1;
            // 
            // UsernameLbl
            // 
            this.UsernameLbl.AutoSize = true;
            this.UsernameLbl.BackColor = System.Drawing.Color.Transparent;
            this.UsernameLbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.UsernameLbl.Location = new System.Drawing.Point(469, 146);
            this.UsernameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UsernameLbl.Name = "UsernameLbl";
            this.UsernameLbl.Size = new System.Drawing.Size(96, 28);
            this.UsernameLbl.TabIndex = 2;
            this.UsernameLbl.Text = "Username:";
            // 
            // Password1Lbl
            // 
            this.Password1Lbl.AutoSize = true;
            this.Password1Lbl.BackColor = System.Drawing.Color.Transparent;
            this.Password1Lbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Password1Lbl.Location = new System.Drawing.Point(469, 236);
            this.Password1Lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Password1Lbl.Name = "Password1Lbl";
            this.Password1Lbl.Size = new System.Drawing.Size(94, 28);
            this.Password1Lbl.TabIndex = 4;
            this.Password1Lbl.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtPassword.Location = new System.Drawing.Point(573, 233);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(176, 31);
            this.txtPassword.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(471, 301);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 56);
            this.label1.TabIndex = 6;
            this.label1.Text = "Confirm \r\nPassword:";
            // 
            // txtConfirm
            // 
            this.txtConfirm.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtConfirm.Location = new System.Drawing.Point(573, 325);
            this.txtConfirm.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.Size = new System.Drawing.Size(176, 31);
            this.txtConfirm.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(471, 399);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 56);
            this.label2.TabIndex = 8;
            this.label2.Text = "Identity\r\nNumber:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtIdentityNumber
            // 
            this.txtIdentityNumber.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtIdentityNumber.Location = new System.Drawing.Point(573, 423);
            this.txtIdentityNumber.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtIdentityNumber.Name = "txtIdentityNumber";
            this.txtIdentityNumber.Size = new System.Drawing.Size(176, 31);
            this.txtIdentityNumber.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(471, 512);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 28);
            this.label3.TabIndex = 10;
            this.label3.Text = "Birth Year:";
            // 
            // txtBirthYear
            // 
            this.txtBirthYear.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtBirthYear.Location = new System.Drawing.Point(573, 512);
            this.txtBirthYear.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtBirthYear.Name = "txtBirthYear";
            this.txtBirthYear.Size = new System.Drawing.Size(176, 31);
            this.txtBirthYear.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBirthYear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdentityNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtConfirm);
            this.Controls.Add(this.Password1Lbl);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.UsernameLbl);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gamer Register Simulation";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label UsernameLbl;
        private System.Windows.Forms.Label Password1Lbl;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConfirm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdentityNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBirthYear;
    }
}


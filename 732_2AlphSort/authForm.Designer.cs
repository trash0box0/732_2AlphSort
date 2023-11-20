namespace _732_2AlphSort
{
    partial class authForm
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
            this.authLoginTB = new System.Windows.Forms.TextBox();
            this.authPwdTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.authLoginB = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.authGoReg = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // authLoginTB
            // 
            this.authLoginTB.Location = new System.Drawing.Point(22, 54);
            this.authLoginTB.Name = "authLoginTB";
            this.authLoginTB.Size = new System.Drawing.Size(671, 31);
            this.authLoginTB.TabIndex = 0;
            // 
            // authPwdTB
            // 
            this.authPwdTB.Location = new System.Drawing.Point(22, 136);
            this.authPwdTB.Name = "authPwdTB";
            this.authPwdTB.PasswordChar = '*';
            this.authPwdTB.Size = new System.Drawing.Size(671, 31);
            this.authPwdTB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Пароль";
            // 
            // authLoginB
            // 
            this.authLoginB.Location = new System.Drawing.Point(25, 188);
            this.authLoginB.Name = "authLoginB";
            this.authLoginB.Size = new System.Drawing.Size(112, 34);
            this.authLoginB.TabIndex = 4;
            this.authLoginB.Text = "Войти";
            this.authLoginB.UseVisualStyleBackColor = true;
            this.authLoginB.Click += new System.EventHandler(this.authLoginB_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(329, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Нет учетной записи?";
            // 
            // authGoReg
            // 
            this.authGoReg.AutoSize = true;
            this.authGoReg.Location = new System.Drawing.Point(515, 193);
            this.authGoReg.Name = "authGoReg";
            this.authGoReg.Size = new System.Drawing.Size(178, 25);
            this.authGoReg.TabIndex = 6;
            this.authGoReg.TabStop = true;
            this.authGoReg.Text = "Зарегистрироваться";
            this.authGoReg.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.authGoReg_LinkClicked);
            // 
            // authForm
            // 
            this.AcceptButton = this.authLoginB;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 251);
            this.Controls.Add(this.authGoReg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.authLoginB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.authPwdTB);
            this.Controls.Add(this.authLoginTB);
            this.Name = "authForm";
            this.Text = "Аутентификация";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.authForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox authLoginTB;
        private TextBox authPwdTB;
        private Label label1;
        private Label label2;
        private Button authLoginB;
        private Label label3;
        private LinkLabel authGoReg;
    }
}
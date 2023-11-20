namespace _732_2AlphSort
{
    partial class regForm
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
            this.regLoginTB = new System.Windows.Forms.TextBox();
            this.regPwd1TB = new System.Windows.Forms.TextBox();
            this.regPwd2TB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.regButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // regLoginTB
            // 
            this.regLoginTB.Location = new System.Drawing.Point(23, 49);
            this.regLoginTB.Name = "regLoginTB";
            this.regLoginTB.Size = new System.Drawing.Size(672, 31);
            this.regLoginTB.TabIndex = 0;
            // 
            // regPwd1TB
            // 
            this.regPwd1TB.Location = new System.Drawing.Point(23, 129);
            this.regPwd1TB.Name = "regPwd1TB";
            this.regPwd1TB.Size = new System.Drawing.Size(672, 31);
            this.regPwd1TB.TabIndex = 1;
            // 
            // regPwd2TB
            // 
            this.regPwd2TB.Location = new System.Drawing.Point(23, 209);
            this.regPwd2TB.Name = "regPwd2TB";
            this.regPwd2TB.Size = new System.Drawing.Size(672, 31);
            this.regPwd2TB.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Новый логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Пароль";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Повторить пароль";
            // 
            // regButton
            // 
            this.regButton.Location = new System.Drawing.Point(28, 270);
            this.regButton.Name = "regButton";
            this.regButton.Size = new System.Drawing.Size(232, 34);
            this.regButton.TabIndex = 6;
            this.regButton.Text = "Зарегистрироваться";
            this.regButton.UseVisualStyleBackColor = true;
            this.regButton.Click += new System.EventHandler(this.regButton_Click);
            // 
            // regForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 314);
            this.Controls.Add(this.regButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.regPwd2TB);
            this.Controls.Add(this.regPwd1TB);
            this.Controls.Add(this.regLoginTB);
            this.Name = "regForm";
            this.Text = "Регистрация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox regLoginTB;
        private TextBox regPwd1TB;
        private TextBox regPwd2TB;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button regButton;
    }
}
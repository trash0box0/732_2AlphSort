namespace _732_2AlphSort
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
            this.Input = new System.Windows.Forms.TextBox();
            this.MakeSort = new System.Windows.Forms.Button();
            this.Output = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(68, 37);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(648, 31);
            this.Input.TabIndex = 0;
            // 
            // MakeSort
            // 
            this.MakeSort.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MakeSort.Location = new System.Drawing.Point(69, 285);
            this.MakeSort.Name = "MakeSort";
            this.MakeSort.Size = new System.Drawing.Size(647, 136);
            this.MakeSort.TabIndex = 1;
            this.MakeSort.Text = "Отсортировать";
            this.MakeSort.UseVisualStyleBackColor = true;
            this.MakeSort.Click += new System.EventHandler(this.MakeSort_Click);
            // 
            // Output
            // 
            this.Output.AutoSize = true;
            this.Output.Location = new System.Drawing.Point(254, 178);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(256, 25);
            this.Output.TabIndex = 2;
            this.Output.Text = "Тут могла быть ваша реклама";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.MakeSort);
            this.Controls.Add(this.Input);
            this.Name = "MainForm";
            this.Text = "Алфавитная сортировка";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox Input;
        private Button MakeSort;
        private Label Output;
    }
}
namespace _6_22
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.SourceString_TB = new System.Windows.Forms.TextBox();
            this.SourceString_L = new System.Windows.Forms.Label();
            this.Result_TB = new System.Windows.Forms.TextBox();
            this.Result_L = new System.Windows.Forms.Label();
            this.Calculate_B = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SourceString_TB
            // 
            this.SourceString_TB.Location = new System.Drawing.Point(17, 40);
            this.SourceString_TB.Margin = new System.Windows.Forms.Padding(5);
            this.SourceString_TB.Name = "SourceString_TB";
            this.SourceString_TB.Size = new System.Drawing.Size(302, 20);
            this.SourceString_TB.TabIndex = 58;
            // 
            // SourceString_L
            // 
            this.SourceString_L.AutoSize = true;
            this.SourceString_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SourceString_L.Location = new System.Drawing.Point(14, 14);
            this.SourceString_L.Margin = new System.Windows.Forms.Padding(5);
            this.SourceString_L.Name = "SourceString_L";
            this.SourceString_L.Size = new System.Drawing.Size(85, 16);
            this.SourceString_L.TabIndex = 57;
            this.SourceString_L.Text = "&Source string";
            // 
            // Result_TB
            // 
            this.Result_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Result_TB.Location = new System.Drawing.Point(158, 96);
            this.Result_TB.Margin = new System.Windows.Forms.Padding(20);
            this.Result_TB.Name = "Result_TB";
            this.Result_TB.ReadOnly = true;
            this.Result_TB.Size = new System.Drawing.Size(161, 22);
            this.Result_TB.TabIndex = 64;
            this.Result_TB.TabStop = false;
            // 
            // Result_L
            // 
            this.Result_L.AutoSize = true;
            this.Result_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Result_L.Location = new System.Drawing.Point(155, 73);
            this.Result_L.Margin = new System.Windows.Forms.Padding(20, 20, 20, 8);
            this.Result_L.Name = "Result_L";
            this.Result_L.Size = new System.Drawing.Size(45, 16);
            this.Result_L.TabIndex = 63;
            this.Result_L.Text = "Result";
            // 
            // Calculate_B
            // 
            this.Calculate_B.Location = new System.Drawing.Point(17, 73);
            this.Calculate_B.Margin = new System.Windows.Forms.Padding(5);
            this.Calculate_B.Name = "Calculate_B";
            this.Calculate_B.Size = new System.Drawing.Size(116, 45);
            this.Calculate_B.TabIndex = 62;
            this.Calculate_B.Text = "&Calculate";
            this.Calculate_B.UseVisualStyleBackColor = true;
            this.Calculate_B.Click += new System.EventHandler(this.Calculate_B_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 142);
            this.Controls.Add(this.Result_TB);
            this.Controls.Add(this.Result_L);
            this.Controls.Add(this.Calculate_B);
            this.Controls.Add(this.SourceString_TB);
            this.Controls.Add(this.SourceString_L);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Task 6-22";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SourceString_TB;
        private System.Windows.Forms.Label SourceString_L;
        private System.Windows.Forms.TextBox Result_TB;
        private System.Windows.Forms.Label Result_L;
        private System.Windows.Forms.Button Calculate_B;
    }
}


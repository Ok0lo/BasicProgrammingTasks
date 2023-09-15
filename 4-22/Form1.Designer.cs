namespace _4_22 {
    partial class Form1 {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            this.CalculatedArray_L = new System.Windows.Forms.Label();
            this.CalculatedArray_TB = new System.Windows.Forms.TextBox();
            this.Array_L = new System.Windows.Forms.Label();
            this.Array_TB = new System.Windows.Forms.TextBox();
            this.Calculate1_B = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CalculatedArray_L
            // 
            this.CalculatedArray_L.AutoSize = true;
            this.CalculatedArray_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CalculatedArray_L.Location = new System.Drawing.Point(174, 14);
            this.CalculatedArray_L.Margin = new System.Windows.Forms.Padding(5);
            this.CalculatedArray_L.Name = "CalculatedArray_L";
            this.CalculatedArray_L.Size = new System.Drawing.Size(106, 16);
            this.CalculatedArray_L.TabIndex = 58;
            this.CalculatedArray_L.Text = "Calculated A&rray";
            // 
            // CalculatedArray_TB
            // 
            this.CalculatedArray_TB.Location = new System.Drawing.Point(177, 40);
            this.CalculatedArray_TB.Margin = new System.Windows.Forms.Padding(5);
            this.CalculatedArray_TB.Multiline = true;
            this.CalculatedArray_TB.Name = "CalculatedArray_TB";
            this.CalculatedArray_TB.ReadOnly = true;
            this.CalculatedArray_TB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.CalculatedArray_TB.Size = new System.Drawing.Size(141, 155);
            this.CalculatedArray_TB.TabIndex = 57;
            // 
            // Array_L
            // 
            this.Array_L.AutoSize = true;
            this.Array_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Array_L.Location = new System.Drawing.Point(14, 14);
            this.Array_L.Margin = new System.Windows.Forms.Padding(5);
            this.Array_L.Name = "Array_L";
            this.Array_L.Size = new System.Drawing.Size(39, 16);
            this.Array_L.TabIndex = 56;
            this.Array_L.Text = "&Array";
            // 
            // Array_TB
            // 
            this.Array_TB.Location = new System.Drawing.Point(17, 40);
            this.Array_TB.Margin = new System.Windows.Forms.Padding(5);
            this.Array_TB.Multiline = true;
            this.Array_TB.Name = "Array_TB";
            this.Array_TB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Array_TB.Size = new System.Drawing.Size(141, 155);
            this.Array_TB.TabIndex = 54;
            // 
            // Calculate1_B
            // 
            this.Calculate1_B.Location = new System.Drawing.Point(17, 208);
            this.Calculate1_B.Margin = new System.Windows.Forms.Padding(5);
            this.Calculate1_B.Name = "Calculate1_B";
            this.Calculate1_B.Size = new System.Drawing.Size(116, 38);
            this.Calculate1_B.TabIndex = 55;
            this.Calculate1_B.Text = "&Calculate";
            this.Calculate1_B.UseVisualStyleBackColor = true;
            this.Calculate1_B.Click += new System.EventHandler(this.Calculate1_B_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 263);
            this.Controls.Add(this.CalculatedArray_L);
            this.Controls.Add(this.CalculatedArray_TB);
            this.Controls.Add(this.Array_L);
            this.Controls.Add(this.Array_TB);
            this.Controls.Add(this.Calculate1_B);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Task 4-22";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CalculatedArray_L;
        private System.Windows.Forms.TextBox CalculatedArray_TB;
        private System.Windows.Forms.Label Array_L;
        private System.Windows.Forms.TextBox Array_TB;
        private System.Windows.Forms.Button Calculate1_B;
    }
}


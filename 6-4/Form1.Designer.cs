namespace Task_6_4
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
            this.SourceStringArray_L = new System.Windows.Forms.Label();
            this.SourceStringArray_TB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TargetXXPart_TB = new System.Windows.Forms.TextBox();
            this.TargetXXPart_L = new System.Windows.Forms.Label();
            this.Result_TB = new System.Windows.Forms.TextBox();
            this.Result_L = new System.Windows.Forms.Label();
            this.Calculate_B = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SourceStringArray_L
            // 
            this.SourceStringArray_L.AutoSize = true;
            this.SourceStringArray_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SourceStringArray_L.Location = new System.Drawing.Point(14, 14);
            this.SourceStringArray_L.Margin = new System.Windows.Forms.Padding(5);
            this.SourceStringArray_L.Name = "SourceStringArray_L";
            this.SourceStringArray_L.Size = new System.Drawing.Size(119, 16);
            this.SourceStringArray_L.TabIndex = 57;
            this.SourceStringArray_L.Text = "&Source string array";
            // 
            // SourceStringArray_TB
            // 
            this.SourceStringArray_TB.Location = new System.Drawing.Point(17, 40);
            this.SourceStringArray_TB.Margin = new System.Windows.Forms.Padding(5);
            this.SourceStringArray_TB.Multiline = true;
            this.SourceStringArray_TB.Name = "SourceStringArray_TB";
            this.SourceStringArray_TB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.SourceStringArray_TB.Size = new System.Drawing.Size(138, 155);
            this.SourceStringArray_TB.TabIndex = 58;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 39);
            this.label1.TabIndex = 68;
            this.label1.Text = "*Required source format:\r\nXX-YY\r\nwhere X is char, Y is number";
            // 
            // TargetXXPart_TB
            // 
            this.TargetXXPart_TB.Location = new System.Drawing.Point(165, 40);
            this.TargetXXPart_TB.Margin = new System.Windows.Forms.Padding(5);
            this.TargetXXPart_TB.Name = "TargetXXPart_TB";
            this.TargetXXPart_TB.Size = new System.Drawing.Size(102, 20);
            this.TargetXXPart_TB.TabIndex = 70;
            // 
            // TargetXXPart_L
            // 
            this.TargetXXPart_L.AutoSize = true;
            this.TargetXXPart_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TargetXXPart_L.Location = new System.Drawing.Point(162, 14);
            this.TargetXXPart_L.Margin = new System.Windows.Forms.Padding(5);
            this.TargetXXPart_L.Name = "TargetXXPart_L";
            this.TargetXXPart_L.Size = new System.Drawing.Size(92, 16);
            this.TargetXXPart_L.TabIndex = 69;
            this.TargetXXPart_L.Text = "&Target XX part";
            // 
            // Result_TB
            // 
            this.Result_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Result_TB.Location = new System.Drawing.Point(165, 173);
            this.Result_TB.Margin = new System.Windows.Forms.Padding(20);
            this.Result_TB.Name = "Result_TB";
            this.Result_TB.ReadOnly = true;
            this.Result_TB.Size = new System.Drawing.Size(102, 22);
            this.Result_TB.TabIndex = 72;
            this.Result_TB.TabStop = false;
            // 
            // Result_L
            // 
            this.Result_L.AutoSize = true;
            this.Result_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Result_L.Location = new System.Drawing.Point(162, 151);
            this.Result_L.Margin = new System.Windows.Forms.Padding(20, 20, 20, 8);
            this.Result_L.Name = "Result_L";
            this.Result_L.Size = new System.Drawing.Size(45, 16);
            this.Result_L.TabIndex = 71;
            this.Result_L.Text = "Result";
            // 
            // Calculate_B
            // 
            this.Calculate_B.Location = new System.Drawing.Point(165, 70);
            this.Calculate_B.Margin = new System.Windows.Forms.Padding(5);
            this.Calculate_B.Name = "Calculate_B";
            this.Calculate_B.Size = new System.Drawing.Size(102, 38);
            this.Calculate_B.TabIndex = 73;
            this.Calculate_B.Text = "&Calculate";
            this.Calculate_B.UseVisualStyleBackColor = true;
            this.Calculate_B.Click += new System.EventHandler(this.Calculate_B_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 251);
            this.Controls.Add(this.Calculate_B);
            this.Controls.Add(this.Result_TB);
            this.Controls.Add(this.Result_L);
            this.Controls.Add(this.TargetXXPart_TB);
            this.Controls.Add(this.TargetXXPart_L);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SourceStringArray_TB);
            this.Controls.Add(this.SourceStringArray_L);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Task 6-4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label SourceStringArray_L;
        private System.Windows.Forms.TextBox SourceStringArray_TB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TargetXXPart_TB;
        private System.Windows.Forms.Label TargetXXPart_L;
        private System.Windows.Forms.TextBox Result_TB;
        private System.Windows.Forms.Label Result_L;
        private System.Windows.Forms.Button Calculate_B;
    }
}


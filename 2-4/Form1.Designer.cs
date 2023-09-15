namespace _2_4 {
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
            this.B_TB = new System.Windows.Forms.TextBox();
            this.B_L = new System.Windows.Forms.Label();
            this.A_TB = new System.Windows.Forms.TextBox();
            this.A_L = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Y_TB = new System.Windows.Forms.TextBox();
            this.Y_L = new System.Windows.Forms.Label();
            this.Calculate_B = new System.Windows.Forms.Button();
            this.X_TB = new System.Windows.Forms.TextBox();
            this.X_L = new System.Windows.Forms.Label();
            this.C_TB = new System.Windows.Forms.TextBox();
            this.C_L = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // B_TB
            // 
            this.B_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B_TB.Location = new System.Drawing.Point(42, 97);
            this.B_TB.Margin = new System.Windows.Forms.Padding(5);
            this.B_TB.Name = "B_TB";
            this.B_TB.ReadOnly = true;
            this.B_TB.Size = new System.Drawing.Size(130, 22);
            this.B_TB.TabIndex = 38;
            this.B_TB.TabStop = false;
            // 
            // B_L
            // 
            this.B_L.AutoSize = true;
            this.B_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B_L.Location = new System.Drawing.Point(14, 100);
            this.B_L.Margin = new System.Windows.Forms.Padding(5);
            this.B_L.Name = "B_L";
            this.B_L.Size = new System.Drawing.Size(15, 16);
            this.B_L.TabIndex = 37;
            this.B_L.Text = "b";
            // 
            // A_TB
            // 
            this.A_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.A_TB.Location = new System.Drawing.Point(41, 68);
            this.A_TB.Margin = new System.Windows.Forms.Padding(20);
            this.A_TB.Name = "A_TB";
            this.A_TB.ReadOnly = true;
            this.A_TB.Size = new System.Drawing.Size(130, 22);
            this.A_TB.TabIndex = 36;
            this.A_TB.TabStop = false;
            // 
            // A_L
            // 
            this.A_L.AutoSize = true;
            this.A_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.A_L.Location = new System.Drawing.Point(13, 71);
            this.A_L.Margin = new System.Windows.Forms.Padding(20, 20, 20, 8);
            this.A_L.Name = "A_L";
            this.A_L.Size = new System.Drawing.Size(15, 16);
            this.A_L.TabIndex = 35;
            this.A_L.Text = "a";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 26);
            this.label1.TabIndex = 33;
            this.label1.Text = "*Conditions\r\nX, Y > 0\r\n";
            // 
            // Y_TB
            // 
            this.Y_TB.Location = new System.Drawing.Point(42, 39);
            this.Y_TB.Margin = new System.Windows.Forms.Padding(5);
            this.Y_TB.Name = "Y_TB";
            this.Y_TB.Size = new System.Drawing.Size(129, 20);
            this.Y_TB.TabIndex = 28;
            // 
            // Y_L
            // 
            this.Y_L.AutoSize = true;
            this.Y_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Y_L.Location = new System.Drawing.Point(14, 40);
            this.Y_L.Margin = new System.Windows.Forms.Padding(5);
            this.Y_L.Name = "Y_L";
            this.Y_L.Size = new System.Drawing.Size(16, 16);
            this.Y_L.TabIndex = 27;
            this.Y_L.Text = "&Y";
            // 
            // Calculate_B
            // 
            this.Calculate_B.Location = new System.Drawing.Point(188, 13);
            this.Calculate_B.Margin = new System.Windows.Forms.Padding(5);
            this.Calculate_B.Name = "Calculate_B";
            this.Calculate_B.Size = new System.Drawing.Size(116, 46);
            this.Calculate_B.TabIndex = 34;
            this.Calculate_B.Text = "&Calculate";
            this.Calculate_B.UseVisualStyleBackColor = true;
            this.Calculate_B.Click += new System.EventHandler(this.Calculate_B_Click);
            // 
            // X_TB
            // 
            this.X_TB.Location = new System.Drawing.Point(42, 13);
            this.X_TB.Margin = new System.Windows.Forms.Padding(5);
            this.X_TB.Name = "X_TB";
            this.X_TB.Size = new System.Drawing.Size(129, 20);
            this.X_TB.TabIndex = 26;
            // 
            // X_L
            // 
            this.X_L.AutoSize = true;
            this.X_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.X_L.Location = new System.Drawing.Point(14, 14);
            this.X_L.Margin = new System.Windows.Forms.Padding(5);
            this.X_L.Name = "X_L";
            this.X_L.Size = new System.Drawing.Size(15, 16);
            this.X_L.TabIndex = 25;
            this.X_L.Text = "&X";
            // 
            // C_TB
            // 
            this.C_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.C_TB.Location = new System.Drawing.Point(41, 129);
            this.C_TB.Margin = new System.Windows.Forms.Padding(5);
            this.C_TB.Name = "C_TB";
            this.C_TB.ReadOnly = true;
            this.C_TB.Size = new System.Drawing.Size(130, 22);
            this.C_TB.TabIndex = 40;
            this.C_TB.TabStop = false;
            // 
            // C_L
            // 
            this.C_L.AutoSize = true;
            this.C_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.C_L.Location = new System.Drawing.Point(13, 132);
            this.C_L.Margin = new System.Windows.Forms.Padding(5);
            this.C_L.Name = "C_L";
            this.C_L.Size = new System.Drawing.Size(14, 16);
            this.C_L.TabIndex = 39;
            this.C_L.Text = "c";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 168);
            this.Controls.Add(this.C_TB);
            this.Controls.Add(this.C_L);
            this.Controls.Add(this.B_TB);
            this.Controls.Add(this.B_L);
            this.Controls.Add(this.A_TB);
            this.Controls.Add(this.A_L);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Y_TB);
            this.Controls.Add(this.Y_L);
            this.Controls.Add(this.Calculate_B);
            this.Controls.Add(this.X_TB);
            this.Controls.Add(this.X_L);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Task 2-4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox B_TB;
        private System.Windows.Forms.Label B_L;
        private System.Windows.Forms.TextBox A_TB;
        private System.Windows.Forms.Label A_L;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Y_TB;
        private System.Windows.Forms.Label Y_L;
        private System.Windows.Forms.Button Calculate_B;
        private System.Windows.Forms.TextBox X_TB;
        private System.Windows.Forms.Label X_L;
        private System.Windows.Forms.TextBox C_TB;
        private System.Windows.Forms.Label C_L;
    }
}


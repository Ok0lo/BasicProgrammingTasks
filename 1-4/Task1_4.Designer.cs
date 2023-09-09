namespace _1_4 {
    partial class Task1_4 {
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
            this.Calculate_B = new System.Windows.Forms.Button();
            this.Length_TB = new System.Windows.Forms.TextBox();
            this.Length_L = new System.Windows.Forms.Label();
            this.BigR_TB = new System.Windows.Forms.TextBox();
            this.BigR_L = new System.Windows.Forms.Label();
            this.SmallR_TB = new System.Windows.Forms.TextBox();
            this.SmallR_L = new System.Windows.Forms.Label();
            this.P_TB = new System.Windows.Forms.TextBox();
            this.P_L = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Volume_TB = new System.Windows.Forms.TextBox();
            this.Volume_L = new System.Windows.Forms.Label();
            this.Weight_TB = new System.Windows.Forms.TextBox();
            this.Weight_L = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Calculate_B
            // 
            this.Calculate_B.Location = new System.Drawing.Point(188, 13);
            this.Calculate_B.Margin = new System.Windows.Forms.Padding(5);
            this.Calculate_B.Name = "Calculate_B";
            this.Calculate_B.Size = new System.Drawing.Size(116, 46);
            this.Calculate_B.TabIndex = 13;
            this.Calculate_B.Text = "&Calculate";
            this.Calculate_B.UseVisualStyleBackColor = true;
            this.Calculate_B.Click += new System.EventHandler(this.Calculate_B_Click);
            // 
            // Length_TB
            // 
            this.Length_TB.Location = new System.Drawing.Point(71, 13);
            this.Length_TB.Margin = new System.Windows.Forms.Padding(5);
            this.Length_TB.Name = "Length_TB";
            this.Length_TB.Size = new System.Drawing.Size(100, 20);
            this.Length_TB.TabIndex = 12;
            // 
            // Length_L
            // 
            this.Length_L.AutoSize = true;
            this.Length_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Length_L.Location = new System.Drawing.Point(14, 14);
            this.Length_L.Margin = new System.Windows.Forms.Padding(5);
            this.Length_L.Name = "Length_L";
            this.Length_L.Size = new System.Drawing.Size(47, 16);
            this.Length_L.TabIndex = 11;
            this.Length_L.Text = "&Length";
            // 
            // BigR_TB
            // 
            this.BigR_TB.Location = new System.Drawing.Point(71, 43);
            this.BigR_TB.Margin = new System.Windows.Forms.Padding(5);
            this.BigR_TB.Name = "BigR_TB";
            this.BigR_TB.Size = new System.Drawing.Size(100, 20);
            this.BigR_TB.TabIndex = 15;
            // 
            // BigR_L
            // 
            this.BigR_L.AutoSize = true;
            this.BigR_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BigR_L.Location = new System.Drawing.Point(14, 44);
            this.BigR_L.Margin = new System.Windows.Forms.Padding(5);
            this.BigR_L.Name = "BigR_L";
            this.BigR_L.Size = new System.Drawing.Size(17, 16);
            this.BigR_L.TabIndex = 14;
            this.BigR_L.Text = "&R";
            // 
            // SmallR_TB
            // 
            this.SmallR_TB.Location = new System.Drawing.Point(71, 73);
            this.SmallR_TB.Margin = new System.Windows.Forms.Padding(5);
            this.SmallR_TB.Name = "SmallR_TB";
            this.SmallR_TB.Size = new System.Drawing.Size(100, 20);
            this.SmallR_TB.TabIndex = 17;
            // 
            // SmallR_L
            // 
            this.SmallR_L.AutoSize = true;
            this.SmallR_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SmallR_L.Location = new System.Drawing.Point(14, 74);
            this.SmallR_L.Margin = new System.Windows.Forms.Padding(5);
            this.SmallR_L.Name = "SmallR_L";
            this.SmallR_L.Size = new System.Drawing.Size(11, 16);
            this.SmallR_L.TabIndex = 16;
            this.SmallR_L.Text = "r";
            // 
            // P_TB
            // 
            this.P_TB.Location = new System.Drawing.Point(71, 103);
            this.P_TB.Margin = new System.Windows.Forms.Padding(5);
            this.P_TB.Name = "P_TB";
            this.P_TB.Size = new System.Drawing.Size(100, 20);
            this.P_TB.TabIndex = 19;
            // 
            // P_L
            // 
            this.P_L.AutoSize = true;
            this.P_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.P_L.Location = new System.Drawing.Point(14, 104);
            this.P_L.Margin = new System.Windows.Forms.Padding(5);
            this.P_L.Name = "P_L";
            this.P_L.Size = new System.Drawing.Size(15, 16);
            this.P_L.TabIndex = 18;
            this.P_L.Text = "&p";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 39);
            this.label1.TabIndex = 20;
            this.label1.Text = "*Restrictions\r\nR > r\r\nLength, R, r, p != 0\r\n";
            // 
            // Volume_TB
            // 
            this.Volume_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Volume_TB.Location = new System.Drawing.Point(71, 142);
            this.Volume_TB.Margin = new System.Windows.Forms.Padding(20);
            this.Volume_TB.Name = "Volume_TB";
            this.Volume_TB.ReadOnly = true;
            this.Volume_TB.Size = new System.Drawing.Size(233, 22);
            this.Volume_TB.TabIndex = 22;
            // 
            // Volume_L
            // 
            this.Volume_L.AutoSize = true;
            this.Volume_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Volume_L.Location = new System.Drawing.Point(14, 145);
            this.Volume_L.Margin = new System.Windows.Forms.Padding(20, 20, 20, 8);
            this.Volume_L.Name = "Volume_L";
            this.Volume_L.Size = new System.Drawing.Size(16, 16);
            this.Volume_L.TabIndex = 21;
            this.Volume_L.Text = "V";
            // 
            // Weight_TB
            // 
            this.Weight_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Weight_TB.Location = new System.Drawing.Point(71, 171);
            this.Weight_TB.Margin = new System.Windows.Forms.Padding(5);
            this.Weight_TB.Name = "Weight_TB";
            this.Weight_TB.ReadOnly = true;
            this.Weight_TB.Size = new System.Drawing.Size(233, 22);
            this.Weight_TB.TabIndex = 24;
            // 
            // Weight_L
            // 
            this.Weight_L.AutoSize = true;
            this.Weight_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Weight_L.Location = new System.Drawing.Point(14, 174);
            this.Weight_L.Margin = new System.Windows.Forms.Padding(5);
            this.Weight_L.Name = "Weight_L";
            this.Weight_L.Size = new System.Drawing.Size(18, 16);
            this.Weight_L.TabIndex = 23;
            this.Weight_L.Text = "m";
            // 
            // Task1_4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 217);
            this.Controls.Add(this.Weight_TB);
            this.Controls.Add(this.Weight_L);
            this.Controls.Add(this.Volume_TB);
            this.Controls.Add(this.Volume_L);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.P_TB);
            this.Controls.Add(this.P_L);
            this.Controls.Add(this.SmallR_TB);
            this.Controls.Add(this.SmallR_L);
            this.Controls.Add(this.BigR_TB);
            this.Controls.Add(this.BigR_L);
            this.Controls.Add(this.Calculate_B);
            this.Controls.Add(this.Length_TB);
            this.Controls.Add(this.Length_L);
            this.Name = "Task1_4";
            this.Text = "Task 1-4";
            this.Load += new System.EventHandler(this.Task1_4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Calculate_B;
        private System.Windows.Forms.TextBox Length_TB;
        private System.Windows.Forms.Label Length_L;
        private System.Windows.Forms.TextBox BigR_TB;
        private System.Windows.Forms.Label BigR_L;
        private System.Windows.Forms.TextBox SmallR_TB;
        private System.Windows.Forms.Label SmallR_L;
        private System.Windows.Forms.TextBox P_TB;
        private System.Windows.Forms.Label P_L;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Volume_TB;
        private System.Windows.Forms.Label Volume_L;
        private System.Windows.Forms.TextBox Weight_TB;
        private System.Windows.Forms.Label Weight_L;
    }
}


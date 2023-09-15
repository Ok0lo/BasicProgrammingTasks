namespace _3_22 {
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
            this.label1 = new System.Windows.Forms.Label();
            this.Calculate2_B = new System.Windows.Forms.Button();
            this.E_TB = new System.Windows.Forms.TextBox();
            this.E_L = new System.Windows.Forms.Label();
            this.Result2_TB = new System.Windows.Forms.TextBox();
            this.Result2_L = new System.Windows.Forms.Label();
            this.Result1_TB = new System.Windows.Forms.TextBox();
            this.Result1_L = new System.Windows.Forms.Label();
            this.N_TB = new System.Windows.Forms.TextBox();
            this.N_L = new System.Windows.Forms.Label();
            this.Calculate1_B = new System.Windows.Forms.Button();
            this.X_TB = new System.Windows.Forms.TextBox();
            this.X_L = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(379, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 26);
            this.label1.TabIndex = 67;
            this.label1.Text = "*Conditions\r\n0 < E < 1\r\n";
            // 
            // Calculate2_B
            // 
            this.Calculate2_B.Location = new System.Drawing.Point(257, 43);
            this.Calculate2_B.Margin = new System.Windows.Forms.Padding(5);
            this.Calculate2_B.Name = "Calculate2_B";
            this.Calculate2_B.Size = new System.Drawing.Size(116, 38);
            this.Calculate2_B.TabIndex = 66;
            this.Calculate2_B.Text = "Calculate &2";
            this.Calculate2_B.UseVisualStyleBackColor = true;
            this.Calculate2_B.Click += new System.EventHandler(this.Calculate2_B_Click);
            // 
            // E_TB
            // 
            this.E_TB.Location = new System.Drawing.Point(257, 13);
            this.E_TB.Margin = new System.Windows.Forms.Padding(5);
            this.E_TB.Name = "E_TB";
            this.E_TB.Size = new System.Drawing.Size(164, 20);
            this.E_TB.TabIndex = 65;
            // 
            // E_L
            // 
            this.E_L.AutoSize = true;
            this.E_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.E_L.Location = new System.Drawing.Point(231, 14);
            this.E_L.Margin = new System.Windows.Forms.Padding(5);
            this.E_L.Name = "E_L";
            this.E_L.Size = new System.Drawing.Size(16, 16);
            this.E_L.TabIndex = 64;
            this.E_L.Text = "&E";
            // 
            // Result2_TB
            // 
            this.Result2_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Result2_TB.Location = new System.Drawing.Point(292, 122);
            this.Result2_TB.Margin = new System.Windows.Forms.Padding(5);
            this.Result2_TB.Name = "Result2_TB";
            this.Result2_TB.ReadOnly = true;
            this.Result2_TB.Size = new System.Drawing.Size(130, 22);
            this.Result2_TB.TabIndex = 63;
            this.Result2_TB.TabStop = false;
            // 
            // Result2_L
            // 
            this.Result2_L.AutoSize = true;
            this.Result2_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Result2_L.Location = new System.Drawing.Point(231, 123);
            this.Result2_L.Margin = new System.Windows.Forms.Padding(5);
            this.Result2_L.Name = "Result2_L";
            this.Result2_L.Size = new System.Drawing.Size(55, 16);
            this.Result2_L.TabIndex = 62;
            this.Result2_L.Text = "Result 2";
            // 
            // Result1_TB
            // 
            this.Result1_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Result1_TB.Location = new System.Drawing.Point(76, 120);
            this.Result1_TB.Margin = new System.Windows.Forms.Padding(20);
            this.Result1_TB.Name = "Result1_TB";
            this.Result1_TB.ReadOnly = true;
            this.Result1_TB.Size = new System.Drawing.Size(130, 22);
            this.Result1_TB.TabIndex = 61;
            this.Result1_TB.TabStop = false;
            // 
            // Result1_L
            // 
            this.Result1_L.AutoSize = true;
            this.Result1_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Result1_L.Location = new System.Drawing.Point(14, 123);
            this.Result1_L.Margin = new System.Windows.Forms.Padding(20, 20, 20, 8);
            this.Result1_L.Name = "Result1_L";
            this.Result1_L.Size = new System.Drawing.Size(55, 16);
            this.Result1_L.TabIndex = 60;
            this.Result1_L.Text = "Result 1";
            // 
            // N_TB
            // 
            this.N_TB.Location = new System.Drawing.Point(41, 39);
            this.N_TB.Margin = new System.Windows.Forms.Padding(5);
            this.N_TB.Name = "N_TB";
            this.N_TB.Size = new System.Drawing.Size(164, 20);
            this.N_TB.TabIndex = 58;
            // 
            // N_L
            // 
            this.N_L.AutoSize = true;
            this.N_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.N_L.Location = new System.Drawing.Point(14, 40);
            this.N_L.Margin = new System.Windows.Forms.Padding(5);
            this.N_L.Name = "N_L";
            this.N_L.Size = new System.Drawing.Size(17, 16);
            this.N_L.TabIndex = 57;
            this.N_L.Text = "&N";
            // 
            // Calculate1_B
            // 
            this.Calculate1_B.Location = new System.Drawing.Point(41, 69);
            this.Calculate1_B.Margin = new System.Windows.Forms.Padding(5);
            this.Calculate1_B.Name = "Calculate1_B";
            this.Calculate1_B.Size = new System.Drawing.Size(116, 38);
            this.Calculate1_B.TabIndex = 59;
            this.Calculate1_B.Text = "Calculate &1";
            this.Calculate1_B.UseVisualStyleBackColor = true;
            this.Calculate1_B.Click += new System.EventHandler(this.Calculate1_B_Click);
            // 
            // X_TB
            // 
            this.X_TB.Location = new System.Drawing.Point(41, 13);
            this.X_TB.Margin = new System.Windows.Forms.Padding(5);
            this.X_TB.Name = "X_TB";
            this.X_TB.Size = new System.Drawing.Size(164, 20);
            this.X_TB.TabIndex = 56;
            // 
            // X_L
            // 
            this.X_L.AutoSize = true;
            this.X_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.X_L.Location = new System.Drawing.Point(14, 14);
            this.X_L.Margin = new System.Windows.Forms.Padding(5);
            this.X_L.Name = "X_L";
            this.X_L.Size = new System.Drawing.Size(15, 16);
            this.X_L.TabIndex = 55;
            this.X_L.Text = "&X";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 158);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Calculate2_B);
            this.Controls.Add(this.E_TB);
            this.Controls.Add(this.E_L);
            this.Controls.Add(this.Result2_TB);
            this.Controls.Add(this.Result2_L);
            this.Controls.Add(this.Result1_TB);
            this.Controls.Add(this.Result1_L);
            this.Controls.Add(this.N_TB);
            this.Controls.Add(this.N_L);
            this.Controls.Add(this.Calculate1_B);
            this.Controls.Add(this.X_TB);
            this.Controls.Add(this.X_L);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Task 3-22";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Calculate2_B;
        private System.Windows.Forms.TextBox E_TB;
        private System.Windows.Forms.Label E_L;
        private System.Windows.Forms.TextBox Result2_TB;
        private System.Windows.Forms.Label Result2_L;
        private System.Windows.Forms.TextBox Result1_TB;
        private System.Windows.Forms.Label Result1_L;
        private System.Windows.Forms.TextBox N_TB;
        private System.Windows.Forms.Label N_L;
        private System.Windows.Forms.Button Calculate1_B;
        private System.Windows.Forms.TextBox X_TB;
        private System.Windows.Forms.Label X_L;
    }
}


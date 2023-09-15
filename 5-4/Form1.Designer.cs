namespace _5_4 {
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
            this.Calculate_B = new System.Windows.Forms.Button();
            this.Matrix_L = new System.Windows.Forms.Label();
            this.RowAmount_NUD = new System.Windows.Forms.NumericUpDown();
            this.Matrix_DGV = new System.Windows.Forms.DataGridView();
            this.RowAmount_L = new System.Windows.Forms.Label();
            this.ColimnAmount_L = new System.Windows.Forms.Label();
            this.ColumnAmount_NUD = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.RowAmount_NUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Matrix_DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColumnAmount_NUD)).BeginInit();
            this.SuspendLayout();
            // 
            // Calculate_B
            // 
            this.Calculate_B.Location = new System.Drawing.Point(597, 32);
            this.Calculate_B.Margin = new System.Windows.Forms.Padding(8);
            this.Calculate_B.Name = "Calculate_B";
            this.Calculate_B.Size = new System.Drawing.Size(116, 44);
            this.Calculate_B.TabIndex = 4;
            this.Calculate_B.Text = "&Calculate";
            this.Calculate_B.UseVisualStyleBackColor = true;
            this.Calculate_B.Click += new System.EventHandler(this.Calculate_B_Click);
            // 
            // Matrix_L
            // 
            this.Matrix_L.AutoSize = true;
            this.Matrix_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Matrix_L.Location = new System.Drawing.Point(11, 11);
            this.Matrix_L.Margin = new System.Windows.Forms.Padding(2);
            this.Matrix_L.Name = "Matrix_L";
            this.Matrix_L.Size = new System.Drawing.Size(42, 16);
            this.Matrix_L.TabIndex = 35;
            this.Matrix_L.Text = "&Matrix";
            // 
            // RowAmount_NUD
            // 
            this.RowAmount_NUD.Location = new System.Drawing.Point(102, 340);
            this.RowAmount_NUD.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.RowAmount_NUD.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.RowAmount_NUD.Name = "RowAmount_NUD";
            this.RowAmount_NUD.Size = new System.Drawing.Size(59, 20);
            this.RowAmount_NUD.TabIndex = 2;
            this.RowAmount_NUD.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.RowAmount_NUD.ValueChanged += new System.EventHandler(this.RowAmount_NUD_ValueChanged);
            // 
            // Matrix_DGV
            // 
            this.Matrix_DGV.AllowUserToAddRows = false;
            this.Matrix_DGV.AllowUserToDeleteRows = false;
            this.Matrix_DGV.AllowUserToOrderColumns = true;
            this.Matrix_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Matrix_DGV.ColumnHeadersVisible = false;
            this.Matrix_DGV.Location = new System.Drawing.Point(12, 32);
            this.Matrix_DGV.Name = "Matrix_DGV";
            this.Matrix_DGV.ReadOnly = true;
            this.Matrix_DGV.RowHeadersVisible = false;
            this.Matrix_DGV.Size = new System.Drawing.Size(574, 300);
            this.Matrix_DGV.TabIndex = 1;
            // 
            // RowAmount_L
            // 
            this.RowAmount_L.AutoSize = true;
            this.RowAmount_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RowAmount_L.Location = new System.Drawing.Point(14, 340);
            this.RowAmount_L.Margin = new System.Windows.Forms.Padding(5);
            this.RowAmount_L.Name = "RowAmount_L";
            this.RowAmount_L.Size = new System.Drawing.Size(82, 16);
            this.RowAmount_L.TabIndex = 41;
            this.RowAmount_L.Text = "&Row Amount";
            // 
            // ColimnAmount_L
            // 
            this.ColimnAmount_L.AutoSize = true;
            this.ColimnAmount_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ColimnAmount_L.Location = new System.Drawing.Point(182, 340);
            this.ColimnAmount_L.Margin = new System.Windows.Forms.Padding(5);
            this.ColimnAmount_L.Name = "ColimnAmount_L";
            this.ColimnAmount_L.Size = new System.Drawing.Size(100, 16);
            this.ColimnAmount_L.TabIndex = 43;
            this.ColimnAmount_L.Text = "C&olumn Amount";
            // 
            // ColumnAmount_NUD
            // 
            this.ColumnAmount_NUD.Location = new System.Drawing.Point(290, 340);
            this.ColumnAmount_NUD.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ColumnAmount_NUD.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.ColumnAmount_NUD.Name = "ColumnAmount_NUD";
            this.ColumnAmount_NUD.Size = new System.Drawing.Size(59, 20);
            this.ColumnAmount_NUD.TabIndex = 3;
            this.ColumnAmount_NUD.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.ColumnAmount_NUD.ValueChanged += new System.EventHandler(this.ColumnAmount_NUD_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 373);
            this.Controls.Add(this.ColimnAmount_L);
            this.Controls.Add(this.ColumnAmount_NUD);
            this.Controls.Add(this.RowAmount_L);
            this.Controls.Add(this.Matrix_DGV);
            this.Controls.Add(this.RowAmount_NUD);
            this.Controls.Add(this.Calculate_B);
            this.Controls.Add(this.Matrix_L);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Task 5-4";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RowAmount_NUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Matrix_DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColumnAmount_NUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Calculate_B;
        private System.Windows.Forms.Label Matrix_L;
        private System.Windows.Forms.NumericUpDown RowAmount_NUD;
        private System.Windows.Forms.DataGridView Matrix_DGV;
        private System.Windows.Forms.Label RowAmount_L;
        private System.Windows.Forms.Label ColimnAmount_L;
        private System.Windows.Forms.NumericUpDown ColumnAmount_NUD;
    }
}


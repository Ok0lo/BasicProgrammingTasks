namespace _7_22
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MatrixLength_NUD = new System.Windows.Forms.NumericUpDown();
            this.MatrixLength_L = new System.Windows.Forms.Label();
            this.MatrixA_L = new System.Windows.Forms.Label();
            this.MatrixA_DGV = new System.Windows.Forms.DataGridView();
            this.MatrixB_L = new System.Windows.Forms.Label();
            this.MatrixB_DGV = new System.Windows.Forms.DataGridView();
            this.MatrixC_L = new System.Windows.Forms.Label();
            this.MatrixC_DGV = new System.Windows.Forms.DataGridView();
            this.Result_TB = new System.Windows.Forms.TextBox();
            this.Result_L = new System.Windows.Forms.Label();
            this.Calculate_B = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MatrixLength_NUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MatrixA_DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MatrixB_DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MatrixC_DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // MatrixLength_NUD
            // 
            this.MatrixLength_NUD.Location = new System.Drawing.Point(104, 236);
            this.MatrixLength_NUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MatrixLength_NUD.Name = "MatrixLength_NUD";
            this.MatrixLength_NUD.Size = new System.Drawing.Size(59, 20);
            this.MatrixLength_NUD.TabIndex = 70;
            this.MatrixLength_NUD.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.MatrixLength_NUD.ValueChanged += new System.EventHandler(this.MatrixLength_NUD_ValueChanged);
            // 
            // MatrixLength_L
            // 
            this.MatrixLength_L.AutoSize = true;
            this.MatrixLength_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MatrixLength_L.Location = new System.Drawing.Point(14, 238);
            this.MatrixLength_L.Margin = new System.Windows.Forms.Padding(5);
            this.MatrixLength_L.Name = "MatrixLength_L";
            this.MatrixLength_L.Size = new System.Drawing.Size(85, 16);
            this.MatrixLength_L.TabIndex = 69;
            this.MatrixLength_L.Text = "&Matrix Length";
            // 
            // MatrixA_L
            // 
            this.MatrixA_L.AutoSize = true;
            this.MatrixA_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MatrixA_L.Location = new System.Drawing.Point(14, 14);
            this.MatrixA_L.Margin = new System.Windows.Forms.Padding(5);
            this.MatrixA_L.Name = "MatrixA_L";
            this.MatrixA_L.Size = new System.Drawing.Size(54, 16);
            this.MatrixA_L.TabIndex = 72;
            this.MatrixA_L.Text = "Matrix &A";
            // 
            // MatrixA_DGV
            // 
            this.MatrixA_DGV.AllowUserToAddRows = false;
            this.MatrixA_DGV.AllowUserToDeleteRows = false;
            this.MatrixA_DGV.AllowUserToOrderColumns = true;
            this.MatrixA_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MatrixA_DGV.ColumnHeadersVisible = false;
            this.MatrixA_DGV.Location = new System.Drawing.Point(17, 38);
            this.MatrixA_DGV.Name = "MatrixA_DGV";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.NullValue = null;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MatrixA_DGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.MatrixA_DGV.RowHeadersVisible = false;
            this.MatrixA_DGV.RowTemplate.DefaultCellStyle.NullValue = null;
            this.MatrixA_DGV.Size = new System.Drawing.Size(279, 192);
            this.MatrixA_DGV.TabIndex = 71;
            // 
            // MatrixB_L
            // 
            this.MatrixB_L.AutoSize = true;
            this.MatrixB_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MatrixB_L.Location = new System.Drawing.Point(299, 14);
            this.MatrixB_L.Margin = new System.Windows.Forms.Padding(5);
            this.MatrixB_L.Name = "MatrixB_L";
            this.MatrixB_L.Size = new System.Drawing.Size(54, 16);
            this.MatrixB_L.TabIndex = 74;
            this.MatrixB_L.Text = "Matrix &B";
            // 
            // MatrixB_DGV
            // 
            this.MatrixB_DGV.AllowUserToAddRows = false;
            this.MatrixB_DGV.AllowUserToDeleteRows = false;
            this.MatrixB_DGV.AllowUserToOrderColumns = true;
            this.MatrixB_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MatrixB_DGV.ColumnHeadersVisible = false;
            this.MatrixB_DGV.Location = new System.Drawing.Point(302, 38);
            this.MatrixB_DGV.Name = "MatrixB_DGV";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.NullValue = null;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MatrixB_DGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.MatrixB_DGV.RowHeadersVisible = false;
            this.MatrixB_DGV.RowTemplate.DefaultCellStyle.NullValue = null;
            this.MatrixB_DGV.Size = new System.Drawing.Size(279, 192);
            this.MatrixB_DGV.TabIndex = 73;
            // 
            // MatrixC_L
            // 
            this.MatrixC_L.AutoSize = true;
            this.MatrixC_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MatrixC_L.Location = new System.Drawing.Point(584, 14);
            this.MatrixC_L.Margin = new System.Windows.Forms.Padding(5);
            this.MatrixC_L.Name = "MatrixC_L";
            this.MatrixC_L.Size = new System.Drawing.Size(54, 16);
            this.MatrixC_L.TabIndex = 76;
            this.MatrixC_L.Text = "Matrix &C";
            // 
            // MatrixC_DGV
            // 
            this.MatrixC_DGV.AllowUserToAddRows = false;
            this.MatrixC_DGV.AllowUserToDeleteRows = false;
            this.MatrixC_DGV.AllowUserToOrderColumns = true;
            this.MatrixC_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MatrixC_DGV.ColumnHeadersVisible = false;
            this.MatrixC_DGV.Location = new System.Drawing.Point(587, 38);
            this.MatrixC_DGV.Name = "MatrixC_DGV";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.NullValue = null;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MatrixC_DGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.MatrixC_DGV.RowHeadersVisible = false;
            this.MatrixC_DGV.RowTemplate.DefaultCellStyle.NullValue = null;
            this.MatrixC_DGV.Size = new System.Drawing.Size(279, 192);
            this.MatrixC_DGV.TabIndex = 75;
            // 
            // Result_TB
            // 
            this.Result_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Result_TB.Location = new System.Drawing.Point(76, 314);
            this.Result_TB.Margin = new System.Windows.Forms.Padding(20);
            this.Result_TB.Name = "Result_TB";
            this.Result_TB.ReadOnly = true;
            this.Result_TB.Size = new System.Drawing.Size(57, 22);
            this.Result_TB.TabIndex = 78;
            this.Result_TB.TabStop = false;
            // 
            // Result_L
            // 
            this.Result_L.AutoSize = true;
            this.Result_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Result_L.Location = new System.Drawing.Point(14, 317);
            this.Result_L.Margin = new System.Windows.Forms.Padding(20, 20, 20, 8);
            this.Result_L.Name = "Result_L";
            this.Result_L.Size = new System.Drawing.Size(45, 16);
            this.Result_L.TabIndex = 77;
            this.Result_L.Text = "Result";
            // 
            // Calculate_B
            // 
            this.Calculate_B.Location = new System.Drawing.Point(17, 264);
            this.Calculate_B.Margin = new System.Windows.Forms.Padding(5);
            this.Calculate_B.Name = "Calculate_B";
            this.Calculate_B.Size = new System.Drawing.Size(116, 38);
            this.Calculate_B.TabIndex = 79;
            this.Calculate_B.Text = "&Calculate";
            this.Calculate_B.UseVisualStyleBackColor = true;
            this.Calculate_B.Click += new System.EventHandler(this.Calculate_B_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 354);
            this.Controls.Add(this.Calculate_B);
            this.Controls.Add(this.Result_TB);
            this.Controls.Add(this.Result_L);
            this.Controls.Add(this.MatrixC_L);
            this.Controls.Add(this.MatrixC_DGV);
            this.Controls.Add(this.MatrixB_L);
            this.Controls.Add(this.MatrixB_DGV);
            this.Controls.Add(this.MatrixA_L);
            this.Controls.Add(this.MatrixA_DGV);
            this.Controls.Add(this.MatrixLength_NUD);
            this.Controls.Add(this.MatrixLength_L);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Task 7-22";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MatrixLength_NUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MatrixA_DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MatrixB_DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MatrixC_DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown MatrixLength_NUD;
        private System.Windows.Forms.Label MatrixLength_L;
        private System.Windows.Forms.Label MatrixA_L;
        private System.Windows.Forms.DataGridView MatrixA_DGV;
        private System.Windows.Forms.Label MatrixB_L;
        private System.Windows.Forms.DataGridView MatrixB_DGV;
        private System.Windows.Forms.Label MatrixC_L;
        private System.Windows.Forms.DataGridView MatrixC_DGV;
        private System.Windows.Forms.TextBox Result_TB;
        private System.Windows.Forms.Label Result_L;
        private System.Windows.Forms.Button Calculate_B;
    }
}


namespace _7_4
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.VectorLength_L = new System.Windows.Forms.Label();
            this.XVector_DGV = new System.Windows.Forms.DataGridView();
            this.XVector_L = new System.Windows.Forms.Label();
            this.YVector_L = new System.Windows.Forms.Label();
            this.YVector_DGV = new System.Windows.Forms.DataGridView();
            this.ZVector_L = new System.Windows.Forms.Label();
            this.ZVector_DGV = new System.Windows.Forms.DataGridView();
            this.ResultArray_DGV = new System.Windows.Forms.DataGridView();
            this.ResultArray_L = new System.Windows.Forms.Label();
            this.Calculate_B = new System.Windows.Forms.Button();
            this.VectorLength_NUD = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.XVector_DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YVector_DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZVector_DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultArray_DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VectorLength_NUD)).BeginInit();
            this.SuspendLayout();
            // 
            // VectorLength_L
            // 
            this.VectorLength_L.AutoSize = true;
            this.VectorLength_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VectorLength_L.Location = new System.Drawing.Point(14, 14);
            this.VectorLength_L.Margin = new System.Windows.Forms.Padding(5);
            this.VectorLength_L.Name = "VectorLength_L";
            this.VectorLength_L.Size = new System.Drawing.Size(89, 16);
            this.VectorLength_L.TabIndex = 57;
            this.VectorLength_L.Text = "&Vector Length";
            // 
            // XVector_DGV
            // 
            this.XVector_DGV.AllowUserToAddRows = false;
            this.XVector_DGV.AllowUserToDeleteRows = false;
            this.XVector_DGV.AllowUserToOrderColumns = true;
            this.XVector_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.XVector_DGV.ColumnHeadersVisible = false;
            this.XVector_DGV.Location = new System.Drawing.Point(17, 64);
            this.XVector_DGV.Name = "XVector_DGV";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.XVector_DGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.XVector_DGV.RowHeadersVisible = false;
            this.XVector_DGV.RowTemplate.DefaultCellStyle.NullValue = null;
            this.XVector_DGV.Size = new System.Drawing.Size(89, 176);
            this.XVector_DGV.TabIndex = 59;
            // 
            // XVector_L
            // 
            this.XVector_L.AutoSize = true;
            this.XVector_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.XVector_L.Location = new System.Drawing.Point(14, 40);
            this.XVector_L.Margin = new System.Windows.Forms.Padding(5);
            this.XVector_L.Name = "XVector_L";
            this.XVector_L.Size = new System.Drawing.Size(57, 16);
            this.XVector_L.TabIndex = 60;
            this.XVector_L.Text = "&X Vector";
            // 
            // YVector_L
            // 
            this.YVector_L.AutoSize = true;
            this.YVector_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.YVector_L.Location = new System.Drawing.Point(119, 40);
            this.YVector_L.Margin = new System.Windows.Forms.Padding(5);
            this.YVector_L.Name = "YVector_L";
            this.YVector_L.Size = new System.Drawing.Size(58, 16);
            this.YVector_L.TabIndex = 62;
            this.YVector_L.Text = "&Y Vector";
            // 
            // YVector_DGV
            // 
            this.YVector_DGV.AllowUserToAddRows = false;
            this.YVector_DGV.AllowUserToDeleteRows = false;
            this.YVector_DGV.AllowUserToOrderColumns = true;
            this.YVector_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.YVector_DGV.ColumnHeadersVisible = false;
            this.YVector_DGV.Location = new System.Drawing.Point(122, 64);
            this.YVector_DGV.Name = "YVector_DGV";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.YVector_DGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.YVector_DGV.RowHeadersVisible = false;
            this.YVector_DGV.RowTemplate.DefaultCellStyle.NullValue = null;
            this.YVector_DGV.Size = new System.Drawing.Size(89, 176);
            this.YVector_DGV.TabIndex = 61;
            // 
            // ZVector_L
            // 
            this.ZVector_L.AutoSize = true;
            this.ZVector_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ZVector_L.Location = new System.Drawing.Point(224, 40);
            this.ZVector_L.Margin = new System.Windows.Forms.Padding(5);
            this.ZVector_L.Name = "ZVector_L";
            this.ZVector_L.Size = new System.Drawing.Size(57, 16);
            this.ZVector_L.TabIndex = 64;
            this.ZVector_L.Text = "&Z Vector";
            // 
            // ZVector_DGV
            // 
            this.ZVector_DGV.AllowUserToAddRows = false;
            this.ZVector_DGV.AllowUserToDeleteRows = false;
            this.ZVector_DGV.AllowUserToOrderColumns = true;
            this.ZVector_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ZVector_DGV.ColumnHeadersVisible = false;
            this.ZVector_DGV.Location = new System.Drawing.Point(227, 64);
            this.ZVector_DGV.Name = "ZVector_DGV";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ZVector_DGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.ZVector_DGV.RowHeadersVisible = false;
            this.ZVector_DGV.RowTemplate.DefaultCellStyle.NullValue = null;
            this.ZVector_DGV.Size = new System.Drawing.Size(89, 176);
            this.ZVector_DGV.TabIndex = 63;
            // 
            // ResultArray_DGV
            // 
            this.ResultArray_DGV.AllowUserToAddRows = false;
            this.ResultArray_DGV.AllowUserToDeleteRows = false;
            this.ResultArray_DGV.AllowUserToOrderColumns = true;
            this.ResultArray_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultArray_DGV.ColumnHeadersVisible = false;
            this.ResultArray_DGV.Location = new System.Drawing.Point(341, 38);
            this.ResultArray_DGV.Name = "ResultArray_DGV";
            this.ResultArray_DGV.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.NullValue = null;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ResultArray_DGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.ResultArray_DGV.RowHeadersVisible = false;
            this.ResultArray_DGV.RowTemplate.DefaultCellStyle.NullValue = null;
            this.ResultArray_DGV.Size = new System.Drawing.Size(114, 202);
            this.ResultArray_DGV.TabIndex = 65;
            // 
            // ResultArray_L
            // 
            this.ResultArray_L.AutoSize = true;
            this.ResultArray_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultArray_L.Location = new System.Drawing.Point(338, 14);
            this.ResultArray_L.Margin = new System.Windows.Forms.Padding(5);
            this.ResultArray_L.Name = "ResultArray_L";
            this.ResultArray_L.Size = new System.Drawing.Size(80, 16);
            this.ResultArray_L.TabIndex = 66;
            this.ResultArray_L.Text = "&Result Array";
            // 
            // Calculate_B
            // 
            this.Calculate_B.Location = new System.Drawing.Point(17, 257);
            this.Calculate_B.Margin = new System.Windows.Forms.Padding(5);
            this.Calculate_B.Name = "Calculate_B";
            this.Calculate_B.Size = new System.Drawing.Size(116, 38);
            this.Calculate_B.TabIndex = 67;
            this.Calculate_B.Text = "&Calculate";
            this.Calculate_B.UseVisualStyleBackColor = true;
            this.Calculate_B.Click += new System.EventHandler(this.Calculate_B_Click);
            // 
            // VectorLength_NUD
            // 
            this.VectorLength_NUD.Location = new System.Drawing.Point(104, 12);
            this.VectorLength_NUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.VectorLength_NUD.Name = "VectorLength_NUD";
            this.VectorLength_NUD.Size = new System.Drawing.Size(59, 20);
            this.VectorLength_NUD.TabIndex = 68;
            this.VectorLength_NUD.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.VectorLength_NUD.ValueChanged += new System.EventHandler(this.VectorLength_NUD_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 309);
            this.Controls.Add(this.VectorLength_NUD);
            this.Controls.Add(this.Calculate_B);
            this.Controls.Add(this.ResultArray_L);
            this.Controls.Add(this.ResultArray_DGV);
            this.Controls.Add(this.ZVector_L);
            this.Controls.Add(this.ZVector_DGV);
            this.Controls.Add(this.YVector_L);
            this.Controls.Add(this.YVector_DGV);
            this.Controls.Add(this.XVector_L);
            this.Controls.Add(this.XVector_DGV);
            this.Controls.Add(this.VectorLength_L);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Task 7-4";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.XVector_DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YVector_DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZVector_DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultArray_DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VectorLength_NUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label VectorLength_L;
        private System.Windows.Forms.DataGridView XVector_DGV;
        private System.Windows.Forms.Label XVector_L;
        private System.Windows.Forms.Label YVector_L;
        private System.Windows.Forms.DataGridView YVector_DGV;
        private System.Windows.Forms.Label ZVector_L;
        private System.Windows.Forms.DataGridView ZVector_DGV;
        private System.Windows.Forms.DataGridView ResultArray_DGV;
        private System.Windows.Forms.Label ResultArray_L;
        private System.Windows.Forms.Button Calculate_B;
        private System.Windows.Forms.NumericUpDown VectorLength_NUD;
    }
}


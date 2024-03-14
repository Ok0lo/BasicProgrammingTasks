namespace _10_22
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
            this.MatrixA_DGV = new System.Windows.Forms.DataGridView();
            this.MatrixA_L = new System.Windows.Forms.Label();
            this.GenerateMatrixA_B = new System.Windows.Forms.Button();
            this.ResultMatrix_DGV = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.Modify_B = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.MatrixA_DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultMatrix_DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // MatrixA_DGV
            // 
            this.MatrixA_DGV.AllowUserToAddRows = false;
            this.MatrixA_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MatrixA_DGV.ColumnHeadersVisible = false;
            this.MatrixA_DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.MatrixA_DGV.Location = new System.Drawing.Point(12, 38);
            this.MatrixA_DGV.Name = "MatrixA_DGV";
            this.MatrixA_DGV.ReadOnly = true;
            this.MatrixA_DGV.RowHeadersVisible = false;
            this.MatrixA_DGV.RowTemplate.Height = 21;
            this.MatrixA_DGV.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.MatrixA_DGV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.MatrixA_DGV.Size = new System.Drawing.Size(400, 203);
            this.MatrixA_DGV.TabIndex = 88;
            // 
            // MatrixA_L
            // 
            this.MatrixA_L.AutoSize = true;
            this.MatrixA_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MatrixA_L.Location = new System.Drawing.Point(9, 14);
            this.MatrixA_L.Margin = new System.Windows.Forms.Padding(5);
            this.MatrixA_L.Name = "MatrixA_L";
            this.MatrixA_L.Size = new System.Drawing.Size(54, 16);
            this.MatrixA_L.TabIndex = 87;
            this.MatrixA_L.Text = "Matrix A";
            // 
            // GenerateMatrixA_B
            // 
            this.GenerateMatrixA_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GenerateMatrixA_B.Location = new System.Drawing.Point(270, 249);
            this.GenerateMatrixA_B.Margin = new System.Windows.Forms.Padding(5);
            this.GenerateMatrixA_B.Name = "GenerateMatrixA_B";
            this.GenerateMatrixA_B.Size = new System.Drawing.Size(147, 38);
            this.GenerateMatrixA_B.TabIndex = 89;
            this.GenerateMatrixA_B.Text = "&Generate Matrix A";
            this.GenerateMatrixA_B.UseVisualStyleBackColor = true;
            this.GenerateMatrixA_B.Click += new System.EventHandler(this.GenerateMatrixA_B_Click);
            // 
            // ResultMatrix_DGV
            // 
            this.ResultMatrix_DGV.AllowUserToAddRows = false;
            this.ResultMatrix_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultMatrix_DGV.ColumnHeadersVisible = false;
            this.ResultMatrix_DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.ResultMatrix_DGV.Location = new System.Drawing.Point(427, 38);
            this.ResultMatrix_DGV.Name = "ResultMatrix_DGV";
            this.ResultMatrix_DGV.ReadOnly = true;
            this.ResultMatrix_DGV.RowHeadersVisible = false;
            this.ResultMatrix_DGV.RowTemplate.Height = 21;
            this.ResultMatrix_DGV.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ResultMatrix_DGV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ResultMatrix_DGV.Size = new System.Drawing.Size(400, 203);
            this.ResultMatrix_DGV.TabIndex = 91;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Column1";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 76;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(424, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 90;
            this.label1.Text = "Result Matrix";
            // 
            // Modify_B
            // 
            this.Modify_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Modify_B.Location = new System.Drawing.Point(427, 249);
            this.Modify_B.Margin = new System.Windows.Forms.Padding(5);
            this.Modify_B.Name = "Modify_B";
            this.Modify_B.Size = new System.Drawing.Size(147, 38);
            this.Modify_B.TabIndex = 92;
            this.Modify_B.Text = "&Modify";
            this.Modify_B.UseVisualStyleBackColor = true;
            this.Modify_B.Click += new System.EventHandler(this.Modify_B_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 30;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 30;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 30;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 30;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Column5";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 30;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Column6";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 30;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 301);
            this.Controls.Add(this.Modify_B);
            this.Controls.Add(this.ResultMatrix_DGV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GenerateMatrixA_B);
            this.Controls.Add(this.MatrixA_DGV);
            this.Controls.Add(this.MatrixA_L);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Task 10-22";
            ((System.ComponentModel.ISupportInitialize)(this.MatrixA_DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultMatrix_DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView MatrixA_DGV;
        private System.Windows.Forms.Label MatrixA_L;
        private System.Windows.Forms.Button GenerateMatrixA_B;
        private System.Windows.Forms.DataGridView ResultMatrix_DGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Modify_B;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}


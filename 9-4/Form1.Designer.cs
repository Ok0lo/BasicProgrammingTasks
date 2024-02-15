namespace _9_4
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
            this.ArrayLength_NUD = new System.Windows.Forms.NumericUpDown();
            this.ArrayLength_L = new System.Windows.Forms.Label();
            this.ArrayA_L = new System.Windows.Forms.Label();
            this.ArrayB_L = new System.Windows.Forms.Label();
            this.ArrayBDescending_L = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MaximumValue_L = new System.Windows.Forms.Label();
            this.MaximumValue_TB = new System.Windows.Forms.TextBox();
            this.Calculate_B = new System.Windows.Forms.Button();
            this.ArrayA_DGV = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArrayB_DGV = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArrayBDescending_DGV = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArrayAAscending_DGV = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ArrayLength_NUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArrayA_DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArrayB_DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArrayBDescending_DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArrayAAscending_DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // ArrayLength_NUD
            // 
            this.ArrayLength_NUD.Location = new System.Drawing.Point(104, 12);
            this.ArrayLength_NUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ArrayLength_NUD.Name = "ArrayLength_NUD";
            this.ArrayLength_NUD.Size = new System.Drawing.Size(79, 20);
            this.ArrayLength_NUD.TabIndex = 72;
            this.ArrayLength_NUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ArrayLength_NUD.ValueChanged += new System.EventHandler(this.ArrayLength_NUD_ValueChanged);
            // 
            // ArrayLength_L
            // 
            this.ArrayLength_L.AutoSize = true;
            this.ArrayLength_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ArrayLength_L.Location = new System.Drawing.Point(14, 14);
            this.ArrayLength_L.Margin = new System.Windows.Forms.Padding(5);
            this.ArrayLength_L.Name = "ArrayLength_L";
            this.ArrayLength_L.Size = new System.Drawing.Size(82, 16);
            this.ArrayLength_L.TabIndex = 71;
            this.ArrayLength_L.Text = "Array &Length";
            // 
            // ArrayA_L
            // 
            this.ArrayA_L.AutoSize = true;
            this.ArrayA_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ArrayA_L.Location = new System.Drawing.Point(14, 56);
            this.ArrayA_L.Margin = new System.Windows.Forms.Padding(5);
            this.ArrayA_L.Name = "ArrayA_L";
            this.ArrayA_L.Size = new System.Drawing.Size(51, 16);
            this.ArrayA_L.TabIndex = 75;
            this.ArrayA_L.Text = "Array &A";
            // 
            // ArrayB_L
            // 
            this.ArrayB_L.AutoSize = true;
            this.ArrayB_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ArrayB_L.Location = new System.Drawing.Point(101, 56);
            this.ArrayB_L.Margin = new System.Windows.Forms.Padding(5);
            this.ArrayB_L.Name = "ArrayB_L";
            this.ArrayB_L.Size = new System.Drawing.Size(51, 16);
            this.ArrayB_L.TabIndex = 76;
            this.ArrayB_L.Text = "Array &B";
            // 
            // ArrayBDescending_L
            // 
            this.ArrayBDescending_L.AutoSize = true;
            this.ArrayBDescending_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ArrayBDescending_L.Location = new System.Drawing.Point(289, 40);
            this.ArrayBDescending_L.Margin = new System.Windows.Forms.Padding(5);
            this.ArrayBDescending_L.Name = "ArrayBDescending_L";
            this.ArrayBDescending_L.Size = new System.Drawing.Size(80, 32);
            this.ArrayBDescending_L.TabIndex = 82;
            this.ArrayBDescending_L.Text = "Array B\r\nDescending";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(202, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 32);
            this.label2.TabIndex = 81;
            this.label2.Text = "Array A \r\nAscending\r\n";
            // 
            // MaximumValue_L
            // 
            this.MaximumValue_L.AutoSize = true;
            this.MaximumValue_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaximumValue_L.Location = new System.Drawing.Point(202, 14);
            this.MaximumValue_L.Margin = new System.Windows.Forms.Padding(5);
            this.MaximumValue_L.Name = "MaximumValue_L";
            this.MaximumValue_L.Size = new System.Drawing.Size(102, 16);
            this.MaximumValue_L.TabIndex = 83;
            this.MaximumValue_L.Text = "Maximum Value";
            // 
            // MaximumValue_TB
            // 
            this.MaximumValue_TB.Location = new System.Drawing.Point(313, 11);
            this.MaximumValue_TB.Name = "MaximumValue_TB";
            this.MaximumValue_TB.ReadOnly = true;
            this.MaximumValue_TB.Size = new System.Drawing.Size(56, 20);
            this.MaximumValue_TB.TabIndex = 84;
            // 
            // Calculate_B
            // 
            this.Calculate_B.Location = new System.Drawing.Point(42, 232);
            this.Calculate_B.Margin = new System.Windows.Forms.Padding(5);
            this.Calculate_B.Name = "Calculate_B";
            this.Calculate_B.Size = new System.Drawing.Size(101, 29);
            this.Calculate_B.TabIndex = 85;
            this.Calculate_B.Text = "&Calculate";
            this.Calculate_B.UseVisualStyleBackColor = true;
            this.Calculate_B.Click += new System.EventHandler(this.Calculate_B_Click);
            // 
            // ArrayA_DGV
            // 
            this.ArrayA_DGV.AllowUserToAddRows = false;
            this.ArrayA_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ArrayA_DGV.ColumnHeadersVisible = false;
            this.ArrayA_DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.ArrayA_DGV.Location = new System.Drawing.Point(17, 80);
            this.ArrayA_DGV.Name = "ArrayA_DGV";
            this.ArrayA_DGV.RowHeadersVisible = false;
            this.ArrayA_DGV.RowTemplate.Height = 21;
            this.ArrayA_DGV.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ArrayA_DGV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ArrayA_DGV.Size = new System.Drawing.Size(79, 144);
            this.ArrayA_DGV.TabIndex = 86;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.Width = 76;
            // 
            // ArrayB_DGV
            // 
            this.ArrayB_DGV.AllowUserToAddRows = false;
            this.ArrayB_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ArrayB_DGV.ColumnHeadersVisible = false;
            this.ArrayB_DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.ArrayB_DGV.Location = new System.Drawing.Point(104, 80);
            this.ArrayB_DGV.Name = "ArrayB_DGV";
            this.ArrayB_DGV.RowHeadersVisible = false;
            this.ArrayB_DGV.RowTemplate.Height = 21;
            this.ArrayB_DGV.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ArrayB_DGV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ArrayB_DGV.Size = new System.Drawing.Size(79, 144);
            this.ArrayB_DGV.TabIndex = 87;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Column1";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 76;
            // 
            // ArrayBDescending_DGV
            // 
            this.ArrayBDescending_DGV.AllowUserToAddRows = false;
            this.ArrayBDescending_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ArrayBDescending_DGV.ColumnHeadersVisible = false;
            this.ArrayBDescending_DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2});
            this.ArrayBDescending_DGV.Location = new System.Drawing.Point(292, 80);
            this.ArrayBDescending_DGV.Name = "ArrayBDescending_DGV";
            this.ArrayBDescending_DGV.ReadOnly = true;
            this.ArrayBDescending_DGV.RowHeadersVisible = false;
            this.ArrayBDescending_DGV.RowTemplate.Height = 21;
            this.ArrayBDescending_DGV.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ArrayBDescending_DGV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ArrayBDescending_DGV.Size = new System.Drawing.Size(79, 144);
            this.ArrayBDescending_DGV.TabIndex = 89;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Column1";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 76;
            // 
            // ArrayAAscending_DGV
            // 
            this.ArrayAAscending_DGV.AllowUserToAddRows = false;
            this.ArrayAAscending_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ArrayAAscending_DGV.ColumnHeadersVisible = false;
            this.ArrayAAscending_DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3});
            this.ArrayAAscending_DGV.Location = new System.Drawing.Point(205, 80);
            this.ArrayAAscending_DGV.Name = "ArrayAAscending_DGV";
            this.ArrayAAscending_DGV.ReadOnly = true;
            this.ArrayAAscending_DGV.RowHeadersVisible = false;
            this.ArrayAAscending_DGV.RowTemplate.Height = 21;
            this.ArrayAAscending_DGV.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ArrayAAscending_DGV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ArrayAAscending_DGV.Size = new System.Drawing.Size(79, 144);
            this.ArrayAAscending_DGV.TabIndex = 88;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Column1";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 76;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 272);
            this.Controls.Add(this.ArrayBDescending_DGV);
            this.Controls.Add(this.ArrayAAscending_DGV);
            this.Controls.Add(this.ArrayB_DGV);
            this.Controls.Add(this.ArrayA_DGV);
            this.Controls.Add(this.Calculate_B);
            this.Controls.Add(this.MaximumValue_TB);
            this.Controls.Add(this.MaximumValue_L);
            this.Controls.Add(this.ArrayBDescending_L);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ArrayB_L);
            this.Controls.Add(this.ArrayA_L);
            this.Controls.Add(this.ArrayLength_NUD);
            this.Controls.Add(this.ArrayLength_L);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Task 9-4";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ArrayLength_NUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArrayA_DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArrayB_DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArrayBDescending_DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArrayAAscending_DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown ArrayLength_NUD;
        private System.Windows.Forms.Label ArrayLength_L;
        private System.Windows.Forms.Label ArrayA_L;
        private System.Windows.Forms.Label ArrayB_L;
        private System.Windows.Forms.Label ArrayBDescending_L;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label MaximumValue_L;
        private System.Windows.Forms.TextBox MaximumValue_TB;
        private System.Windows.Forms.Button Calculate_B;
        private System.Windows.Forms.DataGridView ArrayA_DGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridView ArrayB_DGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView ArrayBDescending_DGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridView ArrayAAscending_DGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}


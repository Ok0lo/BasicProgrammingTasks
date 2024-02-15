namespace _8_4
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
            this.PeopleWriteAmount_NUD = new System.Windows.Forms.NumericUpDown();
            this.PeopleWriteAmount_L = new System.Windows.Forms.Label();
            this.WritePeopleList_L = new System.Windows.Forms.Label();
            this.WritePeopleList_DGV = new System.Windows.Forms.DataGridView();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LivingCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaveList_B = new System.Windows.Forms.Button();
            this.FindedPeopleList_L = new System.Windows.Forms.Label();
            this.FindedPeopleList_DGV = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FindedAverageAgePeople_L = new System.Windows.Forms.Label();
            this.SearchCityTarget_L = new System.Windows.Forms.Label();
            this.SearchCityTarget_TB = new System.Windows.Forms.TextBox();
            this.LoadAndFind_B = new System.Windows.Forms.Button();
            this.FindedAverageAgePeople_TB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PeopleWriteAmount_NUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WritePeopleList_DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FindedPeopleList_DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // PeopleWriteAmount_NUD
            // 
            this.PeopleWriteAmount_NUD.Location = new System.Drawing.Point(155, 10);
            this.PeopleWriteAmount_NUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PeopleWriteAmount_NUD.Name = "PeopleWriteAmount_NUD";
            this.PeopleWriteAmount_NUD.Size = new System.Drawing.Size(59, 20);
            this.PeopleWriteAmount_NUD.TabIndex = 70;
            this.PeopleWriteAmount_NUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PeopleWriteAmount_NUD.ValueChanged += new System.EventHandler(this.PeopleWriteAmount_NUD_ValueChanged);
            // 
            // PeopleWriteAmount_L
            // 
            this.PeopleWriteAmount_L.AutoSize = true;
            this.PeopleWriteAmount_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PeopleWriteAmount_L.Location = new System.Drawing.Point(14, 14);
            this.PeopleWriteAmount_L.Margin = new System.Windows.Forms.Padding(5);
            this.PeopleWriteAmount_L.Name = "PeopleWriteAmount_L";
            this.PeopleWriteAmount_L.Size = new System.Drawing.Size(133, 16);
            this.PeopleWriteAmount_L.TabIndex = 69;
            this.PeopleWriteAmount_L.Text = "People Write &Amount";
            // 
            // WritePeopleList_L
            // 
            this.WritePeopleList_L.AutoSize = true;
            this.WritePeopleList_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WritePeopleList_L.Location = new System.Drawing.Point(14, 40);
            this.WritePeopleList_L.Margin = new System.Windows.Forms.Padding(5);
            this.WritePeopleList_L.Name = "WritePeopleList_L";
            this.WritePeopleList_L.Size = new System.Drawing.Size(108, 16);
            this.WritePeopleList_L.TabIndex = 72;
            this.WritePeopleList_L.Text = "&Write People List";
            // 
            // WritePeopleList_DGV
            // 
            this.WritePeopleList_DGV.AllowUserToAddRows = false;
            this.WritePeopleList_DGV.AllowUserToDeleteRows = false;
            this.WritePeopleList_DGV.AllowUserToOrderColumns = true;
            this.WritePeopleList_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WritePeopleList_DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Surname,
            this.LivingCity,
            this.Age});
            this.WritePeopleList_DGV.Location = new System.Drawing.Point(17, 64);
            this.WritePeopleList_DGV.Name = "WritePeopleList_DGV";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.WritePeopleList_DGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.WritePeopleList_DGV.RowHeadersVisible = false;
            this.WritePeopleList_DGV.RowTemplate.DefaultCellStyle.NullValue = null;
            this.WritePeopleList_DGV.Size = new System.Drawing.Size(304, 206);
            this.WritePeopleList_DGV.TabIndex = 73;
            // 
            // Surname
            // 
            this.Surname.HeaderText = "Surname";
            this.Surname.Name = "Surname";
            // 
            // LivingCity
            // 
            this.LivingCity.HeaderText = "Living City";
            this.LivingCity.Name = "LivingCity";
            // 
            // Age
            // 
            this.Age.HeaderText = "Age";
            this.Age.Name = "Age";
            // 
            // SaveList_B
            // 
            this.SaveList_B.Location = new System.Drawing.Point(17, 278);
            this.SaveList_B.Margin = new System.Windows.Forms.Padding(5);
            this.SaveList_B.Name = "SaveList_B";
            this.SaveList_B.Size = new System.Drawing.Size(94, 26);
            this.SaveList_B.TabIndex = 74;
            this.SaveList_B.Text = "&Save List";
            this.SaveList_B.UseVisualStyleBackColor = true;
            this.SaveList_B.Click += new System.EventHandler(this.SaveList_B_Click);
            // 
            // FindedPeopleList_L
            // 
            this.FindedPeopleList_L.AutoSize = true;
            this.FindedPeopleList_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FindedPeopleList_L.Location = new System.Drawing.Point(335, 40);
            this.FindedPeopleList_L.Margin = new System.Windows.Forms.Padding(5);
            this.FindedPeopleList_L.Name = "FindedPeopleList_L";
            this.FindedPeopleList_L.Size = new System.Drawing.Size(119, 16);
            this.FindedPeopleList_L.TabIndex = 75;
            this.FindedPeopleList_L.Text = "&Finded People List";
            // 
            // FindedPeopleList_DGV
            // 
            this.FindedPeopleList_DGV.AllowUserToAddRows = false;
            this.FindedPeopleList_DGV.AllowUserToDeleteRows = false;
            this.FindedPeopleList_DGV.AllowUserToOrderColumns = true;
            this.FindedPeopleList_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FindedPeopleList_DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.FindedPeopleList_DGV.Location = new System.Drawing.Point(338, 64);
            this.FindedPeopleList_DGV.Name = "FindedPeopleList_DGV";
            this.FindedPeopleList_DGV.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FindedPeopleList_DGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.FindedPeopleList_DGV.RowHeadersVisible = false;
            this.FindedPeopleList_DGV.RowTemplate.DefaultCellStyle.NullValue = null;
            this.FindedPeopleList_DGV.Size = new System.Drawing.Size(304, 206);
            this.FindedPeopleList_DGV.TabIndex = 76;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Surname";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Living City";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Age";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // FindedAverageAgePeople_L
            // 
            this.FindedAverageAgePeople_L.AutoSize = true;
            this.FindedAverageAgePeople_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FindedAverageAgePeople_L.Location = new System.Drawing.Point(335, 277);
            this.FindedAverageAgePeople_L.Margin = new System.Windows.Forms.Padding(5);
            this.FindedAverageAgePeople_L.Name = "FindedAverageAgePeople_L";
            this.FindedAverageAgePeople_L.Size = new System.Drawing.Size(179, 16);
            this.FindedAverageAgePeople_L.TabIndex = 77;
            this.FindedAverageAgePeople_L.Text = "Finded Average &Age People";
            // 
            // SearchCityTarget_L
            // 
            this.SearchCityTarget_L.AutoSize = true;
            this.SearchCityTarget_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchCityTarget_L.Location = new System.Drawing.Point(335, 14);
            this.SearchCityTarget_L.Margin = new System.Windows.Forms.Padding(5);
            this.SearchCityTarget_L.Name = "SearchCityTarget_L";
            this.SearchCityTarget_L.Size = new System.Drawing.Size(118, 16);
            this.SearchCityTarget_L.TabIndex = 79;
            this.SearchCityTarget_L.Text = "&Search City Target";
            // 
            // SearchCityTarget_TB
            // 
            this.SearchCityTarget_TB.Location = new System.Drawing.Point(462, 12);
            this.SearchCityTarget_TB.Name = "SearchCityTarget_TB";
            this.SearchCityTarget_TB.Size = new System.Drawing.Size(94, 20);
            this.SearchCityTarget_TB.TabIndex = 80;
            // 
            // LoadAndFind_B
            // 
            this.LoadAndFind_B.Location = new System.Drawing.Point(564, 12);
            this.LoadAndFind_B.Margin = new System.Windows.Forms.Padding(5);
            this.LoadAndFind_B.Name = "LoadAndFind_B";
            this.LoadAndFind_B.Size = new System.Drawing.Size(78, 29);
            this.LoadAndFind_B.TabIndex = 81;
            this.LoadAndFind_B.Text = "Load && &Find";
            this.LoadAndFind_B.UseVisualStyleBackColor = true;
            this.LoadAndFind_B.Click += new System.EventHandler(this.LoadAndFind_B_Click);
            // 
            // FindedAverageAgePeople_TB
            // 
            this.FindedAverageAgePeople_TB.Location = new System.Drawing.Point(522, 276);
            this.FindedAverageAgePeople_TB.Name = "FindedAverageAgePeople_TB";
            this.FindedAverageAgePeople_TB.ReadOnly = true;
            this.FindedAverageAgePeople_TB.Size = new System.Drawing.Size(120, 20);
            this.FindedAverageAgePeople_TB.TabIndex = 82;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 315);
            this.Controls.Add(this.FindedAverageAgePeople_TB);
            this.Controls.Add(this.LoadAndFind_B);
            this.Controls.Add(this.SearchCityTarget_TB);
            this.Controls.Add(this.SearchCityTarget_L);
            this.Controls.Add(this.FindedAverageAgePeople_L);
            this.Controls.Add(this.FindedPeopleList_DGV);
            this.Controls.Add(this.FindedPeopleList_L);
            this.Controls.Add(this.SaveList_B);
            this.Controls.Add(this.WritePeopleList_DGV);
            this.Controls.Add(this.WritePeopleList_L);
            this.Controls.Add(this.PeopleWriteAmount_NUD);
            this.Controls.Add(this.PeopleWriteAmount_L);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Task 8-4";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PeopleWriteAmount_NUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WritePeopleList_DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FindedPeopleList_DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown PeopleWriteAmount_NUD;
        private System.Windows.Forms.Label PeopleWriteAmount_L;
        private System.Windows.Forms.Label WritePeopleList_L;
        private System.Windows.Forms.DataGridView WritePeopleList_DGV;
        private System.Windows.Forms.Button SaveList_B;
        private System.Windows.Forms.Label FindedPeopleList_L;
        private System.Windows.Forms.DataGridView FindedPeopleList_DGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn LivingCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label FindedAverageAgePeople_L;
        private System.Windows.Forms.Label SearchCityTarget_L;
        private System.Windows.Forms.TextBox SearchCityTarget_TB;
        private System.Windows.Forms.Button LoadAndFind_B;
        private System.Windows.Forms.TextBox FindedAverageAgePeople_TB;
    }
}


using System;
using System.Windows.Forms;

namespace _5_22 {

    public partial class Form1 : Form {

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            Matrix_DGV.RowCount = Convert.ToInt32(RowAmount_NUD.Value);
            Matrix_DGV.ColumnCount = Convert.ToInt32(ColumnAmount_NUD.Value);
        }

        private void RowAmount_NUD_ValueChanged(object sender, EventArgs e) {
            Matrix_DGV.RowCount = Convert.ToInt32(RowAmount_NUD.Value);
        }

        private void ColumnAmount_NUD_ValueChanged(object sender, EventArgs e) {
            Matrix_DGV.ColumnCount = Convert.ToInt32(ColumnAmount_NUD.Value);
        }

        private void Calculate_B_Click(object sender, EventArgs e) {
            int n = Matrix_DGV.ColumnCount;
            int m = Matrix_DGV.RowCount;
            int columnBiggestNegativeAmount = int.MinValue, columnBiggestNegativeAmountIndex = 0;
            for (int i = 0; i < n; i++) {
                int columnNegativeAmount = 0;
                for (int j = 0; j < m; j++) {
                    int matrixValue = Convert.ToInt32(Matrix_DGV[i, j].Value);
                    if (matrixValue < 0) {
                        columnNegativeAmount++;
                    }
                }

                if (columnNegativeAmount > columnBiggestNegativeAmount) {
                    columnBiggestNegativeAmount = columnNegativeAmount;
                    columnBiggestNegativeAmountIndex = i + 1;
                }
            }

            if (columnBiggestNegativeAmount > 0) {
                ColumnNumber_TB.Text = columnBiggestNegativeAmountIndex.ToString();
            } else {
                ColumnNumber_TB.Text = "No items found";
            }
        }

    }

}

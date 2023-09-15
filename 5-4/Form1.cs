using System;
using System.Windows.Forms;

namespace _5_4 {

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
            for (int i = 0; i < Matrix_DGV.ColumnCount; i++) {
                for (int j = 0; j < Matrix_DGV.RowCount; j++) {
                    int[] array = new int[] { i + 1, j + 1, n - i + 2, m - j + 2 };
                    Matrix_DGV[i, j].Value = FindMin(array);
                }
            }
        }

        private int FindMin(int[] array) {
            int smallest = int.MaxValue;
            foreach (int value in array) {
                if (value < smallest) { 
                    smallest = value;
                }
            }

            return smallest;
        }

    }

}

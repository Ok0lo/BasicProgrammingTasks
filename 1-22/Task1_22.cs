using System;
using System.Windows.Forms;

namespace _1_22 {

    public partial class Task1_22 : Form {

        public Task1_22() {
            InitializeComponent();
        }

        private void Task1_22_Load(object sender, EventArgs e) {}

        private void Calculate_B_Click(object sender, EventArgs e) {
            if (IsAllTextBoxesFilled() == false) {
                Result_TB.Text = "Fill in all Text Boxes!";
                return;
            }

            int width = Convert.ToInt32(Width_TB.Text);
            int height = Convert.ToInt32(Height_TB.Text);
            int a = Convert.ToInt32(A_TB.Text);
            int b = Convert.ToInt32(B_TB.Text);

            float rectangleSquare = width * height;
            float trapezoidSquare = ((a + b) / 2f) * 2f;

            Result_TB.Text = $"{trapezoidSquare / rectangleSquare}";
        }

        private bool IsAllTextBoxesFilled() {
            if (Width_TB.Text.Length == 0) return false;
            if (Height_TB.Text.Length == 0) return false;
            if (A_TB.Text.Length == 0) return false;
            if (B_TB.Text.Length == 0) return false;

            return true;
        }

    }

}

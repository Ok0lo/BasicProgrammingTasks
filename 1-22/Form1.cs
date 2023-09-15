using System;
using System.Windows.Forms;

namespace _1_22 {

    public partial class Form1 : Form {

        public Form1() {
            InitializeComponent();
        }

        private void Calculate_B_Click(object sender, EventArgs e) {
            double width = Convert.ToDouble(Width_TB.Text);
            double height = Convert.ToDouble(Height_TB.Text);
            double a = Convert.ToDouble(A_TB.Text);
            double b = Convert.ToDouble(B_TB.Text);

            double rectangleSquare = width * height;
            double trapezoidSquare = ((a + b) / 2f) * height;
            double proportion = trapezoidSquare / rectangleSquare;

            Result_TB.Text = proportion.ToString();
        }

    }

}

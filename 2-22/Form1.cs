using System;
using System.Windows.Forms;

namespace _2_22 {

    public partial class Form1 : Form {

        public Form1() {
            InitializeComponent();
        }

        private void Calculate_B_Click(object sender, EventArgs e) {
            double x = Convert.ToDouble(X_TB.Text);
            double y = Convert.ToDouble(Y_TB.Text);

            double k = Math.Pow(0.273f * Math.Log10(x), 1.573f * Math.Log10(y));
            double p = Math.Tan(Math.Log10(Math.Pow(Math.Log10(y / x), 1f / 7f)));
            double l = CalculateL(k, p);

            K_TB.Text = k.ToString();
            P_TB.Text = p.ToString();
            L_TB.Text = l.ToString();
        }

        private double CalculateL(double k, double p) {
            if (k < Math.Abs(p)) {
                return Math.Abs(k - p);
            }

            return (7f * k - 5f * p) / (2f * (k * k) + 3f * (p * p));
        }

    }

}

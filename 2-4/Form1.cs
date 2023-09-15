using System;
using System.Windows.Forms;

namespace _2_4 {
    
    public partial class Form1 : Form {

        public Form1() {
            InitializeComponent();
        }

        private void Calculate_B_Click(object sender, EventArgs e) {
            double x = Convert.ToDouble(X_TB.Text);
            double y = Convert.ToDouble(Y_TB.Text);

            double a = 
                (Math.Cos(x) / (4 - Math.Pow(11f, 1f / 4f))) +
                (Math.Sin(Math.Pow(y, .3f) / (3f + Math.Sqrt(7f))));
            double b =
                2f * (Math.Sin(x / y) + Math.Cos(y / x) * Math.Log10(Math.Abs(x - y) + 1));
            double c;
            if (Math.Abs(a) <= 2f *Math.Abs(b)) {
                c = Math.Sqrt(3f * (a * a) + 4f * (b * b));
            } else {
                c = Math.Sqrt(3f * (a * a) - 4f * (b * b));
            }

            A_TB.Text = a.ToString();
            B_TB.Text = b.ToString();
            C_TB.Text = c.ToString();
        }
    }

}

using System;
using System.Windows.Forms;

namespace _3_22 {

    public partial class Form1 : Form {

        public Form1() {
            InitializeComponent();
        }

        private void Calculate1_B_Click(object sender, EventArgs e) {
            double x = Convert.ToDouble(X_TB.Text);
            int n = Convert.ToInt32(N_TB.Text);

            double sum = 0f;
            for (int i = 1; i <= n; i++) {
                int divider = 2 * i + 1;

                int dividerFactorial = 1;
                for (int j = 2; j <= divider; j++) {
                    dividerFactorial *= j;
                }

                double sx = x;
                for (int j = 2; j <= 2 * i; j++) {
                    sx *= x;
                }

                double dividend = ((i + 1) % 2 == 0 ? 1 : -1) * (7f - sx);

                double result = dividend / divider;
                sum += result;
            }

            Result1_TB.Text = sum.ToString();
        }

        private void Calculate2_B_Click(object sender, EventArgs eventArgs) {
            double x = Convert.ToDouble(X_TB.Text);
            double e = Convert.ToDouble(E_TB.Text);

            int i = 1;
            double result = 1f, sum = 0f;
            while (result >= e) {
                int divider = 2 * i + 1;

                int dividerFactorial = 1;
                for (int j = 2; j <= divider; j++) {
                    dividerFactorial *= j;
                }

                double sx = x;
                for (int j = 2; j <= 2 * i; j++) {
                    sx *= x;
                }

                double dividend = ((i + 1) % 2 == 0 ? 1 : -1) * (7f - sx);

                result = dividend / divider;
                sum += result;

                i++;
            }

            Result2_TB.Text = sum.ToString();
        }

    }

}

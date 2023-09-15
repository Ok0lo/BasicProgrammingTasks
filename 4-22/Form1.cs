using System;
using System.Windows.Forms;

namespace _4_22 {

    public partial class Form1 : Form {

        public Form1() {
            InitializeComponent();
        }

        private void Calculate1_B_Click(object sender, EventArgs e) {
            int arrayCount = Array_TB.Lines.Length;
            double[] array = new double[arrayCount];

            for (int i = 0; i < array.Length; i++) {
                array[i] = Convert.ToDouble(Array_TB.Lines[i]);
            }

            for (int i = 0; i < array.Length; i++) {
                int arrayWholePart = (int)array[i];
                int newArrayValue = Math.Abs(arrayWholePart) % 3;

                array[i] = newArrayValue;
            }

            CalculatedArray_TB.Clear();
            for (int i = 0; i < array.Length; i++) {
                CalculatedArray_TB.AppendText(array[i] + Environment.NewLine);
            }
        }

    }

}

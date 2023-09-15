using System;
using System.Windows.Forms;

namespace _4_4 {

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
                string arrayStringValue = array[i].ToString();

                if (arrayStringValue.Contains("0") == false) continue;

                double halfSum = CalculateHalfSumAtIndex(array, i);                
                string convertedArrayValue = arrayStringValue.Replace("0", halfSum.ToString());

                array[i] = Convert.ToDouble(convertedArrayValue);
            }

            CalculatedArray_TB.Clear();
            for (int i = 0; i < array.Length; i++) {
                CalculatedArray_TB.AppendText(array[i] + Environment.NewLine);
            }
        }

        private double CalculateHalfSumAtIndex(double[] array, int i) {
            double previousValue, nextValue;

            if (i == 0) return array[i + 1] * .5f;
            if (i == array.Length - 1) return array[i - 1] * .5f;

            previousValue = array[i - 1];
            nextValue = array[i + 1];

            return (previousValue + nextValue) / 2f;
        }

    }

}

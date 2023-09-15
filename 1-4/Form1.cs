using System;
using System.Windows.Forms;

namespace _1_4 {

    public partial class Form1 : Form {

        public Form1() {
            InitializeComponent();
        }

        private void Calculate_B_Click(object sender, System.EventArgs e) {
            double lenght = Convert.ToDouble(Length_TB.Text);
            double bigR = Convert.ToDouble(BigR_TB.Text);
            double smallR = Convert.ToDouble(SmallR_TB.Text);
            double p = Convert.ToDouble(P_TB.Text);

            double volume = lenght * Math.PI * (bigR * bigR - smallR * smallR);
            double weight = volume * p;

            Volume_TB.Text = volume.ToString();
            Weight_TB.Text = weight.ToString();
        }

    }

}

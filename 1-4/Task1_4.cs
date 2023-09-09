using System;
using System.Windows.Forms;

namespace _1_4 {

    public partial class Task1_4 : Form {

        public Task1_4() {
            InitializeComponent();
        }

        private void Task1_4_Load(object sender, EventArgs e) { }

        private void Calculate_B_Click(object sender, System.EventArgs e) {
            if (IsAllTextBoxesFilled() == false) return;

            int lenght = Convert.ToInt32(Length_TB.Text);
            int bigR = Convert.ToInt32(BigR_TB.Text);
            int smallR = Convert.ToInt32(SmallR_TB.Text);
            int p = Convert.ToInt32(P_TB.Text);

            double volume = lenght * Math.PI * (bigR * bigR - smallR * smallR);
            double weight = volume * p;

            Volume_TB.Text = volume.ToString();
            Weight_TB.Text = weight.ToString();
        }

        private bool IsAllTextBoxesFilled() {
            if (Length_TB.Text.Length == 0) return false;
            if (BigR_TB.Text.Length == 0) return false;
            if (SmallR_TB.Text.Length == 0) return false;
            if (P_TB.Text.Length == 0) return false;

            return true;
        }

    }

}

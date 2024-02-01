using System;
using System.Windows.Forms;

namespace _6_22
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Calculate_B_Click(object sender, EventArgs e)
        {
            string sourceString = SourceString_TB.Text;

            var sourceWordArray = sourceString.Split(' ');
            string resultString = String.Empty;
            for (int i = 0; i < sourceWordArray.Length; i++)
            {
                resultString += sourceWordArray[i][0] + " ";
            }

            resultString = resultString.TrimEnd(' ');

            Result_TB.Text = resultString;
        }

    }

}

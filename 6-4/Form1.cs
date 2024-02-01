using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Task_6_4
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Calculate_B_Click(object sender, EventArgs e)
        {
            string targetXXPart = TargetXXPart_TB.Text;

            int sourceStringArrayLength = SourceStringArray_TB.Lines.Length;
            var sourceStringArray = new string[sourceStringArrayLength];
            for (int i = 0; i < sourceStringArray.Length; i++)
            {
                sourceStringArray[i] = SourceStringArray_TB.Lines[i];
            }

            var matchedStringList = new List<string>();
            for (int i = 0; i < sourceStringArray.Length; i++)
            {
                if (sourceStringArray[i].StartsWith(targetXXPart))
                {
                    matchedStringList.Add(sourceStringArray[i]);
                }
            }

            if (matchedStringList.Count == 0)
            {
                Result_TB.Text = "Элементов нет";
                return;
            }

            int zSum = 0;
            for (int i = 0; i < matchedStringList.Count ; i++)
            {
                int YY = Convert.ToInt32(matchedStringList[i].Remove(0, 3));
                zSum += YY - 50;
            }

            Result_TB.Text = zSum.ToString();
        }

    }

}

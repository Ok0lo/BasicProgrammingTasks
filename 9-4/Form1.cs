using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _9_4
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateArrayAB_DGV();
        }

        private void ArrayLength_NUD_ValueChanged(object sender, EventArgs e)
        {
            UpdateArrayAB_DGV();
        }

        private void Calculate_B_Click(object sender, EventArgs e)
        {
            var listA = DataGridViewReadShow.ReadList(ArrayA_DGV);
            var listB = DataGridViewReadShow.ReadList(ArrayB_DGV);

            var ascendingListA = ListManipulator.SortAscending(listA);
            var descendingListB = ListManipulator.SortDescending(listB);

            var sumedListAB = ListManipulator.SumTwoListsWithSameLength(listA, listB);
            int maxValueInListsAB = ListManipulator.FindMaxValue(sumedListAB);

            ShowResult(ascendingListA, descendingListB, maxValueInListsAB);
        }

        private void UpdateArrayAB_DGV()
        {
            ArrayA_DGV.RowCount = (int)ArrayLength_NUD.Value;
            ArrayB_DGV.RowCount = (int)ArrayLength_NUD.Value;
        }

        private void ShowResult(List<int> ascendingListA, List<int> descendingListB, int maxValueInListsAB)
        {
            DataGridViewReadShow.ShowList(ArrayAAscending_DGV, ascendingListA);
            DataGridViewReadShow.ShowList(ArrayBDescending_DGV, descendingListB);

            MaximumValue_TB.Text = $"{maxValueInListsAB}";
        }

    }

}

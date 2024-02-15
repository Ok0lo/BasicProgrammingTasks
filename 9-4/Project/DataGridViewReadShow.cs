using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _9_4
{
    public static class DataGridViewReadShow
    {

        public static List<int> ReadList(DataGridView dataGridView)
        {
            var intList = new List<int>();
            for (int i = 0; i < dataGridView.RowCount; i++)
            {
                intList.Add(Convert.ToInt32(dataGridView[0, i].Value));
            }

            return intList;
        }

        public static void ShowList(DataGridView dataGridView, List<int> intList)
        {
            dataGridView.RowCount = intList.Count;
            for (int i = 0; i < intList.Count; i++)
            {
                dataGridView[0, i].Value = $"{intList[i]}";
            }
        }

        public static void Clear(DataGridView dataGridView)
        {
            dataGridView.RowCount = 0;
        }

    }

}

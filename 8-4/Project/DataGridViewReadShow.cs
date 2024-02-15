using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _8_4
{
    public static class DataGridViewReadShow
    {

        public static List<People> ReadPeopleList(DataGridView peopleDataGridView)
        {
            var peopleList = new List<People>();
            var peopleTemp = new People();
            for (int i = 0; i < peopleDataGridView.RowCount; i++)
            {
                peopleTemp.Surname = Convert.ToString(peopleDataGridView[0, i].Value);
                peopleTemp.LivingCity = Convert.ToString(peopleDataGridView[1, i].Value);
                peopleTemp.Age = Convert.ToInt32(peopleDataGridView[2, i].Value);

                peopleList.Add(peopleTemp);
            }

            return peopleList;
        }

        public static void ShowPeopleList(DataGridView peopleDataGridView, List<People> peopleList)
        {
            peopleDataGridView.RowCount = peopleList.Count;
            for (int i = 0; i < peopleList.Count; i++)
            {
                peopleDataGridView[0, i].Value = peopleList[i].Surname;
                peopleDataGridView[1, i].Value = peopleList[i].LivingCity;
                peopleDataGridView[2, i].Value = peopleList[i].Age;
            }
        }

        public static void Clear(DataGridView dataGridView)
        {
            dataGridView.RowCount = 0;
        }

    }

}

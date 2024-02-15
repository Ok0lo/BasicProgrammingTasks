using System;
using System.Windows.Forms;

namespace _8_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateWritePeopleList_DGV();
        }

        private void PeopleWriteAmount_NUD_ValueChanged(object sender, EventArgs e)
        {
            UpdateWritePeopleList_DGV();
        }

        private void SaveList_B_Click(object sender, EventArgs e)
        {
            var savePeopleList = DataGridViewReadShow.ReadPeopleList(WritePeopleList_DGV);
            SaveLoadPeopleData.Save(savePeopleList);
        }

        private void LoadAndFind_B_Click(object sender, EventArgs e)
        {
            var loadedPeopleList = SaveLoadPeopleData.Load();
            string targetCity = SearchCityTarget_TB.Text;
            var filtredPeopleList = PeopleListManipulator.FilterPeopleListByCity(loadedPeopleList, targetCity);

            DataGridViewReadShow.Clear(FindedPeopleList_DGV);
            if (filtredPeopleList.Count > 0)
            {
                DataGridViewReadShow.ShowPeopleList(FindedPeopleList_DGV, filtredPeopleList);

                var averagePeopleAge = PeopleListManipulator.CalculateAveragePeopleAge(filtredPeopleList);
                FindedAverageAgePeople_TB.Text = Convert.ToString(averagePeopleAge);
            } else
            {
                FindedAverageAgePeople_TB.Text = "Not Found";
            }
        }

        private void UpdateWritePeopleList_DGV()
        {
            WritePeopleList_DGV.RowCount = Convert.ToInt32(PeopleWriteAmount_NUD.Value);
        }

    }

}

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _7_4
{

    public partial class Form1 : Form
    {

        private const int VECTOR_AMOUNT = 3;

        private int _vectorsLenght;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ResultArray_DGV.RowCount = VECTOR_AMOUNT * (VECTOR_AMOUNT - 1);
            UpdateXYZDataGridView();
        }

        private void VectorLength_NUD_ValueChanged(object sender, EventArgs e)
        {
            UpdateXYZDataGridView();
        }

        private void Calculate_B_Click(object sender, EventArgs e)
        {
            int[][] vectorArray = new int[VECTOR_AMOUNT][];
            for (int i = 0; i < vectorArray.Length; i++)
            {
                vectorArray[i] = new int[_vectorsLenght];
            }

            for (int i = 0; i < _vectorsLenght; i++)
            {
                vectorArray[0][i] = Convert.ToInt32(XVector_DGV[0, i].Value);
                vectorArray[1][i] = Convert.ToInt32(YVector_DGV[0, i].Value);
                vectorArray[2][i] = Convert.ToInt32(ZVector_DGV[0, i].Value);
            }

            var resultList = new List<string>();
            for (int i = 0; i < VECTOR_AMOUNT; i++)
            {
                for (int j = i; j < VECTOR_AMOUNT; j++)
                {
                    resultList.Add(FindScalarProduct(vectorArray[i], vectorArray[j]).ToString());
                }
            }

            for (int i = 0; i < resultList.Count; i++) 
            {
                ResultArray_DGV[0, i].Value = resultList[i];
            }
        }

        private void UpdateXYZDataGridView()
        {
            _vectorsLenght = Convert.ToInt32(VectorLength_NUD.Value);
            XVector_DGV.RowCount = YVector_DGV.RowCount = ZVector_DGV.RowCount = _vectorsLenght;
        }

        private double FindScalarProduct(int[] firstVector, int[] secondVector)
        {
            double scalarProductArray = 0f;
            for (int i = 0; i < _vectorsLenght; i++)
            {
                scalarProductArray += firstVector[i] * secondVector[i];
            }

            return scalarProductArray;
        }

    }

}

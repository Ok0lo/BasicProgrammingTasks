using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7_22
{
    public partial class Form1 : Form
    {

        private const int MATRIX_AMOUNT = 3;

        private int _matrixLength;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateAllMatrixDataGridView();
        }

        private void MatrixLength_NUD_ValueChanged(object sender, EventArgs e)
        {
            UpdateAllMatrixDataGridView();
        }

        private void Calculate_B_Click(object sender, EventArgs e)
        {
            int[][,] matrixArray = new int[MATRIX_AMOUNT][,];
            for (int i = 0; i < matrixArray.Length; i++)
            {
                matrixArray[i] = new int[_matrixLength, _matrixLength];
            }

            for (int i = 0; i < _matrixLength; i++)
            {
                for (int j = 0; j < _matrixLength; j++)
                {
                    matrixArray[0][i, j] = Convert.ToInt32(MatrixA_DGV[i, j].Value);
                    matrixArray[1][i, j] = Convert.ToInt32(MatrixB_DGV[i, j].Value);
                    matrixArray[2][i, j] = Convert.ToInt32(MatrixC_DGV[i, j].Value);
                }
            }

            var positiveNumbersAmountArray = new int[MATRIX_AMOUNT];
            for (int i = 0; i < positiveNumbersAmountArray.Length; i++)
            {
                positiveNumbersAmountArray[i] = FindPositiveNumbersUnderMainDiagonalAmount(matrixArray[i]);
            }

            int biggestAmountMatrixIndex = 0;
            int biggestAmount = positiveNumbersAmountArray[0];
            for (int i = 1; i < positiveNumbersAmountArray.Length; i++)
            {
                if (biggestAmount < positiveNumbersAmountArray[i])
                {
                    biggestAmountMatrixIndex = i;
                    biggestAmount = positiveNumbersAmountArray[i];
                }
            }

            var matrixCharDictionary = new Dictionary<int, char>
            {
                { 0, 'A' },
                { 1, 'B' },
                { 2, 'C' }
            };

            Result_TB.Text = matrixCharDictionary[biggestAmountMatrixIndex].ToString();
        }

        private void UpdateAllMatrixDataGridView()
        {
            _matrixLength = Convert.ToInt32(MatrixLength_NUD.Value);
            MatrixA_DGV.RowCount = MatrixA_DGV.ColumnCount = _matrixLength;
            MatrixB_DGV.RowCount = MatrixB_DGV.ColumnCount = _matrixLength;
            MatrixC_DGV.RowCount = MatrixC_DGV.ColumnCount = _matrixLength;
        }

        private int FindPositiveNumbersUnderMainDiagonalAmount(int[,] matrix)
        {
            int amount = 0;

            for (int x = 0; x < _matrixLength; x++)
            {
                for (int y = x + 1; y < _matrixLength; y++)
                {
                    int value = matrix[x, y];
                    if (value > 0)
                    {
                        amount++;
                    }
                }
            }

            return amount;
        }

    }

}

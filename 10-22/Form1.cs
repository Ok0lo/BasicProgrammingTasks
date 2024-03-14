using System;
using System.Windows.Forms;

namespace _10_22
{

    public partial class Form1 : Form
    {

        private int _matrixSize;

        public Form1()
        {
            InitializeComponent();
        }

        private void GenerateMatrixA_B_Click(object sender, EventArgs e)
        {
            var random = new Random();

            _matrixSize = random.Next(2, 6 + 1);
            MatrixA_DGV.ColumnCount = MatrixA_DGV.RowCount = _matrixSize;
            for (int i = 0; i < _matrixSize; i++)
            {
                for (int j = 0; j < _matrixSize; j++)
                {
                    MatrixA_DGV[i, j].Value = random.Next(-20, 30 + 1);
                }
            }
        }

        private void Modify_B_Click(object sender, EventArgs e)
        {
            ResultMatrix_DGV.ColumnCount = ResultMatrix_DGV.RowCount = _matrixSize;
            for (int i = 0; i < _matrixSize; i++)
            {
                for (int j = 0; j < _matrixSize; j++)
                {
                    ResultMatrix_DGV[i, j].Value = (int)MatrixA_DGV[i, j].Value;
                }
            }

            int x = 0;
            for (int i = 1; i < _matrixSize; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    x += (int)MatrixA_DGV[i, j].Value;
                }
            }

            for (int i = 1; i < _matrixSize; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    ResultMatrix_DGV[j, i].Value = (int)MatrixA_DGV[j, i].Value - x;
                }
            }
        }

    }

}

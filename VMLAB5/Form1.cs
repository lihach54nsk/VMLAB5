using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab2_VM;

namespace VMLAB5
{
    public partial class Form1 : Form
    {
        int N = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void NAddButton_Click(object sender, EventArgs e)
        {
            dataGridView1.RowCount = Convert.ToInt32(NTextBox.Text);
            dataGridView1.ColumnCount = Convert.ToInt32(NTextBox.Text) + 1;
            N = Convert.ToInt32(NTextBox.Text);
        }

        bool TriangleCheck(decimal[,] matrix)
        {
            var strCount = matrix.GetLength(0);
            var columnCount = matrix.GetLength(1);

            for (int i = 0; i < strCount; i++)
            {
                if (matrix[i, i] == 0)
                {
                    return false;
                }

                if ((i == 0) || (i == strCount - 1)) continue;
                else
                {
                    if ((matrix[i, i - 1] == 0) || (matrix[i - 1, i] == 0) || (matrix[i + 1, i] == 0) || (matrix[i, i + 1] == 0)) return false;
                    else continue;
                }
            }
            return true;
        }

        bool FaceCheckNull(decimal[,] matrix)
        {
            var strCount = matrix.GetLength(0);
            var columnCount = matrix.GetLength(1);

            if (strCount + 1 != columnCount) return false;

            for (int i = 0; i < strCount; i++)
            {
                if (matrix[i, i] != 0)
                {
                    return true;
                }
            }

            for (int j = 1; j < strCount; j++)
            {
                if (matrix[j, 0] != 0)
                {
                    MatrixMath.SwapString(matrix, 0, j);
                    return true;
                }
            }

            return false;
        }

        bool FaceCheckNullSweep(decimal[,] matrix)
        {
            var strCount = matrix.GetLength(0);
            var columnCount = matrix.GetLength(1);

            for (int i = 0; i < strCount; i++)
            {
                if (matrix[i, i] != 0)
                {
                    return true;
                }
            }

            for (int j = 1; j < strCount; j++)
            {
                if (matrix[j, 0] != 0)
                {
                    MatrixMath.SwapString(matrix, 0, j);
                    return true;
                }
            }

            return false;
        }

        private void GaussButton_Click(object sender, EventArgs e)
        {
            N = Convert.ToInt32(NTextBox.Text);

            decimal[,] matrixGZ = new decimal[N, N + 1];
            decimal[,] resMatrix;
            decimal[] result;

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j <= N; j++) matrixGZ[i, j] = Convert.ToDecimal(dataGridView1[j, i].Value);
            }

            result = MatrixMath.CalculateGauss(matrixGZ, out resMatrix);
            resultDataGridView.RowCount = 1;
            resultDataGridView.ColumnCount = result.Length;
            matrixDataGridView.RowCount = N;
            matrixDataGridView.ColumnCount = N;

            for (int i = 0; i < result.Length; i++) resultDataGridView[i, 0].Value = Convert.ToString(result[i]);

            for (int j = 0; j < N; j++)
            {
                for (int k = 0; k < N; k++) matrixDataGridView[j, k].Value = Convert.ToString(resMatrix[j, k]);
            }
        }

        private void ZeidelButton_Click(object sender, EventArgs e)
        {
            decimal accuracy = 0;

            if (Decimal.TryParse(accuracyTextBox.Text, out accuracy) == false) { accuracyTextBox.Text = "Укажите точность"; return; }

            N = Convert.ToInt32(NTextBox.Text);

            decimal[,] matrixGZ = new decimal[N, N + 1];
            decimal[] result = new decimal[N];

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j <= N; j++) matrixGZ[i, j] = Convert.ToDecimal(dataGridView1[j, i].Value);
            }

            if (FaceCheckNull(matrixGZ) == false) { MessageBox.Show("Поменяйте матрицу"); return; }

            result = MatrixMath.CalculateZeidel(matrixGZ, accuracy);
            resultDataGridView.RowCount = 1;
            resultDataGridView.ColumnCount = result.Length;

            for (int i = 0; i < result.Length; i++) resultDataGridView[i, 0].Value = Convert.ToString(result[i]);
        }

        private void SweepButton_Click(object sender, EventArgs e)
        {
            N = Convert.ToInt32(NTextBox.Text);

            decimal[,] matrix = new decimal[N, N];
            decimal[] right = new decimal[N];
            decimal[,] resMatrix = new decimal[N, N];
            decimal[] result = new decimal[N];

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++) { matrix[i, j] = Convert.ToDecimal(dataGridView1[j, i].Value); }
                right[i] = Convert.ToDecimal(dataGridView1[N, i].Value);
            }

            if (FaceCheckNullSweep(matrix) == false) { MessageBox.Show("Поменяйте матрицу"); return; }
            if (TriangleCheck(matrix) == false) { MessageBox.Show("Поменяйте матрицу"); return; }

            result = Sweep.SweepMatrix(N, matrix, right);

            resultDataGridView.RowCount = 1;
            resultDataGridView.ColumnCount = result.Length;

            for (int t = 0; t < N; t++) resultDataGridView[t, 0].Value = Convert.ToString(result[t]);
        }

        private void IsButton_Click(object sender, EventArgs e)
        {
            N = Convert.ToInt32(NTextBox.Text);
            bool convergence = true;

            decimal[,] matrixGZ = new decimal[N, N + 1];
            decimal[] result = new decimal[N];

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j <= N; j++) matrixGZ[i, j] = Convert.ToDecimal(dataGridView1[j, i].Value);
            }

            convergence = MatrixMath.CheckСonvergence(matrixGZ);

            if (convergence == true) IsTextBox.Text = "Сходится";
            else IsTextBox.Text = "Не сходится";
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VMLAB5;

namespace Lab2_VM
{
    public static class Sweep
    {
        public static decimal[] SweepMatrix(int N, decimal[,] matrixA, decimal[] matrixB)
        {
            int N1 = N - 1;

            //decimal[,] matrixA = new decimal[N, N];
            //decimal[] matrixB = new decimal[N];
            decimal y = 0;
            decimal[] A = new decimal[N];
            decimal[] B = new decimal[N];

            decimal[] matrixRes = new decimal[N];

            //matrixA = matrixa;
           // matrixB = matrixb;

            y = matrixA[0, 0];
            A[0] = -matrixA[0, 1] / y;
            B[0] = matrixB[0] / y;

            for (int i = 1; i < N1; i++) // прямой ход
            {
                y = matrixA[i, i] + matrixA[i, i - 1] * A[i - 1];
                A[i] = -matrixA[i, i - 1] / y;
                B[i] = (matrixB[i] - matrixA[i, i - 1] * B[i - 1]) / y;
            }

            matrixRes[N1] = (matrixB[N1] - matrixA[N1, N1 - 1] * B[N1 - 1]) / (matrixA[N1, N1] + matrixA[N1, N1 - 1] * A[N1 - 1]);

            for (int i = N1 - 1; i >= 0; i--) matrixRes[i] = A[i] * matrixRes[i + 1] + B[i]; // обратный ход

            return matrixRes;
        }
    }
}
using System;

namespace VagnerFisherAlgorithmlib
{
    public class LevinsteinVagner
    {
        static int Min(int a, int b) => a < b ? a : b;
        static int Min(int a, int b, int c) => (a = a < b ? a : b) < c ? a : c;
        public static int CalculateDistance(string strF, string strS)
        {
            int n = strF.Length + 1;
            int m = strS.Length + 1;
            int[,] arrayD = new int[n, m];
            for (int i = 0; i < n; i++)
                arrayD[i, 0] = i;
            for (int j = 0; j < m; j++)
                arrayD[0, j] = j;
            for (int i = 1; i < n; i++)
            {
                for (int j = 1; j < m; j++)
                {
                    int score = strF[i - 1] == strS[j - 1] ? 0 : 1;
                    arrayD[i, j] = Min(arrayD[i - 1, j] + 1,          // удаление
                                            arrayD[i, j - 1] + 1,         // вставка
                                            arrayD[i - 1, j - 1] + score); // замена
                    if (i > 1 && j > 1
                        && strF[i - 1] == strS[j - 2]
                        && strF[i - 2] == strS[j - 1])
                    {
                        arrayD[i, j] = Min(arrayD[i, j],
                                           arrayD[i - 2, j - 2] + score); // перестановка
                    }
                }
            }
            return arrayD[n - 1, m - 1];
        }
    }
}

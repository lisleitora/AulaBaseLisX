using System;
using static Helpers;

class Aula9lis
{
    public Aula9lis()
    {
        int[] search = { 7, 18, 50, 3, 80, 10, 70 };//nova linha
        int[] raNums = { 82, 39, 7, 3, 83, 20, 33, 7, 78, 99, 32, 88, 7, 62, 35, 44, 0, 23, 89, 91, 2, 3, 5, 3, 7, 4, 8, 3, 6, 38, 12, 15, 17, 18, 13, 7, 24, 7, 88, 14, 67, 90, 80, 50, 7, 9, 7, 18, 70 };
        int repNum = 0;

        foreach (int s in search)
        {  // 50 grande
            foreach (int num in raNums)
            {  // 5 pequeno
                if (num == s)
                {
                    repNum = repNum + 1;
                }
            }
            Write("O número " + s + " se repete " + repNum + " vezes");
            repNum = 0;
        }


    }
}
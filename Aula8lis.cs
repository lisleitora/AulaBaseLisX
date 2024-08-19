using System;
using static Helpers;

class Aula8lis
{
    public Aula8lis()
    {

        int[] raNums = { 93, 739, 80, 82, 32, 12, 83, 57, 76, 65 };
        int lastNum = raNums[0];
        foreach (int num in raNums)
        {
            if (num <= lastNum)
            {
                lastNum = num;
            }
        }
        Head();
        Write("Menor número");
        Line();
        Write("O número " + lastNum + " é o menor número");
    }
}
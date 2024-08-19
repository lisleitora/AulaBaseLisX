using System;
using static Helpers;

class Aula11lis
{
    public Aula11lis()
    {

        int[] Ages = { 9, 3, 5, 7, 49, 2, 46, 12, 14, 18, 50, 16, 38, 16, 15, 83, 17, 10, 34, 19 };
        int Teens = 0;

        foreach (int age in Ages)
        {

            if (age >= 12 && age <= 18)
            {
                Teens = Teens + 1;
                Write(">" + age);
            }
        }
        Write("Há " + Teens + " adolescentes ao todo!!");

    }
}
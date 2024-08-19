using System;
using static Helpers;

class Aula10lis
{
    public Aula10lis()
    {

        int[] Numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 3, 2, 243, 234, 4, 6, 7, 57, 2, 2 };
        int[] NumerosInvertidos = new int[Numeros.Length];

        int i = Numeros.Length - 1;
        foreach (int numero in Numeros)
        {
            Write(">  " + i + " > " + numero);
            NumerosInvertidos[i] = numero;
            i = i - 1;
        }
        foreach (int num in NumerosInvertidos)
        {
            Write(">" + num + "<");
        }
    }
}
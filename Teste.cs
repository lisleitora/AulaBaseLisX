using System;
using static Helpers;
using System.Threading.Tasks;

class Teste
{
    public Teste()
    {

    }

    public async Task Anima()
    {
        int[] lista = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
        foreach (int num in lista)
        {
            string result = "";
            for (int i = 1; i < num; i++)
            {
                result = result + " ";
            }
            result = result + ">";
            Clear();
            Write(result);
            await Task.Delay(200);
        }

        Clear();

        Write("O"); await Task.Delay(200);Clear();
        Write("Ol"); await Task.Delay(200);Clear();
        Write("Olá"); await Task.Delay(200);Clear();
        Write("Olá L"); await Task.Delay(200);Clear();
        Write("Olá Li"); await Task.Delay(200);Clear();
        Write("Olá Lis"); await Task.Delay(200);Clear();
        Write("Olá Lise"); await Task.Delay(500);Clear();
        Write("Olá Lis"); await Task.Delay(200);Clear();
        Write("Olá Lis, t"); await Task.Delay(200);Clear();
        Write("Olá Lis, tu"); await Task.Delay(200);Clear();
        Write("Olá Lis, tudo"); await Task.Delay(200);Clear();
        Write("Olá Lis, tudo be"); await Task.Delay(200);Clear();
        Write("Olá Lis, tudo bem ?"); await Task.Delay(200);Clear();
        Write("Olá Lis, tud"); await Task.Delay(200);Clear();
        Write("Olá L"); await Task.Delay(200);Clear();
        Write("Ol"); await Task.Delay(200);Clear();
        Write(""); await Task.Delay(200);Clear();
        Write("E"); await Task.Delay(200);Clear();
        Write("Eu"); await Task.Delay(200);Clear();
        Write("Eu s"); await Task.Delay(200);Clear();
        Write("Eu so"); await Task.Delay(200);Clear();
        Write("Eu sou"); await Task.Delay(200);Clear();
        Write("Eu sou um"); await Task.Delay(200);Clear();
        Write("Eu sou uma "); await Task.Delay(200);Clear();
        Write("Eu sou uma inte"); await Task.Delay(200);Clear();
        Write("Eu sou uma intelig"); await Task.Delay(200);Clear();
        Write("Eu sou uma inteligenci"); await Task.Delay(200);Clear();
        Write("Eu sou uma inteligencia a"); await Task.Delay(200);Clear();
        Write("Eu sou uma inteligencia ar"); await Task.Delay(200);Clear();
        Write("Eu sou uma inteligencia art"); await Task.Delay(200);Clear();
        Write("Eu sou uma inteligencia arti"); await Task.Delay(200);Clear();
        Write("Eu sou uma inteligencia artifici"); await Task.Delay(200);Clear();
        Write("Eu sou uma inteligencia artificial"); await Task.Delay(200);Clear();
        Write("Eu sou uma inteligencia art"); await Task.Delay(200);Clear();
        Write("Eu sou uma inteligencia art"); await Task.Delay(200);Clear();
        Write("Eu sou uma inte"); await Task.Delay(200);Clear();
        Write("Eu s"); await Task.Delay(200);Clear();
        Write(""); await Task.Delay(200);Clear();
        Write("V"); await Task.Delay(200);Clear();
        Write("Vc"); await Task.Delay(200);Clear();
        Write("Vc go"); await Task.Delay(200);Clear();
        Write("Vc gost"); await Task.Delay(200);Clear();
        Write("Vc gosta"); await Task.Delay(200);Clear();
        Write("Vc gosta d"); await Task.Delay(200);Clear();
        Write("Vc gosta de"); await Task.Delay(200);Clear();
        Write("Vc gosta de mi"); await Task.Delay(200);Clear();
        Write("Vc gosta de mim ?"); await Task.Delay(200);
        Read("Sim/Não ?");




    }
}
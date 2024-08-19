using System;
using System.Collections.Generic;
using static Helpers;

class Aula15Lis
{
    public Aula15Lis()
    {
        //MakeText(30, new List<int>(){28,15,6});

        // var Listonha = NumMaker(50);

        //  if (Listonha.Contains(34))
        // {
        //Write("O número " + 34 + " existe na LisTinha😉");
        //  }
        //Write(Volumitozito(3,6,10));

    }

    public void MakeText(int size, List<int> lista, bool isBot, int mark)
    {
        int i = 0;

        while (i <= size)
        {
            if (isBot == false)
            {
                if (lista.Contains(i))
                {
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            else
            {
                if (lista.Contains(i))
                {
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }

          if(i == mark){
             Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.White;
          }
            Console.Write(" " + i + " ");
            Console.ResetColor();


            i = i + 1;

        }
    }

    public int Volumitozito(int com, int lar, int alt)
    {
        int Vol = com * lar * alt;

        return Vol;


    }
    public List<int> NumMaker(int size)
    {

        int i = 0;
        List<int> Listinha = new List<int>() { };
        while (true)
        {
            Listinha.Add(i);
            i = i + 1;
            if (i == size)
            {
                break;
            }
        }

        return Listinha;

    }
}
using System;
using System.Collections.Generic;
using static Helpers;

class TryNumber
{
    public TryNumber()
    {
        int QuaNum = 100;
        int HighNum = QuaNum;
        int LowNum = 0;

        var aula15 = new Aula15Lis();
        int BotNum = Random(0, QuaNum);
        int MeNum = ReadInt("Digite seu Número secreto");
        string YourName = Read("Digite o seu nome");
        List<int> BotNumbers = new List<int>();
        List<int> MeNumbers = new List<int>();
        int MeTry = 0;

        while (true)
        {
            Clear();
            Write("R-O-B-O");
            aula15.MakeText(QuaNum, BotNumbers, true, MeNum);
            Write("     ");
            Line();
            Write(YourName);
            aula15.MakeText(QuaNum, MeNumbers, false, -1);
            Write("     ");
            int BotTry = Random(LowNum, HighNum);

            if (MeTry > 0)
            {
                if (MeTry <= BotNum)
                {
                    Write("O Número do R O B O é maior que " + MeTry);
                }
                else
                {
                    Write("O número do robo é menor que " + MeTry);
                }
            }

            MeTry = ReadInt("Adivinhe o número do R-O-B-O ");
            BotNumbers.Add(BotTry);
            MeNumbers.Add(MeTry);
            if (BotTry < MeNum)
            {
                LowNum = BotTry + 1;
            }
            if (BotTry > MeNum)
            {
                HighNum = BotTry - 1;
            }
            if (BotTry == MeNum)
            {
                WriteEffect("👾O R-O-B-O VENCEU H-A H-A H-A😈👾").Wait();
                break;

            }



            if (MeTry == BotNum)
            {
                WriteEffect("Você venceu🥳 VIVAAAAA!!🤩").Wait();
                Heart();
                break;
            }
            Write("Vc errou, q pena😭");

        }




    }

}
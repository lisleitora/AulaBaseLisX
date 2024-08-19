using System;
using static Helpers;

class Quiz
{
    public Quiz()
    {
        Dino();
        Write("Olá isto é um quiz");
        string q1 = Read("kirigami significa corte de papel?sim/não");
        int q2 = ReadInt("qual é o número de lados de um prisma hexagonal?");
        string q3 = Read("O que é o que é, tem 6 letras e 40 assentos");
        if (q1 == "Sim" && q2 == 8 && q3 == "Ônibus")
        {
            Write("UAU! você acertou TUDO, merece um prémio!!!");
            Dino();
            Heart();
            Smile();
        }
        else
        {
            Write("ohhh que pena, você errou...Mas pode tentar de novo!");
        }

    }
}
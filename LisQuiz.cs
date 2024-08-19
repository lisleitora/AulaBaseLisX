using System;
using static Helpers;

class LisQuiz
{
    public LisQuiz()
    {
        string[] LPerg = { "Quanto é 7 ao quadrado?", "'Mona Lisa foi pintada por Leonardo da Vinci' é uma frase passiva?", "há mais densidade populacional no interior de portugal?", "Qual é o nome do sistema que filtra o sangue e produz a urina?", "qual o sistema que tira as substâncias tóxicas do corpo?", "qual a cor contraria do amarelo?", "se a escala é de 1/5, quanto é 15 na realidade?", "qual a principal razão da emigração? (atenção, esta questão tem quatro palavras)", "a taxa de natalidade tem a ver com morte?", "há mais densidade populacional em que parte de Portugal?" };
        string[] LResp = { "49", "sim", "nao", "urinario", "excretor", "roxo", "75", "melhor condição de vida", "nao", "litoral" };
      bool[] VorF = {false, false, false, false, false, false, false, false, false, false};
        int index = 0;
        int Point = 0;

        foreach (string p in LPerg)
        {
            index = index + 1;
            Write("" + index);
            index = index - 1;
            string resp = Read(p);
            if (resp == LResp[index])
            {
                Point = Point + 1;
              VorF[index] = true;
            }
            index = index + 1;
        }
      index = 0;
        Write(" a sua pontuação é de " + Point + "/10");
      Write("RESPOSTAS");
      foreach(string perg in LPerg){
         Write(perg);
      
        if(VorF[index] == false){
          Write("você errou");
          Write("a resposta é " + LResp[index]);
        }else{
          Write(LResp[index]);
        }
        index = index + 1;
      }
    }
}
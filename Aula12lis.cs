using System;
using static Helpers;

class Aula12lis{
            public Aula12lis(){
              Write("vamos caucular o volume de um poligno");
            int Alt = ReadInt("insira a altura");
            int Lar = ReadInt("insira a largura");
             int Com = ReadInt("insira o comprimento");
                  
              Write("o volume é de " + Alt*Lar*Com + "³");
  }
}
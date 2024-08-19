using System;
using static Helpers;

class Aula13lis{
            public Aula13lis(){
              Write("vamos caucular usando a regra de 3 quartos");
            int To = ReadInt("insira o total");
            int Eq = ReadInt("insira o equivalente ao total");
             int Quan = ReadInt("insira a quantidade desejada");
                  
              Write("o resultado é " + To*Quan/Eq);
  }
}
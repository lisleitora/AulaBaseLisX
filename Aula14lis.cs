using System;
using static Helpers;

class Aula14lis{
            public Aula14lis(){
              int[] TNums = {1,2,3,4,5,6,7,8,9,10};
              Write("vamos caucular a tabuada");
           foreach(int T in TNums){
             foreach(int Num in TNums){
    Write(T + "x" + Num + "=" + T*Num); 
             }
             Write("   ");
           }
              
  }
}
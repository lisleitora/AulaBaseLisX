using System;
using static Helpers;
using System.Collections.Generic;

class Aula16Lis
{
    class Amigas
    {
        public string Nome;
        public string Idade;
        public string Lvl;
    }
    //____________________________
    class SerVivo
    {
        public string Nome;
        public int Idade;
        public string Tipo;
        public string Cor;
        public int Tamanho;

    }
    class Animal : SerVivo
    {
        public string TipoPe;
    }
    class Planta : SerVivo
    {
        public bool IsVerde;
    }
    class Mamifero : Animal
    {
        public bool TemPelo;
    }
    class Ave : Animal
    {
        public bool Voa;
    }
    class Peixe : Animal
    {

        public bool TemBarbatana;
    }

    public Aula16Lis()
    {
        List<Amigas> amigas = new List<Amigas>();

        string pack = Read("Digite os nomes, idades e  levels separados por virgula, e as amigas separadas por pontos.");

        List<string> SepAmigas = new List<string>(pack.Split("."));

        foreach (string i in SepAmigas)
        {
            
            List<string> SepAtrbts = new List<string>(i.Split(","));

            amigas.Add(new Amigas
            {
                Nome = SepAtrbts[0],
              Idade = SepAtrbts[1],
              Lvl = SepAtrbts[2]
            });
          

            Line();
        }
      foreach(Amigas l in amigas){
        Write("Nome: "+ l.Nome);
        Write("Idade: "+ l.Idade);
        Write("Lvl: "+ l.Lvl);
        
      }
    }
}



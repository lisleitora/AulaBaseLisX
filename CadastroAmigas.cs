using System;
using System.Collections.Generic;
using static Helpers;
using System.Linq;
class CadastroAmigas
{
    class Amiga
    {
        public string Nome;
        public int Idade;

    }

    public CadastroAmigas()
    {

        List<Amiga> Amigas = new List<Amiga>();

        string perg = "s";
        while (perg == "s")
        {
            string nome = Read("Nome");
            int idade = ReadInt("Idade");
            Amigas.Add(new Amiga { Nome = nome, Idade = idade });
            perg = Read("continuar? s/n");


        }

        foreach (Amiga amiga in Amigas)
        {
            Write("Nome: " + amiga.Nome);
            Write("Idade: " + amiga.Idade);
        }
        int quantAmigas = Amigas.Count();
        int somaIdades = Amigas.Sum(x => x.Idade);


        Write("A idade media é " + somaIdades / quantAmigas);

    }
}



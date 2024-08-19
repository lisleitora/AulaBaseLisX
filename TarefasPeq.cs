using System;
using System.Collections.Generic;
using static Helpers;
class TarefasPeq
{

    class Frutinha
    {
        public string Nome;
        public string Vitamina;
    }
    public void ListaFrutas()
    {

        string Fruta = "abacate, abacaxi, acerola, amora, banana, caju, carambola, cereja, coco, cupuaçu, framboesa, goiaba, graviola, jabuticaba, kiwi, laranja, limão, maçã, mamão, manga, maracujá, melancia, melão, morango, nect arina, pêra, pêssego, pitanga, romã, uva";
        List<string> Frutas = new List<string>(Fruta.Split(", "));

        string Vit = "vitamina K, vitamina C, vitamina C, vitamina C, vitamina B6, vitamina C, vitamina C, vitamina C, vitamina C, vitamina C, vitamina C, vitamina C, vitamina B1, vitamina C, vitamina C, vitamina C, vitamina C, vitamina C, vitamina A, vitamina C, vitamina A, vitamina C, vitamina A, vitamina A, vitamina C, vitamina A, vitamina C, vitamina C, vitamina C, vitamina C";
        List<string> Vits = new List<string>(Vit.Split(", "));
        Dictionary<string, string> VitDo = new Dictionary<string, string>();
        VitDo.Add("vitamina A", "Importante para a saúde dos olhos e da pele, ajuda no crescimento e desenvolvimento adequados, e desempenha um papel na manutenção do sistema imunológico.");
        VitDo.Add("vitamina B1", "Ajuda na conversão de alimentos em energia, e é importante para a saúde do coração, do sistema nervoso e dos músculos.");
        VitDo.Add("vitamina C", "Ajuda na cicatrização de feridas, fortalece o sistema imunológico e protege contra danos celulares causados por radicais livres.");
        VitDo.Add("vitamina B6", "Ajuda na produção de neurotransmissores, na síntese de glóbulos vermelhos e no metabolismo de proteínas.");
        VitDo.Add("vitamina K", "Essencial para a coagulação sanguínea e para a saúde óssea.");
        //VitDo.Add("Ácido Láurico", "Auxilia na melhora do sistema imunológico, tem propriedades antibacterianas e antivirais.");

        int i = 0;
        List<Frutinha> frutinhas = new List<Frutinha>();


        foreach (string n in Frutas)
        {
            frutinhas.Add(new Frutinha { Nome = n, Vitamina = Vits[i] });
            i = i + 1;
        }
        foreach (var item in frutinhas)
        {
            Write(item.Nome);
            Write(item.Vitamina);
            if (VitDo.ContainsKey(item.Vitamina))
            {

                Write(VitDo[item.Vitamina]);
            }
            Line();
        }

    }
    public void OrdenateNums()
    {
        List<int> DisOorNums = new List<int>() { 89, 23, 74, 19, 98, 7, 4, 10, 9, 2 };
        bool Trade = true;
        int QVez = 0;
        foreach (int x in DisOorNums)
        {

            Write("" + x);

        }
        // *bubble method*

        // while (Trade)
        // {
        //   Trade = false;
        // for (int i = 0; i < DisOorNums.Count - 1; i++)
        // {
        //   if (DisOorNums[i] > DisOorNums[i + 1])
        // {
        //   int TempNum = DisOorNums[i];
        // DisOorNums[i] = DisOorNums[i + 1];
        //  DisOorNums[i+1] = TempNum;
        //  Trade = true;
        // }
        //   }
        // QVez = QVez + 1;

        // }

        // *bubble method*

        // *quick method*
        for (int i = 0; i < DisOorNums.Count - 1; i++)
        {
            int Menour = i;
            for (int l = i + 1; l < DisOorNums.Count; l++)
            {

                if (DisOorNums[l] < DisOorNums[Menour])
                {
                    Menour = l;

                }

                int TempNum = DisOorNums[i];
                DisOorNums[i] = DisOorNums[Menour];
                DisOorNums[Menour] = TempNum;
            }

        }
        Line();
        foreach (int x in DisOorNums)
        {

            Write("" + x);

        }
        Line();
        // Write(QVez);
    }
}
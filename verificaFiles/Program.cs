using System.Globalization;

namespace verificaFiles
{
    internal class Program
    {
        static void EsercizioC(string file)
        {
            string[] parole = ["Vinci", "Offerta", "Compra"];
            List<string> lista = new List<string>();
            using(StreamReader sr = new StreamReader(file))
            {
                string riga = sr.ReadLine();
                riga = sr.ReadLine();
                while (riga != null)
                {
                    if (riga.Contains("Vinci")|| riga.Contains("Offerta") || riga.Contains("Compra"))
                    {
                        lista.Add(riga);
                    }
                    
                    riga = sr.ReadLine();
                }
            }

            using(StreamWriter sw = new StreamWriter("messaggi_sospetti.csv"))
            {
                sw.WriteLine();
                for(int i = 0;  i < lista.Count; i++)
                {
                    sw.WriteLine(lista[i]);
                }

            }
        }
        static void esercizioA()
        {
            string[] ruote = ["Bari", "Cagliari", "Firenze", "Genova", "Milano", "Napoli", "Palermo", "Roma", "Torino", "Venezia", "Nazionale"];
            int[] num = new int[5];
            Random rand = new Random();
            using (StreamWriter sw = new StreamWriter("estrazioni.csv"))
            {

                sw.WriteLine("ruota,n1,n2,n3,n4,n5");
                for(int i = 1;  i < ruote.Length; i++)
                {
                    sw.Write(ruote[i] + ",");
                    for (int z = 0; z < 5; z++)
                    {
                        int random = rand.Next(1, 90);
                        num[z] = random;
                        sw.Write(  num[z] + "," );
                    }
                    sw.WriteLine();
                  
                }
            }
        }
        static void esercizioB(string file1, string file2)
        {
            using (StreamReader sr =  new StreamReader(file2))
            {
                string riga = sr.ReadLine();
                riga = sr.ReadLine();
                List<string> giocatore = new List<string>();
                List<string> ruote = new List<string>();
                List<string> numero = new List<string>();
                while(riga != null )
                {
                    string[] split = riga.Split(',');
                    giocatore.Add(split[0]);
                    ruote.Add(split[1]);
                    numero.Add(split[2]);

                }
            }
        }
        static void Main(string[] args)
        {
            string fileC = "messaggi.csv";
            string fileB = "giocate_lotto_50.csv";
            string fileA = "estrazioni.csv";
            EsercizioC(fileC);
            esercizioA();
            esercizioB(fileB, fileA);

        }
    }
}

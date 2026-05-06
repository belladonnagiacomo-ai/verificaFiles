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
                    if (riga.Contains("Vinci") == true || riga.Contains("Offerta") == true || riga.Contains("Compra") == true)
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
        static void Main(string[] args)
        {
            string fileC = "messaggi.csv";
            EsercizioC(fileC);

        }
    }
}

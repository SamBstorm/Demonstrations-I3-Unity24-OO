using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo09_IDisposable
{
    public class Communication : IDisposable
    {
        public string Expediteur { get; private set; }
        public DateTime StartDate { get; private set; }
        public string Message { get; private set; }
        public Communication(string expediteur)
        {
            Console.WriteLine("Début de la communication :");
            Expediteur = expediteur;
            StartDate = DateTime.Now;
            Message = "";
        }

        public void AjoutTexte(string texte)
        {
            Message += $"{((Message.Length == 0)?"":"\n")}{texte}";
        }

        public void Dispose()
        {
            Console.WriteLine(Message);
            Console.WriteLine("Fin de la communication...");
        }

    }
}

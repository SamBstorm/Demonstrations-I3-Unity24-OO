using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Demo05_Proprietes
{
    public class Login
    {
        #region champs
        private string _email;
        private string _password;

        private int _nbAttempt;
        #endregion
        #region propriétés
        public string Email
        {
            private get { return _email; }
            set
            {
                value = value.Trim().ToLower();
                if (value.Contains('@') && value.Length <= 320 && value.Length >= 3)
                {
                    _email = value;
                }
                //SI on entre PAS dans la condition précédente, il serait plus judicieux de "Lancer une Exception" (Gestion des erreurs C#)
            }
        }
        public string Password
        {
            private get { return _password; }
            set
            {
                if (value.Length < 8) return;
                if (value.Length > 32) return;
                if (!Regex.IsMatch(value, "[a-z]+")) return;  //Vérifie si il y a une minuscule 
                if (!Regex.IsMatch(value, "[A-Z]+")) return;  //Vérifie si il y a une majuscule 
                if (!Regex.IsMatch(value, "[0-9]+")) return;  //Vérifie si il y a un chiffre
                if (!Regex.IsMatch(value, @"[\-\.@#=+/\\]+")) return;  //Vérifie si il y a un symbole
                _password = value;
            }
        } 
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime BirthDate { get; set; }
        public int YearsOld {
            get
            {
                DateTime aujourdhui = DateTime.Today;
                int age = aujourdhui.Year - BirthDate.Year;
                if (BirthDate.Date > aujourdhui.AddYears(-age)) age--;
                return age;
            }
        }
        
        public int NbAttempt
        {
            get { return _nbAttempt; }
            set { _nbAttempt = value; }
        }
        #endregion
    }
}

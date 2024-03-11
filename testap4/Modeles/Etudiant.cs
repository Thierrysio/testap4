using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testap4.Modeles
{
    public class Etudiant
    {
        #region Attributs
        private string _nom;
        private string _prenom;

        #endregion

        #region Constructeurs

        public Etudiant(string nom, string prenom)
        {
            _nom = nom;
            _prenom = prenom;
        }



        #endregion

        #region Getters/Setters
        public string Nom { get => _nom; set => _nom = value; }
        public string Prenom { get => _prenom; set => _prenom = value; }
        #endregion

        #region Methodes

        #endregion
    }
}

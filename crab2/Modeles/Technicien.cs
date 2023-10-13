using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crab2.Modeles
{
    internal class Technicien
    {
        #region Attributs

        public static List<Technicien> CollClasse = new List<Technicien>();

        private int _matricule;
        private string _nom;
        private string _prenom;

        #endregion

        #region Constructeurs

        public Technicien(int matricule, string nom, string prenom)
        {
            _matricule = matricule;
            _nom = nom;
            _prenom = prenom;

            Technicien.CollClasse.Add(this);
        }

        #endregion

        #region Getters/Setters

        public int Matricule { get => _matricule; set => _matricule = value; }
        public string Nom { get => _nom; set => _nom = value; }
        public string Prenom { get => _prenom; set => _prenom = value; }

        #endregion

        #region Methodes

        // Vous pouvez ajouter des méthodes spécifiques à la classe ici.

        #endregion
    }
}

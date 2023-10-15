using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crab2.Modeles
{
    internal class Maintenance
    {
        #region Attributs

        public static List<Maintenance> CollClasse = new List<Maintenance>();
        private List<Station> _lesStations;
        private List<Visite> _lesVisites;
        private List<Technicien> _lesTechniciens;
        // Attributs de la classe Maintenance - À modifier selon vos besoins
        // Exemple d'attribut
        // Ajoutez d'autres attributs ici...

        #endregion

        #region Constructeurs

        public Maintenance()  // Exemple de constructeur
        {
           
            Maintenance.CollClasse.Add(this);
            _lesStations = new List<Station>();
            _lesVisites = new List<Visite>();
            _lesTechniciens = new List<Technicien>();
        }

        // Vous pouvez ajouter d'autres constructeurs si nécessaire...

        #endregion

        #region Getters/Setters

        // Ajoutez d'autres getters/setters ici...
        public List<Station> LesStations { get => _lesStations; }
        public List<Visite> LesVisites { get => _lesVisites; }
        public List<Technicien> LesTechniciens { get => _lesTechniciens; }


        #endregion

        #region Methodes

        // Vous pouvez ajouter des méthodes spécifiques à la classe ici.

        #endregion
    }
}

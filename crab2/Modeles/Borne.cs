using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crab2.Modeles
{
    internal class Borne
    {

        #region Attributs

        public static List<Borne> CollClasse = new List<Borne>();

        private int _idBorne;
        private DateTime _dateDerniereRevision;
        private int _indiceCompteurUnites;

        #endregion

        #region Constructeurs

        public Borne(int idBorne, DateTime dateDerniereRevision, int indiceCompteurUnites)
        {
            _idBorne = idBorne;
            _dateDerniereRevision = dateDerniereRevision;
            _indiceCompteurUnites = indiceCompteurUnites;

            Borne.CollClasse.Add(this);
        }

        #endregion

        #region Getters/Setters

        public int IdBorne { get => _idBorne; set => _idBorne = value; }
        public DateTime DateDerniereRevision { get => _dateDerniereRevision; set => _dateDerniereRevision = value; }
        public int IndiceCompteurUnites { get => _indiceCompteurUnites; set => _indiceCompteurUnites = value; }

        #endregion

        #region Methodes

        // Vous pouvez ajouter des méthodes spécifiques à la classe ici.

        #endregion
    }
}

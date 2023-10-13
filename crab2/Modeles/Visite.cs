using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crab2.Modeles
{
    internal class Visite
    {
        #region Attributs

        public static List<Visite> CollClasse = new List<Visite>();

        private string _etat;
        private int _dureeTotale;
        private List<Borne> _lesBornes;
        private Station _laStation;

        #endregion

        #region Constructeurs

        public Visite(string etat, int dureeTotale, Station laStation)
        {
            _etat = etat;
            _dureeTotale = dureeTotale;
            _lesBornes = new List<Borne>();
            _laStation = laStation;
            Visite.CollClasse.Add(this);
            
        }

        #endregion

        #region Getters/Setters

        public string Etat { get => _etat; set => _etat = value; }
        public int DureeTotale { get => _dureeTotale; set => _dureeTotale = value; }
        public Station LaStation { get => _laStation; set => _laStation = value; }
        public List<Borne> LesBornes { get => _lesBornes; }


        #endregion

        #region Methodes

        // Je veux savoir si la borne 12 fait partie de la visite
        public bool GetBornePrecise(int param)
        {
            bool resultat = false;
            foreach(Borne uneBorne in this.LesBornes)
            {
                if(uneBorne.IdBorne == param)
                { 
                    resultat = true; 
                    return resultat; 
                }
            }

            return resultat;

        }

        #endregion
    }
}

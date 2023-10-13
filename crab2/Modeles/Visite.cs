﻿using System;
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

        #endregion

        #region Constructeurs

        public Visite(string etat, int dureeTotale)
        {
            _etat = etat;
            _dureeTotale = dureeTotale;
            _lesBornes = new List<Borne>();

            Visite.CollClasse.Add(this);
        }

        #endregion

        #region Getters/Setters

        public string Etat { get => _etat; set => _etat = value; }
        public int DureeTotale { get => _dureeTotale; set => _dureeTotale = value; }

        public List<Borne> LesBornes { get => _lesBornes; }


        #endregion

        #region Methodes

        // Vous pouvez ajouter des méthodes spécifiques à la classe ici.

        #endregion
    }
}

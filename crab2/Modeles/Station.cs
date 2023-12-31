﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crab2.Modeles
{
    internal class Station
    {
        #region Attributs

        public static List<Station> CollClasse = new List<Station>();

        private int _idStation;
        private string _libelleEmplacement;
        private List<Borne> _lesBornes;

        #endregion

        #region Constructeurs

        public Station(int idStation, string libelleEmplacement)
        {
            _idStation = idStation;
            _libelleEmplacement = libelleEmplacement;
            _lesBornes = new List<Borne>();

            Station.CollClasse.Add(this);
        }

        #endregion

        #region Getters/Setters

        public int IdStation { get => _idStation; set => _idStation = value; }
        public string LibelleEmplacement { get => _libelleEmplacement; set => _libelleEmplacement = value; }
        public List<Borne> LesBornes { get => _lesBornes;}
        #endregion

        #region Methodes

        // Vous pouvez ajouter des méthodes spécifiques à la classe ici.

        #endregion
    }
}

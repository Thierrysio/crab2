﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crab2.Modeles
{
    public class Borne
    {

        #region Attributs

        public static List<Borne> CollClasse = new List<Borne>();

        private int _idBorne;
        private DateTime _dateDerniereRevision;
        private int _indiceCompteurUnites;
        private TypeBorne _leType;

        #endregion

        #region Constructeurs

        public Borne(int idBorne, DateTime dateDerniereRevision, int indiceCompteurUnites, TypeBorne leType)
        {
            _idBorne = idBorne;
            _dateDerniereRevision = dateDerniereRevision;
            _indiceCompteurUnites = indiceCompteurUnites;
            _leType = leType;
            Borne.CollClasse.Add(this);

        }

        #endregion

        #region Getters/Setters

        public int IdBorne { get => _idBorne; set => _idBorne = value; }
        public DateTime DateDerniereRevision { get => _dateDerniereRevision; set => _dateDerniereRevision = value; }
        public int IndiceCompteurUnites { get => _indiceCompteurUnites; set => _indiceCompteurUnites = value; }
        public TypeBorne LeType { get => _leType; set => _leType = value; }


        #endregion

        #region Methodes

        public TypeBorne GetMonTypeBorne()
        {
            TypeBorne resultat = null;

            resultat = this.LeType;

            return resultat;
        }

        public int GetCodeTypeBorne()
        {
            int resultat = 0;
            resultat = this.LeType.CodeTypeBorne;
            return resultat;

        }

        public bool EstAReviser()
        {
            bool resultat = false;

            // premier cas les jours

            // calcul de la difference de temps entre aujourd'hui et la ldate de la derniere revision
            TimeSpan dureeDepuisDerniereRevision = DateTime.Now - this.DateDerniereRevision;

            if (dureeDepuisDerniereRevision.Days > this.LeType.NbJoursEntreRevisions)
            {
                resultat = true;
            }

            // deuxiemes cas

            // calcul par unites

            if (this.IndiceCompteurUnites > this.LeType.NbUnitesEntreRevisions)
            {
                resultat = true;
            }

            return resultat;
        }

        #endregion
    }
}

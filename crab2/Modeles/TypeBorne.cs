
using Microsoft.Maui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace crab2.Modeles
{
    internal class TypeBorne
    {
        #region Attributs

        public static List<TypeBorne> CollClasse = new List<TypeBorne>();

        private int _codeTypeBorne;
        private int _dureeRevision;  // Assuming it's a duration
        private int _nbJoursEntreRevisions;
        private int _nbUnitesEntreRevisions;

        #endregion

        #region Constructeurs

        public TypeBorne(int codeTypeBorne, int dureeRevision, int nbJoursEntreRevisions, int nbUnitesEntreRevisions)
        {
            _codeTypeBorne = codeTypeBorne;
            _dureeRevision = dureeRevision;
            _nbJoursEntreRevisions = nbJoursEntreRevisions;
            _nbUnitesEntreRevisions = nbUnitesEntreRevisions;

            TypeBorne.CollClasse.Add(this);
        }

        #endregion

        #region Getters/Setters

        public int CodeTypeBorne { get => _codeTypeBorne; set => _codeTypeBorne = value; }
        public int DureeRevision { get => _dureeRevision; set => _dureeRevision = value; }
        public int NbJoursEntreRevisions { get => _nbJoursEntreRevisions; set => _nbJoursEntreRevisions = value; }
        public int NbUnitesEntreRevisions { get => _nbUnitesEntreRevisions; set => _nbUnitesEntreRevisions = value; }

        #endregion

        #region Methodes

        // Vous pouvez ajouter des méthodes spécifiques à la classe ici.

        #endregion
    }
   
}

using crab2.Modeles;
using crab2.Sql;

namespace crab2
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnSearchButtonClicked(object sender, EventArgs e)
        {
            string nom = NomEntry.Text;
            Technicien technicien = SqlTechnicien.FindNom(nom);

            if (technicien != null)
            {
                MatriculeLabel.Text = "Matricule: " + technicien.Matricule;
                NomLabel.Text = "Nom: " + technicien.Nom;
                PrenomLabel.Text = "Prénom: " + technicien.Prenom;
            }
            else
            {
                MatriculeLabel.Text = "Matricule: ";
                NomLabel.Text = "Nom: ";
                PrenomLabel.Text = "Prénom: ";
                DisplayAlert("Erreur", "Technicien non trouvé!", "OK");
            }
        }
    }
}
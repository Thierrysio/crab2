using crab2.Sql;

namespace crab2.Vues;

public partial class TechniciensPage : ContentPage
{
    public TechniciensPage()
    {
        InitializeComponent();
        LoadTechniciens();
    }

    private void LoadTechniciens()
    {
        var techniciens = SqlTechnicien.FindAll();
        TechniciensListView.ItemsSource = techniciens;
    }
}
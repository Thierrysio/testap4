using testap4.Modeles;

namespace testap4.Vues;

public partial class moncheck : ContentPage
{
    public List<Produit> Produits { get; set; }

    public moncheck()
    {
        InitializeComponent();
    }

    void OnCheckBoxCheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        if (sender is CheckBox checkBox)
        {
            var produit = (Produit)checkBox.BindingContext;
            produit.IsSelected = checkBox.IsChecked;
        }
    }

    void OnValiderClicked(object sender, EventArgs e)
    {
        var produitsSelectionnes = Produits.Where(p => p.IsSelected).ToList();
        // Traitez les produits sélectionnés ici
    }
}
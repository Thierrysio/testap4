using System.Collections.ObjectModel;
using testap4.Api;
using testap4.Modeles;

namespace testap4.Vues;

public partial class PageSuivanteVue : ContentPage
{
    private readonly GestionApi _apiServices = new GestionApi();
    private ObservableCollection<Produit> result = new ObservableCollection<Produit>();
    public PageSuivanteVue()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
         result = await _apiServices.GetAllAsync<Produit>("api/mobile/GetAllProduits");
        MalisteProduit.ItemsSource = result;
    }
    private void OnNomProduitTapped(object sender, EventArgs e)
    {
        var label = sender as Label;
        if (label != null)
        {
            var produit = label.BindingContext as Produit;
            if (produit != null)
            {
                toto.Text = produit.PointsFidelite.ToString();
            }
        }
    }

    private async void Button_Clicked_1(object sender, EventArgs e)
    {
        string np = E1.Text;

        Produit res = await _apiServices.GetOneAsync<Produit>("api/mobile/GetOneProduit",new Produit(0,np,0,0));


    }
}
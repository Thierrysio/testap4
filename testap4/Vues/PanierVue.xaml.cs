using System.Collections.ObjectModel;
using testap4.Api;
using testap4.Modeles.Panier;

namespace testap4.Vues;

public partial class PanierVue : ContentPage
{
    private readonly GestionApi _apiServices = new GestionApi();

    public PanierVue()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
      var  result = await _apiServices.GetAllAsyncByID<Commander>("api/mobile/GetAllCommander","Id",3);
       ObservableCollection<Commander> MalisteProduit = result;
    }
}
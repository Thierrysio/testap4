using testap4.Api;
using testap4.Modeles;

namespace testap4.Vues;

public partial class InscriptionVue : ContentPage
{
    private readonly GestionApi _apiServices = new GestionApi();

    public InscriptionVue()
	{
		InitializeComponent();
	}

    private async void OnInscriptionClicked(object sender, EventArgs e)
    {
        var userData = new User
        {
            Email = emailEntry.Text,
            Nom = nomEntry.Text,
            Prenom = prenomEntry.Text,
            Password = passwordEntry.Text,
            Telephone = telephoneEntry.Text,
            DateNaissance = dateNaissancePicker.Date
        };

        // Utilisez votre classe GestionApi pour envoyer ces données à votre API
       
        var result = await _apiServices.GetOneAsync( "api/mobile/setInscription", userData);

        // Gérez le résultat ici (par exemple, afficher un message de succès ou d'erreur)
    }
}

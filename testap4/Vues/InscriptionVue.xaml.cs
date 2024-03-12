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

        // Utilisez votre classe GestionApi pour envoyer ces donn�es � votre API
       
        var result = await _apiServices.GetOneAsync( "api/mobile/setInscription", userData);

        // G�rez le r�sultat ici (par exemple, afficher un message de succ�s ou d'erreur)
    }
}

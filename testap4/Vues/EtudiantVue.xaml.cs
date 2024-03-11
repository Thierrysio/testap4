

using System.Collections.ObjectModel;
using testap4.Modeles;

namespace testap4.Vues;

public partial class EtudiantVue : ContentPage
{
	public EtudiantVue()
	{
		InitializeComponent();
        ObservableCollection<Etudiant> maListe = new ObservableCollection<Etudiant>();

		Etudiant E1 = new Etudiant("Disney", "riri");
        Etudiant E2 = new Etudiant("Disney", "riri");
        Etudiant E3 = new Etudiant("Disney", "riri");
		maListe.Add(E1);
		maListe.Add (E2);
		maListe.Add (E3);

        leNom.Text = E1.Nom;
		leNom.BackgroundColor = Colors.Red;
		lePrenom.Text = E1.Prenom;

        MalisteEtudiant.ItemsSource = maListe;



    }
}
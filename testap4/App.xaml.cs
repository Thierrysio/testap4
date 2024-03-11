using testap4.Vues;

namespace testap4
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new EtudiantVue();
        }
    }
}

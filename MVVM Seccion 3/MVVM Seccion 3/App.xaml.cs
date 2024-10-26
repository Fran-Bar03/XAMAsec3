using MVVM_Seccion_3.Vistas;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MVVM_Seccion_3
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Pagina1());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVM_Seccion_3.VistaModelo.MVpokemon;
using MVVM_Seccion_3.Vistas.Pokemon;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MVVM_Seccion_3.Vistas.Pokemon
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registrarpokemon : ContentPage
    {
        public Registrarpokemon()
        {
            InitializeComponent();
            BindingContext = new VMregistropokemon(Navigation);
        }
    }
}
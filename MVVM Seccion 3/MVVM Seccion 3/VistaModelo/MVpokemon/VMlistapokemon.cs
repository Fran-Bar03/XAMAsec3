using System;
using System.Collections.Generic;
using System.Data;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using MVVM_Seccion_3.Vistas.Pokemon;
using MVVM_Seccion_3.Datos;
using MVVM_Seccion_3.Modelo;
using System.Collections.ObjectModel;
using MVVM_Seccion_3.VistaModelo;

namespace MVVM_Seccion_3.VistaModelo.MVpokemon
{
    public class VMlistapokemon : BaseViewModel
    {
        #region VARIABLES  
        string _Texto;
        ObservableCollection<Mpokemon> _Listapokemon;
        #endregion

        #region CONSTRUCTOR

        public VMlistapokemon(INavigation navigation)
        {
            Navigation = navigation;
            Mostrarpokemon();
        }

        #endregion


        #region OBJETO

        public ObservableCollection<Mpokemon> Listapokemon
        {
            get { return _Listapokemon; }
            set {SetValue(ref _Listapokemon, value);
            }
        }
        #endregion

        public INavigation Navigation { get; }

        #region PROCESOS


        public async Task Mostrarpokemon()
        {
            var funcion = new Dpokemon();
            Listapokemon = await funcion.MostrarPokemones();
        }

        public async Task Iraregistro()
        {
            await Navigation.PushAsync(new Registrarpokemon());
        }

        public async Task Iradetalle(Mpokemon parametros)
        {
            if (parametros != null)
            {
                await Navigation.PushAsync(new Detallepokemon(parametros));
            }
        }

        #endregion

        #region COMANDOS
        public ICommand Iraregistrocommand => new Command(async () => await Iraregistro());

        public ICommand Iradetallecommand => new Command<Mpokemon> (async (pok) => await Iradetalle(pok));
        
        
        #endregion
    }
}

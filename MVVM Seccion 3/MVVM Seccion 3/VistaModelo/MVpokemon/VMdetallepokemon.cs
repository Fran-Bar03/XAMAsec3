using Firebase.Database.Offline;
using MVVM_Seccion_3.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MVVM_Seccion_3.VistaModelo.MVpokemon
{
    public class VMdetallepokemon : BaseViewModel
    {

        #region VARIABLES  
        string _Texto;
        public Mpokemon parametrosRecibe {  get; set; }
        #endregion

        #region CONSTRUCTOR

        public VMdetallepokemon(INavigation navigation, Mpokemon parametrosTrae)
        {
            Navigation = navigation;
            parametrosRecibe = parametrosTrae;
        }

        #endregion


        #region OBJETO

        public string Texto
        {
            get { return _Texto; }
            set { SetValue(ref _Texto, value); }
        }
        #endregion

        public INavigation Navigation { get; }

        #region PROCESOS
        

        public async Task Volver()
        {
            await Navigation.PopAsync();
        }


        public async Task ProcesoAsynccrono()
        {

        }
        
        public void ProcesoSimple()
        {

        }

        #endregion

        #region COMANDOS
        public ICommand Volvercommand => new Command(async () => await Volver());

        public ICommand ProcesoSimplecommand => new Command(ProcesoSimple);


        #endregion


    }
}

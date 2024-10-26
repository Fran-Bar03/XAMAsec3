using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MVVM_Seccion_3.VistaModelo
{
    public class VMPagina2 : BaseViewModel
    {
        #region VARIABLES  
        string _Texto;
        #endregion

        #region CONSTRUCTOR

        public VMPagina2(INavigation navigation)
        {
            Navigation = navigation;
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

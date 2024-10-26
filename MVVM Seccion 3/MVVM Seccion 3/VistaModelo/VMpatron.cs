using System;
using System.Collections.Generic;
using System.Data;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MVVM_Seccion_3.VistaModelo
{
    public class VMpatron:BaseViewModel
    {

        #region VARIABLES  
        string _Texto;
        #endregion

        #region CONSTRUCTOR

        public VMpatron(INavigation navigation)
        {
            Navigation = navigation;
        }

        #endregion


        #region OBJETO
   
        public string Texto 
        {
            get { return _Texto; }
            set { SetValue(ref _Texto, value);}
        }
        #endregion

        public INavigation Navigation { get; }

        #region PROCESOS

        public async Task ProcesoAsynccrono() 
        {

        }

        public void ProcesoSimple() 
        {

        }

        #endregion

        #region COMANDOS
        public ICommand ProcesoAsyncommand => new Command(async () => await ProcesoAsynccrono());

        public ICommand ProcesoSimplecommand => new Command(ProcesoSimple);

        
        #endregion
    }
}

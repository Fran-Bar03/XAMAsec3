using MVVM_Seccion_3.Vistas;
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
    public class VMPagina1:BaseViewModel
    {

        #region VARIABLES  
        string _N1;
        string _N2;
        string _R;
        #endregion

        #region CONSTRUCTOR

        public VMPagina1(INavigation navigation)
        {
            Navigation = navigation;
        }

        #endregion


        #region OBJETOS

        public string N1
        {
            get { return _N1; }
            set { SetValue(ref _N1, value); }
        }

        public string N2
        {
            get { return _N2; }
            set { SetValue(ref _N2, value); }
        }

        public string R
        {
            get { return _R; }
            set { SetValue(ref _R, value); }
        }
        #endregion

        public INavigation Navigation { get; }

        #region PROCESOS

        public async Task Navegarpagina2()
        {
            await Navigation.PushAsync(new Pagina2());
        }


        public void Sumar()
        {
            double n1 = 0;
            double n2 = 0;
            double respuesta = 0;

            n1 = Convert.ToDouble(N1);
            n2 = Convert.ToDouble(N2);

            respuesta = n1 + n2;

            R = respuesta.ToString();
        }

        #endregion

        #region COMANDOS
        public ICommand Navegarpagina2command => new Command(async () => await Navegarpagina2());

        public ICommand Sumarcommand => new Command(Sumar);

      
        #endregion
    }
}

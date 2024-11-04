using System;
using System.Collections.Generic;
using System.Data;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using MVVM_Seccion_3.Modelo;
using MVVM_Seccion_3.Datos;

namespace MVVM_Seccion_3.VistaModelo.MVpokemon
{
    internal class VMregistropokemon : BaseViewModel
    {

        #region VARIABLES  
        string _Txtcolorfondo;
        string _Txtcolorpoder;
        string _Txtnombre;
        string _Txtnro;
        string _Txtpoder;
        string _Txticono;
        #endregion

        #region CONSTRUCTOR

        public VMregistropokemon(INavigation navigation)
        {
            Navigation = navigation;
        }

        #endregion


        #region OBJETO

        public string Txtcolorfondo
        {
            get { return _Txtcolorfondo; }
            set { SetValue(ref _Txtcolorfondo, value); }
        }

        public string Txtcolorpoder
        {
            get { return _Txtcolorpoder; }
            set { SetValue(ref _Txtcolorpoder, value); }
        }

        public string Txtnombre
        {
            get { return _Txtnombre; }
            set { SetValue(ref _Txtnombre, value); }
        }


        public string Txtnro
        {
            get { return _Txtnro; }
            set { SetValue(ref _Txtnro, value); }
        }



        public string Txtpoder
        {
            get { return _Txtpoder; }
            set { SetValue(ref _Txtpoder, value); }
        }



        public string Txticono
        {
            get { return _Txticono; }
            set { SetValue(ref _Txticono, value); }
        }




        #endregion

        public INavigation Navigation { get; }

        #region PROCESOS

        public async Task Insertar()
        {
            var funcion = new Dpokemon();
            var parametros = new Mpokemon();
            parametros.Colorfondo = _Txtcolorfondo;
            parametros.Colorpoder = _Txtcolorpoder;
            parametros.Icono = _Txticono;
            parametros.Nombre = _Txtnombre;
            parametros.Nroorden = _Txtnro;
            parametros.Poder = _Txtpoder;

            await funcion.Insertarpokemon(parametros);

            await Volver();
        }


        public async Task Volver()
        {
            await Navigation.PopAsync();
        }

        public void ProcesoSimple()
        {

        }

        #endregion

        #region COMANDOS

        public ICommand Insertarcommand => new Command(async () => await Insertar());

        public ICommand Volvercommand => new Command(async () => await Volver());

        public ICommand ProcesoSimplecommand => new Command(ProcesoSimple);


        #endregion


    }
}

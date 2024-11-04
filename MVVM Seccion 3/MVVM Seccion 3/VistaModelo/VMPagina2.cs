using MVVM_Seccion_3.Modelo;
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
        public List<Musuarios> listausuarios {  get; set; }
        #endregion

        #region CONSTRUCTOR

        public VMPagina2(INavigation navigation)
        {
            Navigation = navigation;
            Mostrarusuarios();  
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

        public void Mostrarusuarios()
        {
            listausuarios = new List<Musuarios> 
            {
                new Musuarios
                {
                    Nombre = "Frank",
                    Imagen = "https://imgfz.com/i/aFxkPty.png"
                },               
                new Musuarios
                {
                    Nombre = "Juan",
                    Imagen = "https://imgfz.com/i/0pCzWln.png"
                },
                new Musuarios
                {
                    Nombre = "Carlos",
                    Imagen = "https://imgfz.com/i/hIP6qcE.png"
                }
            };


        }

        public async Task Alerta(Musuarios parametros)
        {
            await Application.Current.MainPage.DisplayAlert("Título", parametros.Nombre, "Ok");
        }

        #endregion

        #region COMANDOS
        public ICommand Volvercommand => new Command(async () => await Volver());

        // public ICommand ProcesoSimplecommand => new Command(ProcesoSimple);

        public ICommand Alertacommand => new Command<Musuarios>(async (u) => await Alerta(u));

        #endregion
    }
}

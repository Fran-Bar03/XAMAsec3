using MVVM_Seccion_3.Modelo;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;


using MVVM_Seccion_3.Vistas;

namespace MVVM_Seccion_3.VistaModelo
{
    public class VMMenuprincipal : BaseViewModel
    {
        #region VARIABLES  
        string _Texto;
        public List<Mmenuprincipal> listapaginas { get; set; }
        #endregion

        #region CONSTRUCTOR

        public VMMenuprincipal(INavigation navigation)
        {
            Navigation = navigation;
            Mostrarpaginas();
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

        public void Mostrarpaginas()
        {
            listapaginas = new List<Mmenuprincipal>
            {
                new Mmenuprincipal
                {
                    Pagina = "Entry, datepicker, picker, label, navegacion",
                    Icono = "https://imgfz.com/i/aFxkPty.png"
                },
                new Mmenuprincipal
                {
                    Pagina = "CollectionView sin enlace de base de datos",
                    Icono = "https://imgfz.com/i/0pCzWln.png"
                },
                new Mmenuprincipal
                {
                    Pagina = "Crud Pokemon",
                    Icono = "https://imgfz.com/i/WpcfL9K.png"
                }
            };


        }

        public async Task Navegar(Mmenuprincipal parametros)
        {
            string pagina;
            pagina = parametros.Pagina;
            if (pagina.Contains("Entry, datepicker"))
            {
                await Navigation.PushAsync(new Pagina1());
            }

            if (pagina.Contains("CollectionView sin enlace"))
            {
                await Navigation.PushAsync(new Pagina2());
            }

            if (pagina.Contains("Crud Pokemon"))
            {
                await Navigation.PushAsync(new Crudpokemon());
            }

        }

        #endregion

        #region COMANDOS
        //public ICommand Volvercommand => new Command(async () => await Volver());

        // public ICommand ProcesoSimplecommand => new Command(ProcesoSimple);

        public ICommand Navegarcommand => new Command<Mmenuprincipal>(async (u) => await Navegar(u));

        #endregion
    }
}

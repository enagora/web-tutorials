using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace CeldasPersonalizadasXAML
{
    public partial class HomePage : ContentPage
    {

        public static ObservableCollection<Juego> ListaJuegos { get; set; }

        public HomePage()
        {
            ListaJuegos = new ObservableCollection<Juego>(Juego.ObtenerListaJuegos());
            InitializeComponent();
            

        }
    }
}

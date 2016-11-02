using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace CeldasPersonalizadas
{
    public class HomePage : ContentPage
    {
        public HomePage()
        {
            Title = "Celdas personalizadas";

            List<Juego> listaJuegos = Juego.ObtenerListaJuegos();
            var listview = new ListView { RowHeight = 80 };
            listview.ItemsSource = listaJuegos;
            listview.ItemTemplate = new DataTemplate(typeof(JuegoCell));
            Content = new StackLayout
            {
                Children = {
                   listview
                }
            };
        }
        
    }

}

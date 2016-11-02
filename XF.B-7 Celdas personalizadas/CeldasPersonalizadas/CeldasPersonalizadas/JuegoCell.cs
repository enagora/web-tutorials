using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CeldasPersonalizadas
{
    class JuegoCell: ViewCell
    {
        public JuegoCell()
        {
            var imagen = new Image
            {
                HorizontalOptions = LayoutOptions.Start
            };
            imagen.SetBinding(Image.SourceProperty, new Binding("ImageUri"));
            imagen.WidthRequest = imagen.HeightRequest = 80;

            var capaNombre = CrearCapaNombre();
            var capaVista = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                Children = { imagen, capaNombre }
            };

            View = capaVista;
        }

        static StackLayout CrearCapaNombre()
        {
            var etiquetaNombre = new Label
            {
                HorizontalOptions = LayoutOptions.FillAndExpand
            };
            etiquetaNombre.SetBinding(Label.TextProperty, "Titulo");

            var etiquetaConsola = new Label
            {
                HorizontalOptions = LayoutOptions.FillAndExpand

            };
            etiquetaConsola.SetBinding(Label.TextProperty, "Plataforma");

            var capaNombre = new StackLayout
            {
                HorizontalOptions = LayoutOptions.StartAndExpand,
                Orientation = StackOrientation.Vertical,
                Children = { etiquetaNombre, etiquetaConsola }
            };
            return capaNombre;

        }
    }
}

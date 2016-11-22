using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XF.B_15_MasterDetailPage.Pages
{
    class MasterDetailPagePage : MasterDetailPage
    {
        public MasterDetailPagePage()
        {
            Label header = new Label
            {
                Text = "MasterDetailPage",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                HorizontalOptions = LayoutOptions.Center
            };

            // Introducimos un listado de colores
            NamedColor[] namedColors =
                {
                    new NamedColor("Aqua", Color.Aqua),
                    new NamedColor("Black", Color.Black),
                    new NamedColor("Blue", Color.Blue),
                    new NamedColor("Gray", Color.Gray),
                    new NamedColor("Green", Color.Green),
                    new NamedColor("Lime", Color.Lime),
                    new NamedColor("Maroon", Color.Maroon),
                    new NamedColor("Navy", Color.Navy),
                    new NamedColor("Olive", Color.Olive),
                    new NamedColor("Purple", Color.Purple),
                    new NamedColor("Red", Color.Red),
                    new NamedColor("Silver", Color.Silver),
                    new NamedColor("Teal", Color.Teal),
                    new NamedColor("White", Color.White),
                    new NamedColor("Yellow", Color.Yellow)
                };

            // Crear un ListView para la MasterPage
            ListView listView = new ListView
            {
                ItemsSource = namedColors
            };

            // Crear la masterOage con el ListView
            this.Master = new ContentPage
            {
                Title = header.Text,
                Content = new StackLayout
                {
                    Children =
                    {
                        header,
                        listView
                    }
                }
            };

            // Creamos la pagina detalle usando la pagina NamedColorPage
            // y almacenarlo en la pagina de navegacion y proporcionar
            // la barra de navegacion.
            this.Detail = new NavigationPage(new NamedColorPage(true));
                     

            // Nos suscribimos al ListView en el evento al seleccionar un item.
            listView.ItemSelected += (sender, args) =>
            {
                // Establecer el BindingContext de la pagina de detalle.
                this.Detail.BindingContext = args.SelectedItem;

                // Mostrar la pagina de detalle
                this.IsPresented = false;
            };

            // Initialize the ListView selection.
            listView.SelectedItem = namedColors[0];


        }
    }

}

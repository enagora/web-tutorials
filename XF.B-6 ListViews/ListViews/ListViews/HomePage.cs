using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace ListViews
{
    public class HomePage : ContentPage
    {
        public HomePage()
        {
            ListView listView = new ListView();

            // Introducimos unos valores para el ejemplo
            listView.ItemsSource = new TodoItem[]
            {
                new TodoItem {Name="comprar pan" },
                new TodoItem {Name="comprar manzanas" },
                new TodoItem {Name="comprar peras", Done=true },
                new TodoItem {Name="comprar azucar" , Done=true },
                new TodoItem {Name="completar tutorial" }
            };

            // asignamos el tipo de dato que vamos a relacionar con la plantilla
            listView.ItemTemplate = new DataTemplate(typeof(TextCell));
            listView.ItemTemplate.SetBinding(TextCell.TextProperty, "Name");


            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.CenterAndExpand,
                Children = {
                        listView
                    }

            };
            

            // Nos suscribimos al evento clic para poder actuar cuando se seleccione
            // un elemento de la lista
            listView.ItemSelected += async (sender, e) =>
            {
                await DisplayAlert("Has tocado!", e.SelectedItem + "seleccionado!", "OK");
            };
        }
    }
}

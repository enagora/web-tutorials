using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MiPrimerXAML
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();

            listView.ItemsSource = new TodoItem[]
           {
                new TodoItem {Name="comprar pan" },
                new TodoItem {Name="comprar manzanas" },
                new TodoItem {Name="comprar peras", Done=true },
                new TodoItem {Name="comprar azucar" , Done=true },
                new TodoItem {Name="completar tutorial" }
           };
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ListViews
{
    public class App : Application
    {
        public App()
        {
            // El objeto que va a tener nuestras tareas de TodoItem


            // Creamos la pagina principal
            MainPage = new ListViews.HomePage();
            
        }
        

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}

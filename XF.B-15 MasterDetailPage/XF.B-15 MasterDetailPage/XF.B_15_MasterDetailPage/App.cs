using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using XF.B_15_MasterDetailPage.Pages;

namespace XF.B_15_MasterDetailPage
{
    public class App : Application
    {
        public App()
        {
            // The root page of your application          

            MainPage = new MasterDetailPagePage();
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

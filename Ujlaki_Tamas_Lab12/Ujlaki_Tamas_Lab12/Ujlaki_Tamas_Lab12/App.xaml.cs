using System;
using Ujlaki_Tamas_Lab12.Services;
using Ujlaki_Tamas_Lab12.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Ujlaki_Tamas_Lab12.Droid.Data;
using Ujlaki_Tamas_Lab12.Models;

namespace Ujlaki_Tamas_Lab12
{
    public partial class App : Application
    {
        public static ShoppingListDatabase Database { get; private set; }
        public App()
        {
            Database = new ShoppingListDatabase(new RestService());
            MainPage = new NavigationPage(new ListEntryPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

using Digitalizacion5S.View;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Digitalizacion5S
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new LoginPage());

            Color color = Color.FromHex("#FFC803");

            if (Device.RuntimePlatform == Device.Android)
            {
                var navigationPage = (NavigationPage)MainPage;
                navigationPage.BarBackgroundColor = color; // Cambia el color a tu preferencia
                navigationPage.BarTextColor = Color.Black; // Cambia el color del texto de la barra de navegación
            }
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

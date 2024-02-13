using Digitalizacion5S.View;
using Digitalizacion5S.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Digitalizacion5S
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            nombreAuditor.Text = AppGlobals.nombreAudi;
        }

        private async void btn_5s_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AccesoAuditorias());
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            NavigationPage.SetHasBackButton(this, false);
        }



    }
}

using Digitalizacion5S.View;
using Digitalizacion5S.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Digitalizacion5S.Formatos
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PG01Operacion : ContentPage
    {
        double resulFin;
        public PG01Operacion()
        {
            InitializeComponent();
            BindingContext = new HallazgosViewModel();
        }

        private async void Mensaje_ADD(object sender, EventArgs e)
        {
            await DisplayAlert("Mensaje", "Datos Cargados", "Continuar");
        }

        private async void Result_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Mensaje", "Auditoria Enviada", "Continuar");
            await Navigation.PushAsync(new AccesoAuditorias());
        }

    }
}
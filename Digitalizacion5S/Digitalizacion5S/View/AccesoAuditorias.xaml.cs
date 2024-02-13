﻿using Digitalizacion5S.Model;
using Digitalizacion5S.Services;
using Digitalizacion5S.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Digitalizacion5S.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AccesoAuditorias : ContentPage
    {
        public AccesoAuditorias()
        {
            InitializeComponent();
            
            CrearBoton(AppGlobals.Audi1_Area, AppGlobals.Audi1_Nombre, AppGlobals.Audi1_Formato);
            CrearBoton(AppGlobals.Audi2_Area, AppGlobals.Audi2_Nombre, AppGlobals.Audi2_Formato);
            CrearBoton(AppGlobals.Audi3_Area, AppGlobals.Audi3_Nombre, AppGlobals.Audi3_Formato);
            CrearBoton(AppGlobals.Audi4_Area, AppGlobals.Audi4_Nombre, AppGlobals.Audi4_Formato);

        }

        private void CrearBoton(string area, string nombre, string formato)
        {
            if (!string.IsNullOrEmpty(area))
            {
                var nuevoBoton = new Button
                {
                    Text = nombre,
                    BackgroundColor = Color.FromHex("FFC803"),
                    TextColor = Color.Black,
                    FontAttributes = FontAttributes.Italic | FontAttributes.Italic,
                    FontSize = 25,
                    HeightRequest = 100,
                    WidthRequest = 350,
                    HorizontalOptions = LayoutOptions.CenterAndExpand,
                    Padding = new Thickness(15,20,15,20),
                    CornerRadius = 230
                };

                nuevoBoton.Clicked += async (s, e) =>
                {
                    AppGlobals.area = area;
                    await Navigation.PushAsync(new LectorQR(area, formato));
                };

                botones_din.Children.Add(nuevoBoton);
            }
            
        }
    }
}
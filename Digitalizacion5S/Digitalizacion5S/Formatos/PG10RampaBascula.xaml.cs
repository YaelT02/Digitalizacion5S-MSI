﻿using Digitalizacion5S.Services;
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
    public partial class PG10RampaBascula : ContentPage
    {
        double resultadosF10;
        public PG10RampaBascula()
        {
            InitializeComponent();
            BindingContext = new HallazgosViewModel();
        }

        private async void Result_Clicked(object sender, EventArgs e)
        {
            string hallaz1, hallaz2, hallaz3, hallaz4, hallaz5;
            int hallazCont = 0;
            double cp = 0;
            int c = 9;

            //Pregunta 1
            if (NA1F10.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C1F10.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC1F10.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 2
            if (NA2F10.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C2F10.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC2F10.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 3
            if (NA3F10.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C3F10.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC3F10.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 4
            if (NA4F10.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C4F10.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC4F10.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 5
            if (NA5F10.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C5F10.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC5F10.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 6
            if (NA6F10.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C6F10.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC6F10.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 7
            if (NA7F10.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C7F10.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC7F10.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 8
            if (NA8F10.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C8F10.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC8F10.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 9
            if (NA9F10.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C9F10.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC9F10.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Calificación
            if (c == 0)
            {
                resultadosF10 = 0;
            }
            else
            {
                resultadosF10 = (cp / c) / 2;

                AppGlobals.resulArea = resultadosF10.ToString();

            }

            hallaz1 = F10H1.Text;
            hallaz2 = F10H2.Text;
            hallaz3 = F10H3.Text;
            hallaz4 = F10H4.Text;
            hallaz5 = F10H5.Text;

            //Numero de hallazgos
            if (hallaz1 != null)
            {
                hallazCont += 1;
                //AppGlobals.hallazCont = hallazCont.ToString();

                if (hallaz2 != null)
                {
                    hallazCont += 1;
                    //AppGlobals.hallazCont = hallazCont.ToString();

                    if (hallaz3 != null)
                    {
                        hallazCont += 1;
                        //AppGlobals.hallazCont = hallazCont.ToString();

                        if (hallaz4 != null)
                        {
                            hallazCont += 1;
                            //AppGlobals.hallazCont = hallazCont.ToString();

                            if (hallaz5 != null)
                            {
                                hallazCont += 1;
                                //AppGlobals.hallazCont = hallazCont.ToString();
                            }
                        }
                    }
                }
                AppGlobals.hallazCont = hallazCont.ToString();

                FirebaseHelper fb = new FirebaseHelper();
            }

            await DisplayAlert("AUDITORIA", "Calificación cargada correctamente", "Ok");

        }
    }
}
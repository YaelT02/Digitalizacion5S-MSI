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
    public partial class PG11Osmosis : ContentPage
    {
        double resultadosF11;
        public PG11Osmosis()
        {
            InitializeComponent();
            BindingContext = new HallazgosViewModel();
        }

        private async void Result_Clicked(object sender, EventArgs e)
        {
            string hallaz1, hallaz2, hallaz3, hallaz4, hallaz5;
            int hallazCont = 0;
            double cp = 0;
            int c = 8;

            //Pregunta 1
            if (NA1F11.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C1F11.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC1F11.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 2
            if (NA2F11.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C2F11.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC2F11.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 3
            if (NA3F11.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C3F11.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC3F11.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 4
            if (NA4F11.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C4F11.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC4F11.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 5
            if (NA5F11.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C5F11.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC5F11.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 6
            if (NA6F11.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C6F11.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC6F11.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 7
            if (NA7F11.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C7F11.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC7F11.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 8
            if (NA8F11.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C8F11.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC8F11.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Calificación
            if (c == 0)
            {
                resultadosF11 = 0;
            }
            else
            {
                resultadosF11 = (cp / c) / 2;

                AppGlobals.resulArea = resultadosF11.ToString();

            }

            hallaz1 = F11H1.Text;
            hallaz2 = F11H2.Text;
            hallaz3 = F11H3.Text;
            hallaz4 = F11H4.Text;
            hallaz5 = F11H5.Text;

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
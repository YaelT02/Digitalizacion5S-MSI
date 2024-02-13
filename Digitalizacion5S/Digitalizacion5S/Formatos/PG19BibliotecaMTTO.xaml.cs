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
    public partial class PG19BibliotecaMTTO : ContentPage
    {
        double resultadosF19;
        public PG19BibliotecaMTTO()
        {
            InitializeComponent();
            BindingContext = new HallazgosViewModel();
        }

        private async void Result_Clicked(object sender, EventArgs e)
        {
            string hallaz1, hallaz2, hallaz3, hallaz4, hallaz5;
            int hallazCont = 0;
            double cp = 0;
            int c = 11;

            //Pregunta 1
            if (NA1F19.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C1F19.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC1F19.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 2
            if (NA2F19.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C2F19.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC2F19.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 3
            if (NA3F19.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C3F19.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC3F19.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 4
            if (NA4F19.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C4F19.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC4F19.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 5
            if (NA5F19.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C5F19.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC5F19.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 6
            if (NA6F19.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C6F19.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC6F19.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 7
            if (NA7F19.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C7F19.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC7F19.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 8
            if (NA8F19.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C8F19.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC8F19.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 9
            if (NA9F19.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C9F19.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC9F19.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 10
            if (NA10F19.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C10F19.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC10F19.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 11
            if (NA11F19.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C11F19.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC11F19.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Calificación
            if (c == 0)
            {
                resultadosF19 = 0;
            }
            else
            {
                resultadosF19 = (cp / c) / 2;
                AppGlobals.resulArea = resultadosF19.ToString();
            }

            hallaz1 = F19H1.Text;
            hallaz2 = F19H2.Text;
            hallaz3 = F19H3.Text;
            hallaz4 = F19H4.Text;
            hallaz5 = F19H5.Text;

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
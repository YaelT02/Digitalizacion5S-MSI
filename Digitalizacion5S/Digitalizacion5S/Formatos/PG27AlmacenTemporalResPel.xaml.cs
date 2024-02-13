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
	public partial class PG27AlmacenTemporalResPel : ContentPage
	{
        double resultadosF25;
        public PG27AlmacenTemporalResPel ()
		{
			InitializeComponent ();
            BindingContext = new HallazgosViewModel();
        }

        private async void Result_Clicked(Object sender, EventArgs e)
        {
            string hallaz1, hallaz2, hallaz3, hallaz4, hallaz5;
            int hallazCont = 0;
            double cp = 0;
            int c = 11;

            //Pregunta 1
            if (NA1F27.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C1F27.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC1F27.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 2
            if (NA2F27.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C2F27.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC2F27.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 3
            if (NA3F27.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C3F27.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC3F27.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 4
            if (NA4F27.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C4F27.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC4F27.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 5
            if (NA5F27.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C5F27.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC5F27.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 6
            if (NA6F27.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C6F27.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC6F27.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 7
            if (NA7F27.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C7F27.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC7F27.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 8
            if (NA8F27.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C8F27.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC8F27.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 9
            if (NA9F27.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C9F27.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC9F27.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 10
            if (NA10F27.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C10F27.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC10F27.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 11
            if (NA11F27.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C11F27.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC11F27.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            hallaz1 = F27H1.Text;
            hallaz2 = F27H2.Text;
            hallaz3 = F27H3.Text;
            hallaz4 = F27H4.Text;
            hallaz5 = F27H5.Text;

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
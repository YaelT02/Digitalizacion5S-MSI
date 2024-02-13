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
    public partial class PG02Oficinas : ContentPage
    {
        double resulFin;
        public PG02Oficinas()
        {
            InitializeComponent();
        }

        private void EnviarCuestionario(object sender, EventArgs e)
        {
            double calS1, calS2, calS3, calS4, calS5;
            int contS1 = 2, contS2 = 3, contS3 = 4, contS4 = 2, contS5 = 3;
            double contCalS1 = 0.0, contCalS2 = 0.0, contCalS3 = 0.0, contCalS4 = 0.0, contCalS5 = 0.0;

            //Primera "S"
            //Pregunta 1 - S1
            if (NA1F2S1.IsChecked)
            {
                contS1 = contS1 - 1;
            }
            else
            {
                if (C1F2S1.IsChecked)
                {
                    contCalS1 = contCalS1 + 10;
                }
                else if (NC1F2S1.IsChecked)
                {
                    contCalS1 = contCalS1 + 0;
                }
            }

            //Pregunta 2 - S1
            if (NA2F2S1.IsChecked)
            {
                //c = c - 1;
                contS1 -= 1;
            }
            else
            {
                if (C2F2S1.IsChecked)
                {
                    contCalS1 = contCalS1 + 10;
                }
                else if (NC2F2S2.IsChecked)
                {
                    contCalS1 = contCalS1 + 0;
                }
            }

            //Calificación - S1
            if (contS1 == 0)
            {
                calS1 = 0;
            }
            else
            {
                calS1 = (contCalS1 / contS1) / 10;
            }

            //Paso a segunda calificación
            if (calS1 >= 0.5)
            {
                //Segunda S
                //Pregunta 1 - S2
                if (NA1F2S2.IsChecked)
                {
                    contS2 = contS2 - 1;
                }
                else
                {
                    if (C1F2S2.IsChecked)
                    {
                        contCalS2 = contCalS2 + 10;
                    }
                    else if (NC1F2S2.IsChecked)
                    {
                        contCalS2 = contCalS2 + 0;
                    }
                }

                //Pregunta 2 - S2
                if (NA2F2S2.IsChecked)
                {
                    contS2 = contS2 - 1;
                }
                else
                {
                    if (C2F2S2.IsChecked)
                    {
                        contCalS2 = contCalS2 + 10;
                    }
                    else if (NC2F2S2.IsChecked)
                    {
                        contCalS2 = contCalS2 + 0;
                    }
                }

                //Pregunta 3 - S2
                if (NA3F2S2.IsChecked)
                {
                    contS2 = contS2 - 1;
                }
                else
                {
                    if (C3F2S2.IsChecked)
                    {
                        contCalS2 = contCalS2 + 10;
                    }
                    else if (NC3F2S2.IsChecked)
                    {
                        contCalS2 = contCalS2 + 0;
                    }
                }

                //Calificación - S2
                if (contS2 == 0)
                {
                    calS2 = 0;
                }
                else
                {
                    calS2 = (contCalS2 / contS2) / 10;
                }

                //Paso a tercera calificación
                if (calS2 >= 0.5)
                {
                    //Tercera S
                    //Pregunta 1 - S3
                    if (NA1F2S3.IsChecked)
                    {
                        contS3 = contS3 - 1;
                    }
                    else
                    {
                        if (C1F2S3.IsChecked)
                        {
                            contCalS3 = contCalS3 + 10;
                        }
                        else if (NC1F2S3.IsChecked)
                        {
                            contCalS2 = contCalS2 + 0;
                        }
                    }

                    //Pregunta 2 - S3
                    if (NA2F2S3.IsChecked)
                    {
                        contS3 = contS3 - 1;
                    }
                    else
                    {
                        if (C2F2S3.IsChecked)
                        {
                            contCalS3 = contCalS3 + 10;
                        }
                        else if (NC2F2S3.IsChecked)
                        {
                            contCalS3 = contCalS3 + 0;
                        }
                    }

                    //Pregunta 3 - S3
                    if (NA3F2S3.IsChecked)
                    {
                        contS3 = contS3 - 1;
                    }
                    else
                    {
                        if (C3F2S3.IsChecked)
                        {
                            contCalS3 = contCalS3 + 10;
                        }
                        else if (NC3F2S3.IsChecked)
                        {
                            contCalS3 = contCalS3 + 0;
                        }
                    }

                    //Pregunta 4 - S3
                    if (NA4F2S3.IsChecked)
                    {
                        contS3 = contS3 - 1;
                    }
                    else
                    {
                        if (C4F2S3.IsChecked)
                        {
                            contCalS3 = contCalS3 + 10;
                        }
                        else if (NC4F2S3.IsChecked)
                        {
                            contCalS3 = contCalS3 + 0;
                        }
                    }

                    //Calificación - S3
                    if (contS3 == 0)
                    {
                        calS3 = 0;
                    }
                    else
                    {
                        calS3 = (contCalS3 / contS3) / 10;
                    }

                    //Paso a cuarta calificación
                    if (calS3 >= 0.66)
                    {
                        //Cuarta S
                        //Pregunta 1 - S4
                        if (NA1F2S4.IsChecked)
                        {
                            contS4 = contS4 - 1;
                        }
                        else
                        {
                            if (C1F2S4.IsChecked)
                            {
                                contCalS4 = contCalS4 + 10;
                            }
                            else if (NC1F2S4.IsChecked)
                            {
                                contCalS4 = contCalS4 + 0;
                            }
                        }

                        //Pregunta 2 - S4
                        if (NA2F2S4.IsChecked)
                        {
                            contS4 = contS4 - 1;
                        }
                        else
                        {
                            if (C2F2S4.IsChecked)
                            {
                                contCalS4 = contCalS4 + 10;
                            }
                            else if (NC2F2S4.IsChecked)
                            {
                                contCalS4 = contCalS4 + 0;
                            }
                        }

                        //Calificación - S4
                        if (contS4 == 0)
                        {
                            calS4 = 0;
                        }
                        else
                        {
                            calS4 = (contCalS4 / contS4) / 10;
                        }

                        //Paso a quinta calificación
                        if (calS4 >= 0.5)
                        {
                            //Pregunta 1 - S5
                            if (NA1F2S5.IsChecked)
                            {
                                contS5 = contS5 - 1;
                            }
                            else
                            {
                                if (C1F2S5.IsChecked)
                                {
                                    contCalS5 = contCalS5 + 10;
                                }
                                else if (NC1F2S5.IsChecked)
                                {
                                    contCalS5 = contCalS5 + 0;
                                }
                            }

                            //Pregunta 2 - S5
                            if (NA2F2S5.IsChecked)
                            {
                                contS5 = contS5 - 1;
                            }
                            else
                            {
                                if (C2F2S5.IsChecked)
                                {
                                    contCalS5 = contCalS5 + 10;
                                }
                                else if (NC2F2S5.IsChecked)
                                {
                                    contCalS5 = contCalS5 + 0;
                                }
                            }

                            //Pregunta 3 - S5
                            if (NA3F2S5.IsChecked)
                            {
                                contS5 = contS5 - 1;
                            }
                            else
                            {
                                if (C3F2S5.IsChecked)
                                {
                                    contCalS5 = contCalS5 + 10;
                                }
                                else if (NC3F2S5.IsChecked)
                                {
                                    contCalS5 = contCalS5 + 0;
                                }
                            }

                            //Calificación - S5
                            if (contS5 == 0)
                            {
                                calS5 = 0;
                            }
                            else
                            {
                                calS5 = (contCalS5 / contS5) / 10;
                            }

                            resulFin = calS1 + calS2 + calS3 + calS4 + calS5;

                        }
                        else
                        {
                            resulFin = calS1 + calS2 + calS3 + calS4;
                        }

                    }
                    else
                    {
                        resulFin = calS1 + calS2 + calS3;
                    }

                }
                else
                {
                    resulFin = calS2 + calS1;
                }

            }
            else
            {
                resulFin = calS1;
            }

        }

    }
}
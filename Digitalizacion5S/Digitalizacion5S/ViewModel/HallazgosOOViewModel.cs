using CommunityToolkit.Mvvm.Input;
using Digitalizacion5S.Services;
using System;
using System.Collections.Generic;
using System.Text;


namespace Digitalizacion5S.ViewModel
{
    public class HallazgosOOViewModel : BaseViewModel
    {
        FirebaseHelper firebaseHelper = new FirebaseHelper();

        #region Attributes
        private string Id;
        //1eraS
        public string hallaz1S1;
        public string hallaz2S1;
        public string hallaz3S1;
        public string hallaz4S1;
        //2daS
        public string hallaz1S2;
        public string hallaz2S2;
        public string hallaz3S2;
        public string hallaz4S2;
        //3eraS
        public string hallaz1S3;
        public string hallaz2S3;
        public string hallaz3S3;
        public string hallaz4S3;
        //4taS
        public string hallaz1S4;
        public string hallaz2S4;
        public string hallaz3S4;
        public string hallaz4S4;
        //5taS
        public string hallaz1S5;
        public string hallaz2S5;
        public string hallaz3S5;
        public string hallaz4S5;

        //1eraS
        public string fecha1S1;
        public string fecha2S1;
        public string fecha3S1;
        public string fecha4S1;
        //2daS
        public string fecha1S2;
        public string fecha2S2;
        public string fecha3S2;
        public string fecha4S2;
        //3eraS
        public string fecha1S3;
        public string fecha2S3;
        public string fecha3S3;
        public string fecha4S3;
        //4taS
        public string fecha1S4;
        public string fecha2S4;
        public string fecha3S4;
        public string fecha4S4;
        //5taS
        public string fecha1S5;
        public string fecha2S5;
        public string fecha3S5;
        public string fecha4S5;

        //1eraS
        public string accion1S1;
        public string accion2S1;
        public string accion3S1;
        public string accion4S1;
        //2daS
        public string accion1S2;
        public string accion2S2;
        public string accion3S2;
        public string accion4S2;
        //3eraS
        public string accion1S3;
        public string accion2S3;
        public string accion3S3;
        public string accion4S3;
        //4taS
        public string accion1S4;
        public string accion2S4;
        public string accion3S4;
        public string accion4S4;
        //5taS
        public string accion1S5;
        public string accion2S5;
        public string accion3S5;
        public string accion4S5;

        public string numHallaz;
        public string cal;

        public bool isRefreshing = false;
        public object listViewSource;
        #endregion

        #region Proporties

        #endregion

        #region Commands

        #endregion

        #region Methods

        #endregion

        #region Constructors

        #endregion
    }
}

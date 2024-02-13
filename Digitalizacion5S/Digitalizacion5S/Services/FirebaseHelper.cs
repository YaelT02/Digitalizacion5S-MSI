using Digitalizacion5S.Model;
using Firebase.Database;
using Firebase.Database.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace Digitalizacion5S.Services
{
    public class FirebaseHelper
    {

        private FirebaseClient firebase;

        private string ClaveArea = AppGlobals.area;

        public FirebaseHelper(string databaseUrl)
        {
            firebase = new FirebaseClient(databaseUrl);
        }

        #region CONSULTA HALLAZ
        public async Task<List<HallazgosModel>> GetAllHallaz()
        {
            return (await firebase
                .Child("Hallazgo")
                .Child(ClaveArea)
                .OnceAsync<HallazgosModel>()).Select(item => new HallazgosModel
                {
                    Hallaz1 = item.Object.Hallaz1,
                    Hallaz2 = item.Object.Hallaz2,
                    Hallaz3 = item.Object.Hallaz3,
                    Hallaz4 = item.Object.Hallaz4,
                    Hallaz5 = item.Object.Hallaz5,
                    ID = item.Object.ID,
                    Fecha1 = item.Object.Fecha1,
                    Fecha2 = item.Object.Fecha2,
                    Fecha3 = item.Object.Fecha3,
                    Fecha4 = item.Object.Fecha4,
                    Fecha5 = item.Object.Fecha5,
                    Accion1 = item.Object.Accion1,
                    Accion2 = item.Object.Accion2,
                    Accion3 = item.Object.Accion3,
                    Accion4 = item.Object.Accion4,
                    Accion5 = item.Object.Accion5,
                }).ToList();
        }
        #endregion

        #region INSERT HALLAZGOS
        public async Task AddHallaz(string numHallaz, string Cal,HallazgosModel hallazgosModel)
        {

        await firebase
            .Child("Hallazgo")
            .Child(ClaveArea)
            .PostAsync(new HallazgosModel()
            {
                ID = ClaveArea,
                Hallaz1 = hallazgosModel.Hallaz1,
                Hallaz2 = hallazgosModel.Hallaz2,
                Hallaz3 = hallazgosModel.Hallaz3,
                Hallaz4 = hallazgosModel.Hallaz4,
                Hallaz5 = hallazgosModel.Hallaz5,
                Fecha1 = hallazgosModel.Fecha1,
                Fecha2 = hallazgosModel.Fecha2,
                Fecha3 = hallazgosModel.Fecha3,
                Fecha4 = hallazgosModel.Fecha4,
                Fecha5 = hallazgosModel.Fecha5,
                Accion1 = hallazgosModel.Accion1,
                Accion2 = hallazgosModel.Accion2,
                Accion3 = hallazgosModel.Accion3,
                Accion4 = hallazgosModel.Accion4,
                Accion5 = hallazgosModel.Accion5,
                Cal = Cal,
                NumHallaz = numHallaz
            });
        }
        #endregion

        #region Hallazgos
        public async Task UpdateHallaz(HallazgosModel hallazgosModel)
        {
            var toUpdatePerson = (await firebase
               .Child("Persons")
               //.Child(ClaveArea)
               .OnceAsync<HallazgosModel>()).Where(a => a.Object.ID == hallazgosModel.ID).FirstOrDefault();

            await firebase
                .Child("Hallazgo")
                .Child(toUpdatePerson.Key)
                .PutAsync(new HallazgosModel() 
                { 
                    ID = hallazgosModel.ID,
                    Hallaz1 = hallazgosModel.Hallaz1,
                    Hallaz2 = hallazgosModel.Hallaz2,
                    Hallaz3 = hallazgosModel.Hallaz3,
                    Hallaz4 = hallazgosModel.Hallaz4,
                    Hallaz5 = hallazgosModel.Hallaz5,
                    Fecha1 = hallazgosModel.Fecha1,
                    Fecha2 = hallazgosModel.Fecha2,
                    Fecha3 = hallazgosModel.Fecha3,
                    Fecha4 = hallazgosModel.Fecha4,
                    Fecha5 = hallazgosModel.Fecha5,
                    Accion1 = hallazgosModel.Accion1,
                    Accion2 = hallazgosModel.Accion2,
                    Accion3 = hallazgosModel.Accion3,
                    Accion4 = hallazgosModel.Accion4,
                    Accion5 = hallazgosModel.Accion5,
                });
        }
        #endregion

        public async Task<AuditoresModel> GetAuditorByUid(string uid)
        {
            var auditor = await firebase
                .Child("Auditor")
                .Child(uid)
                .OnceSingleAsync<AuditoresModel>();
            return auditor;
        }

        public async Task<bool> IsAuditorExists(string uid)
        {
            var auditor = await GetAuditorByUid(uid);
            return auditor != null;
        }

        public async Task<AreasModel> GetAreaById(string areaId)
        {
            var area = await firebase
                .Child("Areas")
                .Child(areaId)
                .OnceSingleAsync<AreasModel>();
            return area;
        }

        public FirebaseHelper()
        {
            firebase = new FirebaseClient("https://digitalizacion5s-default-rtdb.firebaseio.com/");
        }
    }
}

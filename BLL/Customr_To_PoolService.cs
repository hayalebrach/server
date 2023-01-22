using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Customr_To_PoolService
    {
       
        DAL.Model.Customr_To_PoolModel model = new DAL.Model.Customr_To_PoolModel();

        public List<DTO.Customr_To_PoolDTO> AllCustomersToPool()
        {
            return convert.Customr_To_PoolConvert.Convert(model.AllCustomersToPool());
        }

        public List<DTO.Customr_To_PoolDTO> CustomersToPool(int IdPool)
        {
            return convert.Customr_To_PoolConvert.Convert(model.CustomersToPool( IdPool));
        }

        public List<DTO.Customr_To_PoolDTO> GetCoursesToUserByIdPool(int IdPool)
        {
            return convert.Customr_To_PoolConvert.Convert(model.GetCoursesToUserByIdPool(IdPool));
        }
        //פונקציה שמיבאת לקוחות לבריכה מסוימת לפי id

        public List<DTO.Customr_To_PoolDTO> GetByIdPool(int IdPool)
        {
            return convert.Customr_To_PoolConvert.Convert(model.GetByIdPool(IdPool));
        }

        //פונקציה שמביאה היסטורית קניות של לקוח בבריכה מסוימת
        public List<DTO.Customr_To_PoolDTO> GetHistoryOfUser(int IdUser)
        {
            return convert.Customr_To_PoolConvert.Convert(model.GetHistoryOfUser(IdUser));
        }
        //פונקציה שמביאה היסטורית קניותשל משתמש למנהל בריכה מסוימת
        public List<DTO.Customr_To_PoolDTO> GetHistoryByIdPoolAndIdUser(int IdUser, int IdPool)
        {
            return convert.Customr_To_PoolConvert.Convert(model.GetHistoryByIdPoolAndIdUser(IdUser,IdPool));
        }
        //מביאה את כל המתמשים לבריכה
        public List<DTO.Customr_To_PoolDTO> Get()
        {
            return convert.Customr_To_PoolConvert.Convert(model.Get());
        }
        //רכישת כרטיסיה של לקוח
        public DTO.Customr_To_PoolDTO Purchasing(DTO.Customr_To_PoolDTO purchase)
        {
            return convert.Customr_To_PoolConvert.Convert(model.Purchasing(convert.Customr_To_PoolConvert.Convert(purchase)));
        }
        //פונקצית עדכון כשלקוח משתמש בכרטיסיה מסוימת
        public DTO.Customr_To_PoolDTO Put(int Id, int AmountGet)
        {
            return convert.Customr_To_PoolConvert.Convert(model.Put(Id,AmountGet));

        }
    }
}

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
       

        public List<DTO.Customr_To_PoolDTO> GetByIdPool(int IdPool)
        {
            return convert.Customr_To_PoolConvert.Convert(model.GetByIdPool(IdPool));
        }

        //פונקציה שמביאה היסטורית קניות של לקוח בבריכה מסוימת
        public List<DTO.Customr_To_PoolDTO> GetHistoryOfUser(int IdUser)
        {
            return convert.Customr_To_PoolConvert.Convert(model.GetHistoryOfUser(IdUser));
        }
        public List<DTO.Customr_To_PoolDTO> GetHistoryByIdPoolAndIdUser(int IdUser, int IdPool)
        {
            return convert.Customr_To_PoolConvert.Convert(model.GetHistoryByIdPoolAndIdUser(IdUser,IdPool));
        }

        public List<DTO.Customr_To_PoolDTO> Get()
        {
            return convert.Customr_To_PoolConvert.Convert(model.Get());
        }

        public DTO.Customr_To_PoolDTO Purchasing(DTO.Customr_To_PoolDTO purchase)
        {
            return convert.Customr_To_PoolConvert.Convert(model.Purchasing(convert.Customr_To_PoolConvert.Convert(purchase)));
        }

    }
}

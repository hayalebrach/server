using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PoolService
    {
        DAL.Model.PoolModel model = new DAL.Model.PoolModel();
        public List<DTO.PoolDTO> GetAllPools()
        {
            return convert.PoolConvert.Convert(model.GetAllPools());
        }

        public DTO.PoolDTO AddPool(DTO.PoolDTO Pool) //הוספת משתמש
        {
            return convert.PoolConvert.Convert(model.AddPool(convert.PoolConvert.Convert(Pool)));
        }

    }
}

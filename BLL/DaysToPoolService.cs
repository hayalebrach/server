using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public  class DaysToPoolService
    {
        DAL.Model.DaysToPoolModel model = new DAL.Model.DaysToPoolModel();
        public List<DTO.DaysToPoolDTO> Get()
        {
            return convert.DaysToPoolConvert.Convert(model.Get());
        }
        public DTO.DaysToPoolDTO AddDaysToPool(DTO.DaysToPoolDTO DaysToPool) //הוספת משתמש
        {
            return convert.DaysToPoolConvert.Convert(model.AddDaysToPool(convert.DaysToPoolConvert.Convert(DaysToPool)));
        }
    }
}

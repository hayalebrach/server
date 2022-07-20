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
        public List<DTO.PoolDTO> Get()
        {
            return convert.PoolConvert.Convert(model.Get());
        }
    }
}

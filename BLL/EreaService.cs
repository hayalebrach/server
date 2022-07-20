using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class EreaService
    {
        DAL.Model.EreaModel model = new DAL.Model.EreaModel();
        public List<DTO.EreaDTO> Get()
        {
            return convert.EreaConvert.Convert(model.Get());
        }
    }
}

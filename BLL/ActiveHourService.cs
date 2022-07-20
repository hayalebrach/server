using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ActiveHourService
    {
        DAL.Model.ActiveHourModel model = new DAL.Model.ActiveHourModel();
        public List<DTO.ActiveHourDTO> Get()
        {
            return convert.ActiveHourConvert.Convert(model.Get());
        }
    }
}

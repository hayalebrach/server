using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CoursService
    {
        DAL.Model.CoursModel model = new DAL.Model.CoursModel();
        public List<DTO.CoursDTO> Get()
        {
            return convert.CoursConvert.Convert(model.Get());
        }
    }
}

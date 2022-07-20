using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class EntCustomrService
    {
        DAL.Model.EntCustomrModel model = new DAL.Model.EntCustomrModel();
        public List<DTO.EntCustomrDTO> Get()
        {
            return convert.EntCustomrConvert.Convert(model.Get());
        }
    }
}

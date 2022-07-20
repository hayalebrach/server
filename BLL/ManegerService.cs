using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ManegerService
    {
        DAL.Model.ManegerModel model = new DAL.Model.ManegerModel();
        public List<DTO.ManegerDTO> Get()
        {
            return convert.ManegerConvert.Convert(model.Get());
        }
    }
}

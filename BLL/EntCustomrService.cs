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
        public List<DTO.EntCustomrDTO> GetAllNumPeople(int IdPool)
        {
            return convert.EntCustomrConvert.Convert(model.GetAllNumPeople(IdPool));
        }
        public DTO.EntCustomrDTO Post(DTO.EntCustomrDTO entCustomr)
        {
            return convert.EntCustomrConvert.Convert(model.Post(convert.EntCustomrConvert.Convert(entCustomr)));
        }
    }
}

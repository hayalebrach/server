using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PackegeService
    {
        DAL.Model.PackegeModel model = new DAL.Model.PackegeModel();
        public List<DTO.PackegeDTO> Get()
        {
            return convert.PackegeConvert.Convert(model.Get());
        }

        public DTO.PackegeDTO AddCard(DTO.PackegeDTO Card)
        {
            return convert.PackegeConvert.Convert(model.AddCard(convert.PackegeConvert.Convert(Card)));
        }
    }
}

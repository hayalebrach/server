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
        //מחזירה את כל האיזורים
        public List<DTO.EreaDTO> GetAllEreas()
        {
            return convert.EreaConvert.Convert(model.GetAllEreas());
        }
    }
}

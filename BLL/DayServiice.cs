using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DayServiice
    {
      
        DAL.Model.DaysModel model = new DAL.Model.DaysModel();
        //כל הימים
        public List<DTO.DaysDTO> Get()//כל המשתמשים
        {
            return convert.DaysConvert.Convert(model.Get());
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DayToCoursService
    {
        DAL.Model.DaysToCoursModel model = new DAL.Model.DaysToCoursModel();
        public List<DTO.DayToCoursDTO> GetTimeByIdPool(int IdPool)
        {
            return convert.DaysToCoursConvert.Convert(model.GetTimeByIdPool(IdPool));
        }
        //הוספת זמן
        public DTO.DayToCoursDTO AddDayToCours(DTO.DayToCoursDTO DayToCours)
        {
            return convert.DaysToCoursConvert.Convert(model.AddDaysToCours(convert.DaysToCoursConvert.Convert(DayToCours)));
        }
    }
}

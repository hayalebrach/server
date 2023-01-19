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
        //לוקחת מערכת שעות לבריכה
        public List<DTO.DayToCoursDTO> GetTimeByIdPool(int IdPool)
        {
            return convert.DaysToCoursConvert.Convert(model.GetTimeByIdPool(IdPool));
        }
        //מוסיפה שעה לבריכה
        public DTO.DayToCoursDTO AddDayToCours(DTO.DayToCoursDTO DayToCours)
        {
            return convert.DaysToCoursConvert.Convert(model.AddDaysToCours(convert.DaysToCoursConvert.Convert(DayToCours)));
        }
    }
}

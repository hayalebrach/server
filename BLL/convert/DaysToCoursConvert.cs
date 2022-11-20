using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.convert
{
    public class DaysToCourConvert
    {

        #region המרה משכבת דל לשכבת דיטיאו
        public static DTO.DayToCoursDTO Convert(DAL.DaysToCour obj)
        {
            if (obj == null)
                return null;
            return new DTO.DayToCoursDTO()
            {
               IdCours = obj.IdCours,
               EndHour=obj.EndHour,
               IdDays   =obj.IdDays,
               IdPool=obj.IdPool,
               StartHour=obj.StartHour,
               Type=obj.Type,
               Id=obj.Id,
            };
        }
        #endregion

        #region המרה משכבת דיטיאו לשכבת דל
        public static DAL.DaysToCour Convert(DTO.DayToCoursDTO obj)
        {
            if (obj == null)
                return null;
            return new DAL.DaysToCour()
            {
               EndHour=obj.EndHour,
               Type = obj.Type,
               IdCours = ((int)obj.IdCours),
               IdDays = ((int)obj.IdDays),
               IdPool = ((int)obj.IdPool),
               StartHour = obj.StartHour,
               Id=obj.Id  
            };
        }
        #endregion

        #region המרה של מערך מדיטיאו לדל
        public static List<DAL.DaysToCour> Convert(List<DTO.DayToCoursDTO> obj)
        {
            return obj.Select(x => Convert(x)).ToList();
        }
        #endregion

        #region המרה של מערך דלמ לדיטיאו
        public static List<DTO.DayToCoursDTO> Convert(List<DAL.DaysToCour> obj)
        {
            return obj.Select(x => Convert(x)).ToList();
        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.convert
{
    public class DaysConvert
    {
        #region המרה משכבת דיטיאו לשכבת דל
        public static DTO.DaysDTO Convert(DAL.Day obj)
        {

            if (obj == null)
                return null;
            return new DTO.DaysDTO()
            {
                Id = obj.Id,
                NameDay = obj.NameDay,
              
            };

        }
        #endregion

        #region המרה משכבת דל לשכבת דיטיאו
        public static DAL.Day Convert(DTO.DaysDTO obj)
        {
            if (obj == null)
                return null;
            return new DAL.Day()
            {
                Id = obj.Id,
                NameDay=obj.NameDay,    

            };
        }
        #endregion

        #region המרה של מערך מדיטיאו לדל
        public static List<DAL.Day> Convert(List<DTO.DaysDTO> obj)
        {
            return obj.Select(x => Convert(x)).ToList();
        }
        #endregion

        #region המרה של מערך דלמ לדיטיאו
        public static List<DTO.DaysDTO> Convert(List<DAL.Day> obj)
        {
            return obj.Select(x => Convert(x)).ToList();
        }
        #endregion

    }
}

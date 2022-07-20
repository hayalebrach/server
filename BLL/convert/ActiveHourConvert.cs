using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.convert
{
    public class ActiveHourConvert
    {
        
        #region המרה משכבת דיטיאו לשכבת דל
        public static DTO.ActiveHourDTO Convert(DAL.ActiveHour obj)
        {
            if (obj == null)
                return null;
            return new DTO.ActiveHourDTO()
            {
                Id = obj.Id,
                PoolId = obj.PoolId,
                Day = obj.Day,
                OpenHour = obj.OpenHour,
                CloseHour = obj.CloseHour,
                Type = obj.Type
            };
        }
        #endregion
   
        #region המרה משכבת דל לשכבת דיטיאו
        public static DAL.ActiveHour Convert(DTO.ActiveHourDTO obj)
        {
            if (obj == null)
                return null;
            return new DAL.ActiveHour()
            {
                Id = obj.Id,
                PoolId = obj.PoolId,
                Day = obj.Day,
                OpenHour = obj.OpenHour,
                CloseHour = obj.CloseHour,
                Type = obj.Type
            };
        }
        #endregion

        #region המרה של מערך מדיטיאו לדל
 public static List<DAL.ActiveHour>Convert(List<DTO.ActiveHourDTO> obj)
        {
            return obj.Select(x => Convert(x)).ToList();
        }
        #endregion

        #region המרה של מערך דלמ לדיטיאו
public static List<DTO.ActiveHourDTO> Convert(List<DAL.ActiveHour> obj)
        {
            return obj.Select(x => Convert(x)).ToList();
        }
        #endregion
        


    }
}

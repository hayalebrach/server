using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.convert
{
    public class CoursConvert
    {
        #region המרה משכבת דיטיאו לשכבת דל
        public static DTO.CoursDTO Convert(DAL.Cour obj)
        {
            if (obj == null)
                return null;
            return new DTO.CoursDTO()
            {
                Id = obj.Id,
                PoolId = obj.PoolId,               
                Name = obj.Name,
                PeopleAmount = obj.PeopleAmount,
                Dis = obj.Dis,
                Price = obj.Price,
                StartHour = obj.StartHour,
                EndHour = obj.EndHour,       
                Day = obj.Day,
                Type = obj.Type,
            };
        }
        #endregion
      
        #region המרה משכבת דל לשכבת דיטיאו
        public static DAL.Cour Convert(DTO.CoursDTO obj)
        {
            if (obj == null)
                return null;
            return new DAL.Cour()
            {
                Id = obj.Id,
                PoolId = obj.PoolId,
                Name = obj.Name,
                PeopleAmount = obj.PeopleAmount,
                Dis = obj.Dis,
                Price = obj.Price,
                StartHour = obj.StartHour,
                EndHour = obj.EndHour,
                Day = obj.Day,
                Type = obj.Type,
            };
        }
        #endregion

        #region המרה של מערך מדיטיאו לדל
        public static List<DAL.Cour> Convert(List<DTO.CoursDTO> obj)
        {
            return obj.Select(x => Convert(x)).ToList();
        }
        #endregion

        #region המרה של מערך דלמ לדיטיאו
 public static List<DTO.CoursDTO> Convert(List<DAL.Cour> obj)
        {
            return obj.Select(x => Convert(x)).ToList();
        }
        #endregion
       
    }
}

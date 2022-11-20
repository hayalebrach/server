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
        public static DTO.CoursDTO Convert(DAL.Course  obj)
        {
            
            if (obj == null)
                return null;
            return new DTO.CoursDTO()
            {
                Id = obj.Id,
                IdPool = obj.IdPool,
                NameCours = obj.NameCours,
                PeopleAmount = obj.PeopleAmount,
                Dis = obj.Dis,
                IdUser = obj.IdUser,
               /* PoolName = obj.Pool?.Name,
                EmailGuide = obj.User?.Email,
                PhoneGuide = obj.User?.Phone*/
            };
   
        }
        #endregion
      
        #region המרה משכבת דל לשכבת דיטיאו
        public static DAL.Course Convert(DTO.CoursDTO obj)
        {
            if (obj == null)
                return null;
            return new DAL.Course()
            {
                Id = obj.Id,
                PeopleAmount = obj.PeopleAmount,
                Dis = obj.Dis,
               

            };
        }
        #endregion

        #region המרה של מערך מדיטיאו לדל
        public static List<DAL.Course> Convert(List<DTO.CoursDTO> obj)
        {
            return obj.Select(x => Convert(x)).ToList();
        }
        #endregion

        #region המרה של מערך דלמ לדיטיאו
 public static List<DTO.CoursDTO> Convert(List<DAL.Course> obj)
        {
            return obj.Select(x => Convert(x)).ToList();
        }
        #endregion
       
    }
}

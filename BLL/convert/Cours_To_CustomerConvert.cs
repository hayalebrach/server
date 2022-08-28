using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.convert
{
    public class Cours_To_CustomerConvert
    {
      
        #region המרה משכבת דיטיאו לשכבת דל
        public static DTO.Cours_To_CustomerDTO Convert(DAL.CoursToCustomer obj)
        {
            if (obj == null)
                return null;
            return new DTO.Cours_To_CustomerDTO()
            {
                Id = obj.Id,
               
            };
        }
        #endregion

        #region המרה משכבת דל לשכבת דיטיאו

        public static DAL.CoursToCustomer Convert(DTO.Cours_To_CustomerDTO obj)
        {
            if (obj == null)
                return null;
            return new DAL.CoursToCustomer()
            {
                Id = obj.Id,
              
            };
        }
        #endregion
    
        #region המרה של מערך מדיטיאו לדל
        public static List<DAL.CoursToCustomer> Convert(List<DTO.Cours_To_CustomerDTO> obj)
        {
            return obj.Select(x => Convert(x)).ToList();
        }
        #endregion
      
        #region המרה של מערך דלמ לדיטיאו
        public static List<DTO.Cours_To_CustomerDTO> Convert(List<DAL.CoursToCustomer> obj)
        {
            return obj.Select(x => Convert(x)).ToList();
        }
        #endregion
       
    }
}

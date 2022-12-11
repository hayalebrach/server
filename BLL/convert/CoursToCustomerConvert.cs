using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.convert
{
    public class CoursToCustomerConvert
    {
        #region המרה משכבת דיטיאו לשכבת דל
        public static DTO.CoursToCustomerDTO Convert(DAL.CoursToCustomer obj)
        {
            if (obj == null)
                return null;
            return new DTO.CoursToCustomerDTO()
            {
                Id = obj.Id,
                IdCours = obj.IdCours,
                IdUser = obj.IdUser

            };
        }
        #endregion

        #region המרה משכבת דל לשכבת דיטיאו

        public static DAL.CoursToCustomer Convert(DTO.CoursToCustomerDTO obj)
        {
            if (obj == null)
                return null;
            return new DAL.CoursToCustomer()
            {
                Id = obj.Id,

                IdCours= ((int)obj.IdCours),
                IdUser= ((int)obj.IdUser),
                Status=obj.Status
                



            };
        }
        #endregion

        #region המרה של מערך מדיטיאו לדל
        public static List<DAL.CoursToCustomer> Convert(List<DTO.CoursToCustomerDTO> obj)
        {
            return obj.Select(x => Convert(x)).ToList();
        }
        #endregion

        #region המרה של מערך דלמ לדיטיאו
        public static List<DTO.CoursToCustomerDTO> Convert(List<DAL.CoursToCustomer> obj)
        {
            return obj.Select(x => Convert(x)).ToList();
        }
        #endregion

    }
}


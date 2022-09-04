using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.convert
{
    public class RoleConvert
    {
        #region המרה משכבת דל לשכבת דיטיאו
        public static DTO.RoleDTO Convert(DAL.Role obj)
        {
            if (obj == null)
                return null;
            return new DTO.RoleDTO()
            {
                Id = obj.Id,
                TypeUser= obj.TypeUser
            };
        }
        #endregion

        #region המרה משכבת דיטיאו לשכבת דל
        public static DAL.Role Convert(DTO.RoleDTO obj)
        {
            if (obj == null)
                return null;
            return new DAL.Role()
            {
                Id = obj.Id,
                TypeUser = obj.TypeUser
            };
        }
        #endregion

        #region המרה של מערך מדיטיאו לדל
        public static List<DAL.Role> Convert(List<DTO.RoleDTO> obj)
        {
            return obj.Select(x => Convert(x)).ToList();
        }
        #endregion

        #region המרה של מערך דלמ לדיטיאו
        public static List<DTO.RoleDTO> Convert(List<DAL.Role> obj)
        {
            return obj.Select(x => Convert(x)).ToList();
        }
        #endregion
    }
}

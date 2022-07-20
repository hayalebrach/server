using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.convert
{
    public class UserConvert
    {
        #region המרה משכבת דיטיאו לשכבת דל
        public static DTO.UserDTO Convert(DAL.User obj)
        {
            if (obj == null)
                return null;
            return new DTO.UserDTO()
            {
                Id = obj.Id,
                Name = obj.Name,
                Email = obj.Email,
                Phone = obj.Phone,
                Type = obj.Type,
                Authorization = obj.Authorization,
                LastEentry=obj.LastEentry
            };
        }
        #endregion

        #region המרה משכבת דל לשכבת דיטיאו
        public static DAL.User Convert(DTO.UserDTO obj)
        {
            if (obj == null)
                return null;
            return new DAL.User()
            {
                Id = obj.Id,
                Name = obj.Name,
                Email = obj.Email,
                Phone = obj.Phone,
                Type = obj.Type,
                Authorization = obj.Authorization,
                LastEentry = obj.LastEentry
            };
        }
        #endregion

        #region המרה של מערך מדיטיאו לדל
        public static List<DAL.User> Convert(List<DTO.UserDTO> obj)
        {
            return obj.Select(x => Convert(x)).ToList();
        }
        #endregion

        #region המרה של מערך דלמ לדיטיאו
        public static List<DTO.UserDTO> Convert(List<DAL.User> obj)
        {
            return obj.Select(x => Convert(x)).ToList();
        }
        #endregion

    }
}

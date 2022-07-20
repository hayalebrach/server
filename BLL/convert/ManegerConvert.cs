using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.convert
{
    public class ManegerConvert
    {

        #region המרה משכבת דיטיאו לשכבת דל
        public static DTO.ManegerDTO Convert(DAL.Maneger obj)
        {
            if (obj == null)
                return null;
            return new DTO.ManegerDTO()
            {
                Id = obj.Id,
                Name = obj.Name,
                Phone = obj.Phone,
                Email = obj.Email,
            };
        }
        #endregion

        #region המרה משכבת דל לשכבת דיטיאו
        public static DAL.Maneger Convert(DTO.ManegerDTO obj)
        {
            if (obj == null)
                return null;
            return new DAL.Maneger()
            {
                Id = obj.Id,
                Name = obj.Name,
                Phone = obj.Phone,
                Email = obj.Email,
            };
        }
        #endregion

        #region המרה של מערך מדיטיאו לדל
        public static List<DAL.Maneger> Convert(List<DTO.ManegerDTO> obj)
        {
            return obj.Select(x => Convert(x)).ToList();
        }
        #endregion

        #region המרה של מערך דלמ לדיטיאו
        public static List<DTO.ManegerDTO> Convert(List<DAL.Maneger> obj)
        {
            return obj.Select(x => Convert(x)).ToList();
        }
        #endregion

    }
}

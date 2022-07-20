using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.convert
{
    public class EreaConvert
    {

        #region המרה משכבת דיטיאו לשכבת דל
        public static DTO.EreaDTO Convert(DAL.Erea obj)
        {
            if (obj == null)
                return null;
            return new DTO.EreaDTO()
            {
                Id = obj.Id,
                Name = obj.Name,

            };
        }
        #endregion

        #region המרה משכבת דל לשכבת דיטיאו
        public static DAL.Erea Convert(DTO.EreaDTO obj)
        {
            if (obj == null)
                return null;
            return new DAL.Erea()
            {
                Id = obj.Id,
                Name = obj.Name,
            };
        }
        #endregion

        #region המרה של מערך מדיטיאו לדל
        public static List<DAL.Erea> Convert(List<DTO.EreaDTO> obj)
        {
            return obj.Select(x => Convert(x)).ToList();
        }
        #endregion

        #region המרה של מערך דלמ לדיטיאו
        public static List<DTO.EreaDTO> Convert(List<DAL.Erea> obj)
        {
            return obj.Select(x => Convert(x)).ToList();
        }
        #endregion
    }
}

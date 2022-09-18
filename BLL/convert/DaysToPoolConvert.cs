using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.convert
{
    public class DaysToPoolConvert
    {
        #region המרה משכבת דל לשכבת דיטיאו
        public static DTO.DaysToPoolDTO Convert(DAL.DaysToPool obj)
        {
            if (obj == null)
                return null;
            return new DTO.DaysToPoolDTO()
            {
                Id = obj.Id,
            };
        }
        #endregion

        #region המרה משכבת דיטיאו לשכבת דל
        public static DAL.DaysToPool Convert(DTO.DaysToPoolDTO obj)
        {
            if (obj == null)
                return null;
            return new DAL.DaysToPool()
            {
                Id = obj.Id
            };
        }
        #endregion

        #region המרה של מערך מדיטיאו לדל
        public static List<DAL.DaysToPool> Convert(List<DTO.DaysToPoolDTO> obj)
        {
            return obj.Select(x => Convert(x)).ToList();
        }
        #endregion

        #region המרה של מערך דלמ לדיטיאו
        public static List<DTO.DaysToPoolDTO> Convert(List<DAL.DaysToPool> obj)
        {
            return obj.Select(x => Convert(x)).ToList();
        }
        #endregion
    }
}

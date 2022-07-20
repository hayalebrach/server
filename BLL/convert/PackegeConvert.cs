using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.convert
{
    public class PackegeConvert
    {

        #region המרה משכבת דיטיאו לשכבת דל
        public static DTO.PackegeDTO Convert(DAL.Packege obj)
        {
            if (obj == null)
                return null;
            return new DTO.PackegeDTO()
            {
                Id = obj.Id,
                PoolId = obj.PoolId,
                EntersAmount = obj.EntersAmount,
                Price = obj.Price
            };
        }
        #endregion

        #region המרה משכבת דל לשכבת דיטיאו
        public static DAL.Packege Convert(DTO.PackegeDTO obj)
        {
            if (obj == null)
                return null;
            return new DAL.Packege()
            {
                Id = obj.Id,
                PoolId = obj.PoolId,
                EntersAmount = obj.EntersAmount,
                Price = obj.Price
            };
        }
        #endregion

        #region המרה של מערך מדיטיאו לדל
        public static List<DAL.Packege> Convert(List<DTO.PackegeDTO> obj)
        {
            return obj.Select(x => Convert(x)).ToList();
        }
        #endregion

        #region המרה של מערך דלמ לדיטיאו
        public static List<DTO.PackegeDTO> Convert(List<DAL.Packege> obj)
        {
            return obj.Select(x => Convert(x)).ToList();
        }
        #endregion

    }
}

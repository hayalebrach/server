using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.convert
{
    public class PoolConvert
    {

        #region המרה משכבת דיטיאו לשכבת דל
        public static DTO.PoolDTO Convert(DAL.Pool obj)
        {
            if (obj == null)
                return null;
            return new DTO.PoolDTO()
            {
                Id = obj.Id,
                Name=obj.Name,
                Address = obj.Address,
                Price = obj.Price,
                Amount = obj.Amount,
                ManagerId = obj.ManagerId,
                PositionId=obj.PositionId
            };
        }
        #endregion

        #region המרה משכבת דל לשכבת דיטיאו
        public static DAL.Pool Convert(DTO.PoolDTO obj)
        {
            if (obj == null)
                return null;
            return new DAL.Pool()
            {
                Id = obj.Id,
                Name = obj.Name,
                Address = obj.Address,
                Price = obj.Price,
                Amount = obj.Amount,
                ManagerId = obj.ManagerId,
                PositionId = obj.PositionId
            };
        }
        #endregion

        #region המרה של מערך מדיטיאו לדל
        public static List<DAL.Pool> Convert(List<DTO.PoolDTO> obj)
        {
            return obj.Select(x => Convert(x)).ToList();
        }
        #endregion

        #region המרה של מערך דלמ לדיטיאו
        public static List<DTO.PoolDTO> Convert(List<DAL.Pool> obj)
        {
            return obj.Select(x => Convert(x)).ToList();
        }
        #endregion
    }
}

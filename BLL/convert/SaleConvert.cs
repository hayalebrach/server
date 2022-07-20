using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.convert
{
    public class SaleConvert
    {
        #region המרה משכבת דיטיאו לשכבת דל
        public static DTO.SaleDTO Convert(DAL.Sale obj)
        {
            if (obj == null)
                return null;
            return new DTO.SaleDTO()
            {
                Id = obj.Id,
                PoolId = obj.PoolId,
                Dis = obj.Dis,
                StartDate = obj.StartDate,
                EndDate = obj.EndDate,
                EnteriesAmount = obj.EnteriesAmount,
                Price=obj.Price
            };
        }
        #endregion

        #region המרה משכבת דל לשכבת דיטיאו
        public static DAL.Sale Convert(DTO.SaleDTO obj)
        {
            if (obj == null)
                return null;
            return new DAL.Sale()
            {
                Id = obj.Id,
                PoolId = obj.PoolId,
                Dis = obj.Dis,
                StartDate = obj.StartDate,
                EndDate = obj.EndDate,
                EnteriesAmount = obj.EnteriesAmount,
                Price = obj.Price
            };
        }
        #endregion

        #region המרה של מערך מדיטיאו לדל
        public static List<DAL.Sale> Convert(List<DTO.SaleDTO> obj)
        {
            return obj.Select(x => Convert(x)).ToList();
        }
        #endregion

        #region המרה של מערך דלמ לדיטיאו
        public static List<DTO.SaleDTO> Convert(List<DAL.Sale> obj)
        {
            return obj.Select(x => Convert(x)).ToList();
        }
        #endregion

    }
}

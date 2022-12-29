using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.convert
{
    public class Customr_To_PoolConvert
    {

        #region המרה משכבת דיטיאו לשכבת דל
        public static DTO.Customr_To_PoolDTO Convert(DAL.CustomerToPool obj)
        {
            if (obj == null)
                return null;
            return new DTO.Customr_To_PoolDTO()
            {
                Id = obj.Id,
                IdPackage = obj.IdPackage,
                IdUser = obj.IdUser,
                AmountLeft = obj.AmountLeft,
                AmountGet = obj.AmountGet,
                TotalPrice = obj.TotalPrice,
                DateBuy = obj.DateBuy,
                Status = obj.Status,
                IdPool=obj.Package!=null?(int)obj.Package.IdPool:0
               

                

            };
        }
        #endregion

        #region המרה משכבת דל לשכבת דיטיאו
        public static DAL.CustomerToPool Convert(DTO.Customr_To_PoolDTO obj)
        {
            if (obj == null)
                return null;
            return new DAL.CustomerToPool()
            {
                Id = obj.Id,             
                AmountLeft = obj.AmountLeft,
                AmountGet = obj.AmountGet,
                TotalPrice = obj.TotalPrice,
                DateBuy = obj.DateBuy,
                IdPackage =((int) obj.IdPackage),
                IdUser = ((int)obj.IdUser),
                Status=obj.Status,
                
            };
        }
        #endregion

        #region המרה של מערך מדיטיאו לדל
        public static List<DAL.CustomerToPool> Convert(List<DTO.Customr_To_PoolDTO> obj)
        {
            return obj.Select(x => Convert(x)).ToList();
        }
        #endregion

        #region המרה של מערך דלמ לדיטיאו
        public static List<DTO.Customr_To_PoolDTO> Convert(List<DAL.CustomerToPool> obj)
        {
            return obj.Select(x => Convert(x)).ToList();
        }
        #endregion

    }
}

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
        public static DTO.PackegeDTO Convert(DAL.Package obj)
        {
            if (obj == null)
                return null;
            return new DTO.PackegeDTO()
            {
                Id = obj.Id,
                IdPool = obj.IdPool,
                EntersAmount = obj.EntersAmount,
                Price = obj.Price,
            
            };
        }
        #endregion

        #region המרה משכבת דל לשכבת דיטיאו
        public static DAL.Package Convert(DTO.PackegeDTO obj)
        {
            if (obj == null)
                return null;
            return new DAL.Package()
            {
                Id = obj.Id,
                IdPool = ((int)obj.IdPool),
                EntersAmount = obj.EntersAmount,
                Price = obj.Price, 
                
            };
        }
        #endregion

        #region המרה של מערך מדיטיאו לדל
        public static List<DAL.Package> Convert(List<DTO.PackegeDTO> obj)
        {
            return obj.Select(x => Convert(x)).ToList();
        }
        #endregion

        #region המרה של מערך דלמ לדיטיאו
        public static List<DTO.PackegeDTO> Convert(List<DAL.Package> obj)
        {
            return obj.Select(x => Convert(x)).ToList();
        }
        #endregion

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.convert
{
    public class RolesToPoolConvert
    {
        #region המרה משכבת דיטיאו לשכבת דל
        public static DTO.RolesToPoolDTO Convert(DAL.RolesToPool obj)
        {

            if (obj == null)
                return null;
            return new DTO.RolesToPoolDTO()
            {
                Id = obj.Id,
                IdPool = obj.IdPool,
                IdUser = obj.IdUser,
                IdRole = obj.IdRole,
            };

        }
        #endregion

        #region המרה משכבת דל לשכבת דיטיאו
        public static DAL.RolesToPool Convert(DTO.RolesToPoolDTO obj)
        {
            if (obj == null)
                return null;
            return new DAL.RolesToPool()
            {
                Id = obj.Id,
                IdPool = obj.IdPool,
                IdRole = obj.IdRole,
                IdUser = obj.IdUser,
            };
        }
        #endregion

        #region המרה של מערך מדיטיאו לדל
        public static List<DAL.RolesToPool> Convert(List<DTO.RolesToPoolDTO> obj)
        {
            return obj.Select(x => Convert(x)).ToList();
        }
        #endregion

        #region המרה של מערך דלמ לדיטיאו
        public static List<DTO.RolesToPoolDTO> Convert(List<DAL.RolesToPool> obj)
        {
            return obj.Select(x => Convert(x)).ToList();
        }
        #endregion
    }
}

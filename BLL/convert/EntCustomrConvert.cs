using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.convert
{
    public class EntCustomrConvert
    {
       
        #region המרה משכבת דיטיאו לשכבת דל
        public static DTO.EntCustomrDTO Convert(DAL.EntCustomr obj)
        {
            if (obj == null)
                return null;
            return new DTO.EntCustomrDTO()
            {
                Id = obj.Id,
                PoolId = obj.PoolId,
                CustomerToPool_Id = obj.CustomerToPool_Id,
                EnterDate = obj.EnterDate,
                StartHour = obj.StartHour,
                FinishHour = obj.FinishHour
            };
        }
        #endregion

        #region המרה משכבת דל לשכבת דיטיאו
        public static DAL.EntCustomr Convert(DTO.EntCustomrDTO obj)
        {
            if (obj == null)
                return null;
            return new DAL.EntCustomr()
            {
                Id = obj.Id,
                PoolId = obj.PoolId,
                CustomerToPool_Id = obj.CustomerToPool_Id,
                EnterDate = obj.EnterDate,
                StartHour = obj.StartHour,
                FinishHour = obj.FinishHour
            };
        }
        #endregion

        #region המרה של מערך מדיטיאו לדל
        public static List<DAL.EntCustomr> Convert(List<DTO.EntCustomrDTO> obj)
        {
            return obj.Select(x => Convert(x)).ToList();
        }
        #endregion

        #region המרה של מערך דלמ לדיטיאו
        public static List<DTO.EntCustomrDTO> Convert(List<DAL.EntCustomr> obj)
        {
            return obj.Select(x => Convert(x)).ToList();
        }
        #endregion

    }
}

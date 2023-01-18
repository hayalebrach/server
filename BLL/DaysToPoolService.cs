using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public  class DaysToPoolService
    {
        DAL.Model.DaysToPoolModel model = new DAL.Model.DaysToPoolModel();
        //לוקחת שעה בבריכה לפי ת"ז

        public DTO.DaysToPoolDTO Get(int Id)
        {
            return convert.DaysToPoolConvert.Convert(model.Get(Id));
        }
        //לוקחת מערכת שעות לבריכה
        public List<DTO.DaysToPoolDTO> GetTimeByIdPool(int IdPool)
        {
            return convert.DaysToPoolConvert.Convert(model.GetTimeByIdPool(IdPool));
        }
        //הוספת זמן
        public DTO.DaysToPoolDTO AddDaysToPool(DTO.DaysToPoolDTO DaysToPool) 
        {
            return convert.DaysToPoolConvert.Convert(model.AddDaysToPool(convert.DaysToPoolConvert.Convert(DaysToPool)));
        }
    }
}

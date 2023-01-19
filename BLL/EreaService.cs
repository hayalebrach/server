using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class EreaService
    {
        DAL.Model.EreaModel model = new DAL.Model.EreaModel();
        //מחזירה את כל האיזורים
        public List<DTO.EreaDTO> GetAllEreas()
        {
            return convert.EreaConvert.Convert(model.GetAllEreas());
        }
        //פונקציה שמחזירה לי אוביקט שהשם שלו שווה לשם שהיא קיבלה
        public DTO.EreaDTO GetByName(string Name)
        {
            return convert.EreaConvert.Convert(model.GetByName(Name));
        }
        //הוספת איזור
        public DTO.EreaDTO Post(DTO.EreaDTO Erea)
        {
            return convert.EreaConvert.Convert(model.Post(convert.EreaConvert.Convert(Erea)));

        }

    }
}

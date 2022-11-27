using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PackegeService
    {
        DAL.Model.PackegeModel model = new DAL.Model.PackegeModel();
       
        //ייבוא של הכרטיסים לפי ת"ז בריכה
        public List<DTO.PackegeDTO> GetCardsByIdPool(int IdPool)
        {
            return convert.PackegeConvert.Convert(model.GetCardsByIdPool(IdPool));
        }
        //הוספת כרטיס
        public DTO.PackegeDTO AddCard(DTO.PackegeDTO Card)
        {
            return convert.PackegeConvert.Convert(model.AddCard(convert.PackegeConvert.Convert(Card)));
        }
        //עדכון משתמש
        public DTO.PackegeDTO Put(DTO.PackegeDTO Packege)
        {
            return convert.PackegeConvert.Convert(model.Put(convert.PackegeConvert.Convert(Packege)));

        }
        //מחיקה
        public DTO.PackegeDTO PutForDelete(DTO.PackegeDTO Packege)
        {
            return convert.PackegeConvert.Convert(model.PutForDelete(convert.PackegeConvert.Convert(Packege)));

        }
    }
}

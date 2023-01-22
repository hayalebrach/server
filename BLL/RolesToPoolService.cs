//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace BLL
//{
//    public class RolesToPoolService
//    {
//        DAL.Model.RolesToPoolModel model = new DAL.Model.RolesToPoolModel();
//        //פונקציה שמכניסה מדריך לקורס ולבריכה
//        public DTO.RolesToPoolDTO AddGuide(DTO.RolesToPoolDTO RolesToPool)
//        {
//            return convert.RolesToPoolConvert.Convert(model.AddGuide(convert.RolesToPoolConvert.Convert(RolesToPool)));
//        }
//        //פונקציה שלוקחת מדריכים לבריכות

//        public List<DTO.RolesToPoolDTO> GetTheGuideToPool(int IdPool)
//        {
//            return convert.RolesToPoolConvert.Convert(model.GetTheGuideToPool(IdPool));
//        }

//    }
//}

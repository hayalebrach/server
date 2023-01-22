//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;


//namespace BLL.convert
//{
//   public class ImagesConvert
//   {

//       public static DTO.ImagesDTO Convert(DAL.Image obj)
//       {

//           if (obj == null)
//               return null;
//           return new DTO.ImagesDTO()
//           {
//               Id = obj.Id,
//               NameImage=obj.NameImage,
//               ImageCaption=obj.ImageCaption,
//               FileValue=obj.FileValue,


//           };

//       }


//       #region המרה משכבת דל לשכבת דיטיאו
//       public static DAL.Image Convert(DTO.ImagesDTO obj)
//       {
//           if (obj == null)
//               return null;
//           return new DAL.Image()
//           {

//               Id = obj.Id,
//               NameImage = obj.NameImage,
//               ImageCaption = obj.ImageCaption,
//               FileValue = obj.FileValue,


//           };
//       }
//       #endregion

//       #region המרה של מערך מדיטיאו לדל
//       public static List<DAL.Image> Convert(List<DTO.ImagesDTO> obj)
//       {
//           return obj.Select(x => Convert(x)).ToList();
//       }
//       #endregion

//       #region המרה של מערך דלמ לדיטיאו
//       public static List<DTO.ImagesDTO> Convert(List<DAL.Image> obj)
//       {
//           return obj.Select(x => Convert(x)).ToList();
//       }
//       #endregion
//   }
//}


using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ImagesService
    {
        DAL.Model.ImagesModel model = new DAL.Model.ImagesModel();


        public DTO.PoolDTO Post(DTO.ImagesDTO image, byte[] data)
        {
            uploadImgBytes(image.NameImage, data);
            return convert.PoolConvert.Convert(model.Post(image.IdPool,image.NameImage));
        }

        public void uploadImgBytes(string FileName, byte[] data)
        {

            string full = Path.Combine(@"C:\Users\liel mymon\OneDrive\מסמכים\GitHub\client\public\Pic");
            if (!Directory.Exists(full))
            {
                Directory.CreateDirectory(full);
            }
            full = Path.Combine(full + "/" +FileName);
            if (File.Exists(full))
            {
                File.Delete(full);
            }
            using (Stream file = File.OpenWrite(full))
            {
                byte[] t = data;
                file.Write(t, 0, t.Length);
                file.Close();
            }

        }
    }
}

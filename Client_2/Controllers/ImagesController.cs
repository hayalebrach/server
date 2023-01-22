using System;
using System.Collections.Generic;
using System.Linq;
using BLL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace Client_2.Controllers
{
    public class ImagesController : ApiController
    {
        BLL.ImagesService service = new BLL.ImagesService();


        public IHttpActionResult uploadImag()
        {
            try
            {
                //string imageName = null;
                var httpReqest = HttpContext.Current.Request;
                // upload image
                var postedFile = httpReqest.Files["Image"];
                var id = httpReqest.Params["ItemId"];

                //var Id = httpReqest.Params["Id"];
                string imageName = new String(Path.GetFileNameWithoutExtension(postedFile.FileName).ToArray()).Replace(" ", "-");

                byte[] buffer = new byte[16 * 1024];
                byte[] data;
                using (MemoryStream ms = new MemoryStream())
                {
                    int read;
                    while ((read = postedFile.InputStream.Read(buffer, 0, buffer.Length)) > 0)
                        ms.Write(buffer, 0, read);

                    //return ms.ToArray();
                    data = ms.ToArray();
                    DTO.ImagesDTO Image = new DTO.ImagesDTO()
                    {
                        NameImage = postedFile.FileName,
                        IdPool = Convert.ToInt32(id)
                    };

                    ImagesService service = new ImagesService();
                    service.Post(Image, data);
                    return Ok(data);
                }
                //int.TryParse(Id, out int AttractionId);

            }

            catch (Exception e)
            {
                return BadRequest(" לא הצלחנו להוסיף את התמונה כדאי לנסות לשנות את השם");
            }
        }
    }
}

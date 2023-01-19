using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Client_2.Controllers
{
    public class EntCustomrController : ApiController
    {   

        BLL.EntCustomrService service = new BLL.EntCustomrService();

        //לוקחת את כל המשתמשים לבריכה זו באותו ביום
        [HttpGet]
        [Route("~/api/EntCustomr/GetAllNumPeople")]

        public List<DTO.EntCustomrDTO> GetAllNumPeople(int IdPool)
        {
            return service.GetAllNumPeople(IdPool);
        }
        //שמירת מקום
        [HttpPost]
        public DTO.EntCustomrDTO Post(DTO.EntCustomrDTO EntCustomrDTO)
        {
            return service.Post(EntCustomrDTO);
        }
    }
}

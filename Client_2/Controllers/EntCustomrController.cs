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
        [HttpGet]
        [Route("~/api/EntCustomr/GetAllNumPeople")]

        public List<DTO.EntCustomrDTO> GetAllNumPeople(int IdPool)
        {
            return service.GetAllNumPeople(IdPool);
        }
        [HttpPost]
        public DTO.EntCustomrDTO Post(DTO.EntCustomrDTO EntCustomrDTO)
        {
            return service.Post(EntCustomrDTO);
        }
    }
}

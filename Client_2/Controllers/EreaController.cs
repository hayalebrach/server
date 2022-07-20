using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Client_2.Controllers
{
    public class EreaController : ApiController
    {
        BLL.EreaService service = new BLL.EreaService();
        public List<DTO.EreaDTO> Get()
        {
            return service.Get();
        }
    }
}

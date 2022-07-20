using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Client_2.Controllers
{
    public class ManegerController : ApiController
    {
        BLL.ManegerService service = new BLL.ManegerService();
        public List<DTO.ManegerDTO> Get()
        {
            return service.Get();
        }
    }
}

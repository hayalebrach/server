using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Client_2.Controllers
{
    public class ActiveHourController : ApiController
    {
        BLL.ActiveHourService service = new BLL.ActiveHourService();
        public List<DTO.ActiveHourDTO> Get()
        {
            return service.Get();
        }
    }
}

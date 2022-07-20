using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Client_2.Controllers
{
    public class PoolController : ApiController
    {
        BLL.PoolService service = new BLL.PoolService();
        public List<DTO.PoolDTO> Get()
        {
            return service.Get();
        }
    }
}

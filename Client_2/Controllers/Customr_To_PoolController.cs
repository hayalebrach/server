using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Client_2.Controllers
{
    public class Customr_To_PoolController : ApiController
    {
        BLL.Customr_To_PoolService service = new BLL.Customr_To_PoolService();
        public List<DTO.Customr_To_PoolDTO> Get()
        {
            return service.Get();
        }
    }
}

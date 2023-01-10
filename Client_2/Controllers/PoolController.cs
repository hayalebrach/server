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

        [HttpGet]
        public List<DTO.PoolDTO> GetAllPools()
        {
            return service.GetAllPools();
        }
        //הוספת בריכה
        [HttpPost]
        public DTO.PoolDTO AddPool(DTO.PoolDTO Pool)
        {
            return service.AddPool(Pool);
        }




    }
}

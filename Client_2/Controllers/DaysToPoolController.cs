using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Client_2.Controllers
{
    public class DaysToPoolController : ApiController
    {
        BLL.DaysToPoolService service = new BLL.DaysToPoolService();


        [HttpGet]
        public List<DTO.DaysToPoolDTO> GetTimeByIdPool(int IdPool)
        {
            return service.GetTimeByIdPool(IdPool);
        }
        [HttpPut]
        public DTO.DaysToPoolDTO AddDaysToPool(DTO.DaysToPoolDTO DaysToPool)
        {
            return service.AddDaysToPool(DaysToPool);
        }
    }
}

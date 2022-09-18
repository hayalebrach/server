using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Client_2.Controllers
{
    public class DaysController : ApiController
    {
        BLL.DayServiice service=new BLL.DayServiice();


        [HttpGet]
        public List<DTO.DaysDTO> GetAllDays()
        {
            return service.Get();
        }
    }
}

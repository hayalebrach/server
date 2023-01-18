using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Client_2.Controllers
{
    public class DaysToCoursController : ApiController
    {
        BLL.DayToCoursService service = new BLL.DayToCoursService();
        [HttpGet]
        //לוקחת מערכת שעות לבריכה
        [Route("~/api/DayToCours/GetTimeByIdPool")]
        public List<DTO.DayToCoursDTO> GetTimeByIdPool(int IdPool)
        {
            return service.GetTimeByIdPool(IdPool);
        }
        //מוסיפה שעה לבריכה
        [HttpPut]
        public DTO.DayToCoursDTO AddDayToCours(DTO.DayToCoursDTO DayToCours)
        {
            return service.AddDayToCours(DayToCours);
        }


    }
}

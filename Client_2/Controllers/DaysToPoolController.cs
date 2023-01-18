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

        //לוקחת שעה בבריכה לפי ת"ז
        [HttpGet]
        [Route("~/api/DaysToPool/Get")]

        public DTO.DaysToPoolDTO Get(int Id)
        {
            return service.Get(Id);
        } 
        //לוקחת מערכת שעות לבריכה
        [Route("~/api/DaysToPool/GetTimeByIdPool")]
        public List<DTO.DaysToPoolDTO> GetTimeByIdPool(int IdPool)
        {
            return service.GetTimeByIdPool(IdPool);
        }
        //מוסיפה לבריכה זמן
        [HttpPut]
        public DTO.DaysToPoolDTO AddDaysToPool(DTO.DaysToPoolDTO DaysToPool)
        {
            return service.AddDaysToPool(DaysToPool);
        }
    }
}

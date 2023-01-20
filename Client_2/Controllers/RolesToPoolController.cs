using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Client_2.Controllers
{
    public class RolesToPoolController : ApiController
    {
        BLL.RolesToPoolService service = new BLL.RolesToPoolService();
        [HttpPost]
        //פונקציה שמכניסה מדריך לקורס ולבריכה
        public DTO.RolesToPoolDTO AddGuide(DTO.RolesToPoolDTO RolesToPool)
        {
            return service.AddGuide(RolesToPool);
        }
        [HttpGet]
        //פונקציה שלוקחת מדריכים לבריכות

        public List<DTO.RolesToPoolDTO> GetTheGuideToPool(int IdPool)
        {
            return service.GetTheGuideToPool(IdPool);
        }
    }
}

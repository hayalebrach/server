using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Client_2.Controllers
{
    public class EreaController : ApiController
    {
        BLL.EreaService service = new BLL.EreaService();
        //ייבוא של כל האיזורים
        public List<DTO.EreaDTO> GetAllEreas()
        {
            return service.GetAllEreas();
        }
        //הוספת איזור
        [HttpPost]
        public DTO.EreaDTO Post(DTO.EreaDTO Erea)
        {
            return service.Post(Erea);
        }

        //פונקציה שמחזירה לי אוביקט שהשם שלו שווה לשם שהיא קיבלה
        public DTO.EreaDTO GetByName(string Name)
        {
            return service.GetByName(Name);
        }
    }

}

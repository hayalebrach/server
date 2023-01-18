using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Client_2.Controllers
{
    public class PackegeController : ApiController
    {
        BLL.PackegeService service = new BLL.PackegeService();
       //לוקחת כרטיס לפי ת"ז
        public DTO.PackegeDTO GetCardsById(int Id)
        {
            return service.GetCardsById(Id);
        }
        [Route("~/api/Packege/GetCardsByIdPool")]

        //ייבוא של הכרטיסים לפי ת"ז בריכה
        public List<DTO.PackegeDTO> GetCardsByIdPool(int IdPool)
        {
            return service.GetCardsByIdPool(IdPool);
        }
        //הוספת כרטיס
        [HttpPost]
        public DTO.PackegeDTO AddCard(DTO.PackegeDTO Card)
        {
            return service.AddCard(Card);
        }
        //עדכון
        [HttpPut]
        [Route("~/api/Packege/Put")]
        public DTO.PackegeDTO Put(DTO.PackegeDTO Packege)
        {
            return service.Put(Packege);
        }
        //מחיקה
        [HttpPut]
        public DTO.PackegeDTO PutForDelete(DTO.PackegeDTO package)
        {
            return service.PutForDelete(package);
        }
    }
}

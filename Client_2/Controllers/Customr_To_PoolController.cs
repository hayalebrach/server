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

        public List<DTO.Customr_To_PoolDTO> GetAll()
        {
            return service.GetAll();
        }

        //פונקציה שמיבאת לקוחות לבריכה מסוימת לפי id
        public List<DTO.Customr_To_PoolDTO> GetByIdPool(int IdPool)
        {
            return service.GetByIdPool(IdPool);
        }
        [HttpGet]
        //פונקציה שמביאה היסטורית קניות של לקוח בבריכה מסוימת
        public List<DTO.Customr_To_PoolDTO> GetHistoryOfUser(int IdUser)
        {
            return service.GetHistoryOfUser(IdUser);
        }
        //פונקציה שמביאה היסטורית קניותשל משתמש למנהל בריכה מסוימת
        public List<DTO.Customr_To_PoolDTO> GetHistoryByIdPoolAndIdUser(int IdUser, int IdPool)
        {
            return service.GetHistoryByIdPoolAndIdUser(IdUser, IdPool);
        }
        //מביאה את כל המתמשים לבריכה
        public List<DTO.Customr_To_PoolDTO> Get()
        {
            return service.Get();
        }
        //רכישת כרטיסיה של לקוח
        public DTO.Customr_To_PoolDTO Purchasing(DTO.Customr_To_PoolDTO purchase)
        {
            return service.Purchasing(purchase);
        }
        //פונקצית עדכון כשלקוח משתמש בכרטיסיה מסוימת
        [HttpPut]
        [Route("~/api/Customr_To_Pool/Put")]
        public DTO.Customr_To_PoolDTO Put(int Id,int AmountGet)
        {
            return service.Put(Id,AmountGet);
        }
    }
}




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
        public List<DTO.Customr_To_PoolDTO> GetHistoryOfUser(int IdUser)
        {
            return service.GetHistoryOfUser(IdUser);
        }

        public List<DTO.Customr_To_PoolDTO> GetHistoryByIdPoolAndIdUser(int IdUser, int IdPool)
        {
            return service.GetHistoryByIdPoolAndIdUser(IdUser, IdPool);
        }


        public DTO.Customr_To_PoolDTO Purchasing(DTO.Customr_To_PoolDTO purchase)
        {
            return service.Purchasing(purchase);
        }




        
        public List<DTO.Customr_To_PoolDTO> Get()
        {
            return service.Get();
        }
        [HttpPut]
        [Route("~/api/Customr_To_Pool/Put")]
        public DTO.Customr_To_PoolDTO Put(int Id,int AmountGet)
        {
            return service.Put(Id,AmountGet);
        }
    }
}




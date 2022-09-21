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
        public List<DTO.PackegeDTO> Get(int IdPool)
        {
            return service.Get(IdPool);
        }

        public DTO.PackegeDTO AddCard(DTO.PackegeDTO Card)
        {
            return service.AddCard(Card);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Client_2.Controllers
{
    public class SaleController : ApiController
    {
        BLL.SaleService service = new BLL.SaleService();
        public List<DTO.SaleDTO> Get()
        {
            return service.Get();
        }
    }
}

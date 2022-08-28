using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Client_2.Controllers
{
    public class UserController : ApiController
    {
        BLL.UserService service = new BLL.UserService();
        public List<DTO.UserDTO> Get()
        {
            return service.Get();
        }


        public DTO.UserDTO Get(string name, int passwod)
        {
            return service.Get(name,passwod);
        }
    }
}

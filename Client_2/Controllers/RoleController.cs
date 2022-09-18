using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Client_2.Controllers
{
    public class RoleController : ApiController
    {
        BLL.RoleService service = new BLL.RoleService();

      //ייבוא של כל התפקידים
        public List<DTO.RoleDTO> GetAllRole()
        {
            return service.GetAllRole();
        } 

        //הוספת תפקיד
        [HttpPost]
        public DTO.RoleDTO AddRole(DTO.RoleDTO role)
        {
            return service.AddRole(role);
        }
    }
}

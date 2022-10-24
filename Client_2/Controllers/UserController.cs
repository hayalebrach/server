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
        [HttpGet]
        //כל המשתמשים
        public List<DTO.UserDTO> GetAllUsers()
        {
            return service.GetAllUsers();
        }

        [HttpGet]
        //מחזירה רק את המנהלים
        public List<DTO.UserDTO> GetAllManagers()
        {
            return service.GetAllManagers();
        }


        [HttpGet]
        //פונקצית GET שמקבלת לפי שם וסיסמא
        public DTO.UserDTO GetByIdAndPassword(string name, int password)
        {
            return service.GetByIdAndPassword(name, password);

        }

        public DTO.UserDTO GetById(int UserId)
        {
            return service.GetById(UserId);

        }

        [HttpPost]
        public DTO.UserDTO AddUser(DTO.UserDTO User)
        {
            return service.AddUser(User);
        }

        [HttpPut]
        public DTO.UserDTO Put(DTO.UserDTO User)
        {
            return service.Put(User);
        }

        

    }
    }


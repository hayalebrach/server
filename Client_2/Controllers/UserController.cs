﻿using System;
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
        //פונקצית GET שמקבלת לפי שם וסיסמא
        public DTO.UserDTO GetByIdAndPassword(string name, string password)
        {
            return service.GetByIdAndPassword(name, password);

        }
        [Route("~/api/User/GetAllGuide")]
        public List<DTO.UserDTO> GetAllGuide()
        {
            return service.GetAllGuide();
        }
        [Route("~/api/User/GetAllUsers")]
        public List<DTO.UserDTO> GetAllUsers()
        {
            return service.GetAllUsers();
        }
        public List<DTO.UserDTO> GetAllManagers()
        {
            return service.GetAllManagers();
        }
        [HttpPost]
        public DTO.UserDTO AddUser(DTO.UserDTO User)
        {
            return service.AddUser(User);
        }

        [HttpPut]
        //עדכון
        public DTO.UserDTO Put(DTO.UserDTO User)
        {
            return service.Put(User);
        }

    }
    }


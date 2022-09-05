﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UserService
    {
        DAL.Model.UserModel model = new DAL.Model.UserModel();
        public List<DTO.UserDTO> GetAllUsers()
        {
            return convert.UserConvert.Convert(model.GetAllUsers());
        }
        //פונקצית GET שמקבלת לפי שם וסיסמא
        public DTO.UserDTO GetByIdAndPassword(string name,int password)
        {
            return convert.UserConvert.Convert(model.GetByIdAndPassword(name,password));
        }
        //הוספת משתמש
        public DTO.UserDTO AddUser(DTO.UserDTO User)
        {
            return convert.UserConvert.Convert(model.AddUser(convert.UserConvert.Convert(User)));
        }
    }
}

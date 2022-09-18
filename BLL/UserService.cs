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

        public List<DTO.UserDTO> GetAllUsers()//כל המשתמשים
        {
            return convert.UserConvert.Convert(model.GetAllUsers());
        }
    
        public DTO.UserDTO GetByIdAndPassword(string name,int password) //פונקצית GET שמקבלת לפי שם וסיסמא
        {
            return convert.UserConvert.Convert(model.GetByIdAndPassword(name,password));
        }
 
        public DTO.UserDTO AddUser(DTO.UserDTO User) //הוספת משתמש
        {
            return convert.UserConvert.Convert(model.AddUser(convert.UserConvert.Convert(User)));
        }
        public DTO.UserDTO Put(DTO.UserDTO User)
        {
            return convert.UserConvert.Convert(model.Put(convert.UserConvert.Convert(User)));

        }
    }
}

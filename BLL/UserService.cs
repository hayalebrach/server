using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UserService
    {
        DAL.Model.UserModel model = new DAL.Model.UserModel();
        //אין לו פונקצית המשך במודל 

        /*public List<DTO.UserDTO> GetAllUsers()//כל המשתמשים
        {
            return convert.UserConvert.Convert(model.GetAllUsers());
        }*/
        
        public List<DTO.UserDTO> GetAllManagers()
        {
            return convert.UserConvert.Convert(model.GetAllManagers());
        }
        public List<DTO.UserDTO> GetAllGuide()
        {
            return convert.UserConvert.Convert(model.GetAllGuide());
        }

        //אין לו פונקצית המשך במודל 
        //public DTO.UserDTO GetById(int UserId)
        //{
        //    return convert.UserConvert.Convert(model.GetById(UserId));
        //}



        /*public DTO.UserDTO GetById(int UserId)
        {
            return convert.UserConvert.Convert(model.GetById(UserId));

        }*/

        //פונקצית GET שמקבלת לפי שם וסיסמא

        //פונקצית GET שמקבלת לפי שם וסיסמא

        public DTO.UserDTO GetByIdAndPassword(string name,string password) 
        {
            return convert.UserConvert.Convert(model.GetByIdAndPassword(name,password));
        }
        //הוספת משתמש
        public DTO.UserDTO AddUser(DTO.UserDTO User)

        {
            return convert.UserConvert.Convert(model.AddUser(convert.UserConvert.Convert(User)));
        }

        //עדכון משתמש
        public DTO.UserDTO Put(DTO.UserDTO User)
        {
            return convert.UserConvert.Convert(model.Put(convert.UserConvert.Convert(User)));

        }
    }
}

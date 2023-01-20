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
        //פונקצית GET לפי מייל
        public DTO.UserDTO getUserByMail(string mail)
        {
            return convert.UserConvert.Convert(model.getUserByMail(mail));
        }
       
        //פונקתיה ששולחת מייל
        public DTO.UserDTO SendMail(string body, string mail,string subject)
        {
            return convert.UserConvert.Convert(model.SendMail(body, mail,subject));
        }
        //פונקצית GET שמקבלת לפי שם וסיסמא
        public DTO.UserDTO GetByIdAndPassword(string name, string password)
        {
            return convert.UserConvert.Convert(model.GetByIdAndPassword(name, password));
        }
        //פונקציה שלוקחת את כל המדריכים לקורסים שבאותה בריכה
        public List<DTO.UserDTO> GetAllGuide()
        {
            return convert.UserConvert.Convert(model.GetAllGuide());
        }
        //פונקציה שלוקחת את כל המשתמשים
        public List<DTO.UserDTO> GetAllUsers()
        {
            return convert.UserConvert.Convert(model.GetAllUsers());
        }
        //פונקציה שלוקחת את כל מנהלי הבריכות
        public List<DTO.UserDTO> GetAllManagers()
        {
            return convert.UserConvert.Convert(model.GetAllManagers());
        }
        //פונקציה שמוסיפה משתמש/מנהל בריכה/מנהל אתר
        public DTO.UserDTO AddUser(DTO.UserDTO User)
        {
            return convert.UserConvert.Convert(model.AddUser(convert.UserConvert.Convert(User)));
        }
        //פונקצית עדכון סיסמא
        public DTO.UserDTO PutPassWord(string PassWord, int Id)
        {
            return convert.UserConvert.Convert(model.PutPassWord(PassWord, Id));
        }
        //פונקציה שמעדכנת כניסה אחרונה
        public DTO.UserDTO LastEnteryDate(DTO.UserDTO User)
        {
            return convert.UserConvert.Convert(model.LastEnteryDate(convert.UserConvert.Convert(User)));
        }

        //עדכון משתמש
        
        //public DTO.UserDTO Put(DTO.UserDTO User)
        //{
        //    return convert.UserConvert.Convert(model.Put(convert.UserConvert.Convert(User)));

        //}
    }
}

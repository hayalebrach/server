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

        //פונקצית GET לפי מייל
        [HttpGet]
        public DTO.UserDTO getUserByMail(string mail)
        {
            return service.getUserByMail(mail);

        }
        //פונקתיה ששולחת מייל
        [HttpGet]
        [Route("~/api/User/SendMail")]
        public DTO.UserDTO SendMail(string mail,string body,string subject)
        {
            return service.SendMail(body, mail,subject);
        }

        //פונקצית GET שמקבלת לפי שם וסיסמא
        public DTO.UserDTO GetByIdAndPassword(string name, string password)
        {
            return service.GetByIdAndPassword(name, password);

        }
        //פונקציה שלוקחת את כל המדריכים לקורסים שבאותה בריכה
        [Route("~/api/User/GetAllGuide")]
        public List<DTO.UserDTO> GetAllGuide()
        {
            return service.GetAllGuide();
        }
        //פונקציה שלוקחת את כל המשתמשים
        [Route("~/api/User/GetAllUsers")]
        public List<DTO.UserDTO> GetAllUsers()
        {
            return service.GetAllUsers();
        }
        //פונקציה שלוקחת את כל מנהלי הבריכות
        public List<DTO.UserDTO> GetAllManagers()
        {
            return service.GetAllManagers();
        }
        //פונקציה שמוסיפה משתמש/מנהל בריכה/מנהל אתר
        [HttpPost]
        [Route("~/api/User/AddUser")]
        public DTO.UserDTO AddUser(DTO.UserDTO User)
        {
            return service.AddUser(User);
        }

        [HttpPut]
        //פונקצית עדכון סיסמא
        public DTO.UserDTO PutPassWord(string PassWord,int Id)
        {
            return service.PutPassWord(PassWord,Id);
        }

        //פונקציה שמעדכנת כניסה אחרונה
        [HttpPut]
        [Route("~/api/User/LastEnteryDate")]
        public DTO.UserDTO LastEnteryDate(DTO.UserDTO User)
        {
            return service.LastEnteryDate(User);
        }

        ////עדכון
        //public DTO.UserDTO Put(DTO.UserDTO User)
        //{
        //    return service.Put(User);
        //}

    }
}


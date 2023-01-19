using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Client_2.Controllers
{
    public class CoursToCustomerController : ApiController
    {
        BLL.CoursToCustomerService service = new BLL.CoursToCustomerService();
        //הרשמת משתמש

        public DTO.CoursToCustomerDTO Course_Enrollment(DTO.CoursToCustomerDTO user)
        {
            return service.Course_Enrollment(user);
        }
        //לוקחת כל הקורסים למשתמש

        [HttpGet]
        [Route("~/api/CourseToCustumer/GetCoursesByUser")]
        public List<DTO.CoursToCustomerDTO> GetCoursesByUser(int IdUser)
        {
            return service.GetCoursesByUser(IdUser);
        }

    }
}

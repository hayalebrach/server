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

        public DTO.CoursToCustomerDTO Course_Enrollment(DTO.CoursToCustomerDTO user)
        {
            return service.Course_Enrollment(user);


        }
<<<<<<< Updated upstream

        public List<DTO.CoursToCustomerDTO> GetCoursesByUser(int IdUser)
        {
            return service.GetCoursesByUser(IdUser);
        }
=======
>>>>>>> Stashed changes
    }
}

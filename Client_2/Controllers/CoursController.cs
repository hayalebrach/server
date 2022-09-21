using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Client_2.Controllers
{


   
    public class CoursController : ApiController
    {
        BLL.CoursService service = new BLL.CoursService();


         [HttpGet]
        public List<DTO.CoursDTO> getAllCourses()
        {
            return service.Get();
        }

        public List<DTO.CoursDTO> GetCoursesByPool(int IdPool)
        {
            return service.GetCoursesByPool(IdPool);
        }

        public DTO.CoursDTO AddCourse(DTO.CoursDTO Course)
        {
            return service.AddCourse(Course);

            
        }

        public DTO.CoursDTO DeleteCourse(int Id)
        {
            return service.DeleteCourse(Id);
        }
    }
}

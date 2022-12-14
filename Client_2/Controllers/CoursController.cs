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
        //מחיקה
        [HttpPut]
        public DTO.CoursDTO PutForDelete(DTO.CoursDTO Cours)
        {
            return service.PutForDelete(Cours);
        }
        //עדכון
        [HttpPut]
        //[Route("~/api/Packege/GetCardsByIdPool")]
        public DTO.CoursDTO Put(DTO.CoursDTO Cours)
        {
            return service.Put(Cours);
        }


        //הוספת קורס להעביר לקורס טו קסטומר
        /*public DTO.CoursDTO Course_Enrollment(DTO.CoursDTO User)
        {
            return service.CourseEnrollment(User);


        }*/



    }
}

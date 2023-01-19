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
        //פונקציה שלוקחת את כל הקורסים
         [HttpGet]
        public List<DTO.CoursDTO> getAllCourses()
        {
            return service.Get();
        }
        //לוקחת את כל הקורסים לבריכה
        public List<DTO.CoursDTO> GetCoursesByPool(int IdPool)
        {
            return service.GetCoursesByPool(IdPool);
        }
        //מוסיפה קורס
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
        [Route("~/api/Cours/Put")]
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

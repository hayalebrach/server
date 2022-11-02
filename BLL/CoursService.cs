using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CoursService
    {
        DAL.Model.CoursModel model = new DAL.Model.CoursModel(); 
        public List<DTO.CoursDTO> Get()
        {
            return convert.CoursConvert.Convert(model.Get()); 
        }

        public List<DTO.CoursDTO> GetCoursesByPool(int IdPool)
        {
            return convert.CoursConvert.Convert(model.GetCoursesByPool(IdPool));
        }



        public DTO.CoursDTO AddCourse(DTO.CoursDTO Course)
        {
            return convert.CoursConvert.Convert(model.AddCourse(convert.CoursConvert.Convert(Course)));
        }

        public DTO.CoursDTO DeleteCourse(int Id)
        {
            return convert.CoursConvert.Convert(model.DeleteCourse(Id));
        }


        //עדכון קורס
        public DTO.CoursDTO UpdateCourse(DTO.CoursDTO course)
        {
            return convert.CoursConvert.Convert(model.UpdateCourse(convert.CoursConvert.Convert(course)));

        }

        


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CoursToCustomerService
    {
        DAL.Model.CoursToCustomerModel model = new DAL.Model.CoursToCustomerModel();
        //הרשמת משתמש

        public DTO.CoursToCustomerDTO Course_Enrollment(DTO.CoursToCustomerDTO user)
        {
            return convert.CoursToCustomerConvert.Convert(model.Course_Enrollment(convert.CoursToCustomerConvert.Convert(user)));
        }

        //לוקחת כל הקורסים למשתמש

        public List<DTO.CoursToCustomerDTO> GetCoursesByUser(int IdUser)
        {
            return convert.CoursToCustomerConvert.Convert(model.GetCoursesByUser(IdUser));
        }

        public List<DTO.CoursToCustomerDTO> Get()
        {
            return convert.CoursToCustomerConvert.Convert(model.Get());
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class RoleService
    {
        DAL.Model.RoleModel model = new DAL.Model.RoleModel();
        //פונקציות
        public List<DTO.RoleDTO> GetAllRole()
        {
            return convert.RoleConvert.Convert(model.GetAllRole());
        }

        //הוספת תפקיד
        public DTO.RoleDTO AddRole(DTO.RoleDTO role)
        {
            return convert.RoleConvert.Convert(model.AddRole(convert.RoleConvert.Convert(role)));

        }
    }
}

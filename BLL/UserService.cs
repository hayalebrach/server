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
        public List<DTO.UserDTO> Get()
        {
            return convert.UserConvert.Convert(model.Get());
        }
    }
}

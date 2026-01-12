using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Core.RequestModels.Users;

namespace TaskManagement.Core.ResponseModels.SingleResponses
{
    public class UserSingleResponses : CoreResponse
    {
        public UserSingleResponses() 
        { 
            data = new UserDtoModel();
        }
        public UserDtoModel data { get; set; }
    }
}

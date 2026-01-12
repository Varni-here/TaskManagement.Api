using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Core.RequestModels.Users;

namespace TaskManagement.Core.ResponseModels.ListResponses
{
    public class UserListResponse : CoreResponse
    {
        public UserListResponse() 
        {
            data = new List<UserDtoModel>();
        }
        public List<UserDtoModel> data { get; set; }
    }
}
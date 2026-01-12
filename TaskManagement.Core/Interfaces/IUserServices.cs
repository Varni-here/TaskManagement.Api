using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Core.RequestModels.Users;
using TaskManagement.Core.ResponseModels;

namespace TaskManagement.Core.Interfaces
{
    public interface IUserServices
    {
        Task<CoreResponse> RegisterUser(UserDtoModel req);
    }
}

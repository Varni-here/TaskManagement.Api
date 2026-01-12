using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Core.RequestModels.Users;
using TaskManagement.Core.ResponseModels;
using TaskManagement.Data.Models;

namespace TaskManagement.Services
{
    public class UsersServices
    {
        private readonly AppDbContext _context;

        public UsersServices(AppDbContext context)
        {
            _context = context;
        }

        public async Task<CoreResponse> RegisterUser(UserDtoModel req)
        {
            CoreResponse res = new CoreResponse();
            var user = _context.Users.Where(u => u.Email == req.Email && u.IsActive == true).FirstOrDefault();
            if (_context.Users.Any(u => u.UserName == req.UserName && u.IsActive == true))
            {
                res.status = false;
                res.statusMessage = $"Username {req.UserName} is already used by another user please try diffrent names!";
                return res;
            }
            if (user == null)
            {
                res.status = false;
                res.statusMessage = $"No User Exist for save info of the user please Sign up first!";
                return res;
            }
            user.FirstName = !string.IsNullOrWhiteSpace(req.FirstName) ? req.FirstName : throw new Exception("First Name is required!");
            user.MiddleName = req.MiddleName;
            user.LastName = !string.IsNullOrWhiteSpace(req.LastName) ? req.LastName : throw new Exception("Last Name is required!");
            user.ContactNo = req.ContactNo;
            user.CreatedDate = DateTime.Now;
            user.UpdatedDate = DateTime.Now;
            user.IsActive = true;
            await _context.SaveChangesAsync();
            res.status = true;
            res.statusMessage = "User Information Saved!";
            return res;
        }

        public async Task<CoreResponse> SendVerificationEmail(EmailVerificationModel req)
        {
            CoreResponse res = new CoreResponse();
            
        }
    }
}

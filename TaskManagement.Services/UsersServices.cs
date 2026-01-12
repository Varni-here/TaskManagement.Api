using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Core.Interfaces;
using TaskManagement.Core.RequestModels.Users;
using TaskManagement.Core.ResponseModels;
using TaskManagement.Data.Models;

namespace TaskManagement.Services
{
    public class UsersServices : IUserServices
    {
        private readonly AppDbContext _context;
        private readonly IEmailService _emailService;

        public UsersServices(AppDbContext context,IEmailService emailService)
        {
            _context = context;
            _emailService = emailService;
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
            await _emailService.SendEmailAsync(req.Email, "OTP Code", "<h3>Your OTP is 123456</h3>");
            res.status = true;
            res.statusMessage = "Email sent successfully";
            return res;
        }
    }
}

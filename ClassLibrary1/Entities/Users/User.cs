using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CMCS.Domain.Entities.Users.Enums;

namespace CMCS.Domain.Entities.Users
{
    public class User
    {
        public int UserId { get; set; } // Unique identifier for the user
        public string Name { get; set; } // Full name of the lecturer
        public string Email { get; set; } // Email address (optional)
        public string Password { get; set; } // Hashed password for authentication
        public UserRole Role { get; set; } // Role of the user in the system
        public List<string> Modules { get; set; } // List of modules the lecturer teaches
    }
}

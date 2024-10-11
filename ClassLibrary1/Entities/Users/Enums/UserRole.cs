using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMCS.Domain.Entities.Users.Enums
{
    public enum UserRole
    {
        Lecturer,         // Represents a lecturer
        Administrator,    // Represents an admin user who manages the system
        ProgramCoordinator,   // Represents the program coordinator who reviews claims
        AcademicManager       // Represents the academic manager who oversees the claim process
    }
}

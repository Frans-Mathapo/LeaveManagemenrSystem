using Microsoft.AspNetCore.Identity;

namespace LeaveManagemenrSystem.Data
{
    public class Employee : IdentityUser
    {
        public string firstName { get; set; }
        public string lastname { get; set; }
        public string taxID { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateJoint { get; set; }

    }
}

using Microsoft.Extensions.Diagnostics.HealthChecks;
using System.Diagnostics;

namespace MyBoards.Entities
{
    public class User
    {
        public  string FirstName { get; set; }
        public string LastName { get; set; }

        public string Email { get; set; }   
    }
}

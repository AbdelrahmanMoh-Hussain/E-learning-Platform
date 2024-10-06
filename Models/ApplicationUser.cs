using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace E_learning_Platform.Models
{
    public class ApplicationUser : IdentityUser<int>
    {
        [StringLength(maximumLength: 50, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 100 characters")]
        public string FirstName { get; set; }

        [StringLength(maximumLength: 50, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 100 characters")]
        public string LastName { get; set; }
        public IEnumerable<Course> Courses { get; set; }
    }
}

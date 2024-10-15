using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_learning_Platform.Models
{
    public class Enrollement
    {
        public int UserId {  get; set; }
        public int CourseId {  get; set; }

        [Required]
        [Range(0,100)]
        public int Progress {  get; set; }

        [Range(0, 5, ErrorMessage = "Course rate must be between 0 and 5")]
        [DisplayName("Course rate")]
        public decimal CourseRate { get; set; }
        public Course Course { get; set; }
        public ApplicationUser User { get; set; }
    }
}

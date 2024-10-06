using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_learning_Platform.Models
{
    public class Enrollement
    {
        public int UserId {  get; set; }
        [ForeignKey("CourseId")]
        public int CourseId {  get; set; }
        [Required]
        [Range(0,100)]
        public int Progress {  get; set; }

        public Course Course { get; set; }
    }
}

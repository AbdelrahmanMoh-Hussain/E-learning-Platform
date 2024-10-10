using System.ComponentModel.DataAnnotations.Schema;

namespace E_learning_Platform.Models
{
	public class StudentCourseCart
	{
		[ForeignKey("Users")]
        public int UserId { get; set; }
		public int CourseId { get; set; }
    }
}

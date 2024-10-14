namespace E_learning_Platform.Models
{
    public class UserCoursesCart
    {
        public int UserId { get; set; }
        public int CourseId { get; set; }
        public ApplicationUser User { get; set; } = null!;
        public Course Course { get; set; } = null!;
    }
}

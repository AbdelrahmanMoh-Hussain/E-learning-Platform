namespace E_learning_Platform.Models.ViewModels
{
    public class UserRoleWithEnrolledCoursesViewModel
    {
        public ApplicationUser User { get; set; }
        public string Role { get; set; }
        public int EnrolledCoursesCount { get; set; }
    }
}

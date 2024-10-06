using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace E_learning_Platform.Models
{
    public class Course
    {
        [Required]
        int Id { get; set; }

        [Required(ErrorMessage ="Course Name is required")]
        [StringLength(maximumLength:100, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 100 characters")]
        public string Name { get; set; }

        [Required]
        [StringLength(maximumLength: 500, ErrorMessage = "Description can't be longer than 500 characters")]
        public string Description { get; set; }

        [Required]
        [Range(0,5,ErrorMessage ="Course rate must be between 0 and 5")]
        public decimal CourseRate {  get; set; }

        [Required(ErrorMessage = "Image URL is required")]
        [Url(ErrorMessage ="Invalid URL format")]
        public string ImageUrl {  get; set; }

        [Required(ErrorMessage = "Field of study is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Field of study must be between 3 and 50 characters")]
        public string FieldOfStudy { get; set; }

        [Required(ErrorMessage = "Instructor name is required")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Instructor name must be between 3 and 100 characters")]
        public string InstructorName {  get; set; }

        [Required(ErrorMessage = "Price is required")]
        [Range(20, 10000, ErrorMessage = "Price must be between 20 and 10,000")]
        public decimal Price {  get; set; }




    }
}

using System.ComponentModel.DataAnnotations;

namespace WebApiDemo.Models
{
    public class Course
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public string Description { get; set; }
    }
}

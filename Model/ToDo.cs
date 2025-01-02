using System.ComponentModel.DataAnnotations;

namespace TodoListApi.Model
{
    public class Todo
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Title is required")]
        [StringLength(int.MaxValue)]
        public required string Title { get; set; }
        [RegularExpression("^(pending|completed)$", ErrorMessage = "Status must be 'pending' or 'completed'.")]
        public string Status { get; set; } = "pending";
        [DataType(DataType.Date, ErrorMessage = "Please enter a valid date.")]
        public DateTime DueDate { get; set; } = DateTime.Now;
    }
}

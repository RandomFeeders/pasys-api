namespace Pasys.Models
{
    public class TaskModel
    {
        public int Id { get; set; }
        public string? Name { get; set; } //pode ser null
        public string? Description { get; set; } //pode ser null
        public int Status { get; set; }
    }
}

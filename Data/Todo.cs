namespace TodoProject.Data;

public class Todo
{
    public int Id { get; set; }
    public DateTime DateCreated { get; set; } = DateTime.Now;
    public string? Item { get; set; }
    public DateTime DeadLine { get; set; }
    public bool IsDone { get; set; }
}
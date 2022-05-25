namespace TodoProject.Data;

public interface ITodoService
{
    Task AddItem(Todo todo);
    Task<List<Todo>> RetrieveAllItems();
    Task DeleteItem(int id);
}
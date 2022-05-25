using Microsoft.EntityFrameworkCore;

namespace TodoProject.Data;

public class TodoService : ITodoService
{
    private readonly TodoContext? _context;

    public TodoService(TodoContext context)
    {
        _context = context;
    }

    public async Task AddItem(Todo todo)
    {
        _context?.todo?.Add(todo);
        await _context.SaveChangesAsync();
    }

    public async Task<List<Todo>> RetrieveAllItems()
    {
        var items = await _context.todo.ToListAsync();
        return items;
    }

    public async Task DeleteItem(int id)
    {
        var item = _context?.todo?.Where(c => c.Id == id);

        if (item is not null)
        {
            _context?.todo?.Remove((Todo)item);
            await _context.SaveChangesAsync();
        }
    }
}
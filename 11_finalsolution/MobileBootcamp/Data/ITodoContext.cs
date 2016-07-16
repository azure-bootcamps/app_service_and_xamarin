using System.Collections.Generic;

namespace MobileBootcamp.Data
{
    public interface ITodoContext
    {
        IEnumerable<TodoItem> GetItems();

        void AddItem(TodoItem item);
    }
}

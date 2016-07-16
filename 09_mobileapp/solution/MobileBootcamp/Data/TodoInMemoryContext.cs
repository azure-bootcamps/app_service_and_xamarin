using System;
using System.Collections.Generic;

namespace MobileBootcamp.Data
{
    public class TodoInMemoryContext : ITodoContext
    {
        private List<TodoItem> todoItems = new List<TodoItem>
        {
            new TodoItem { Id = "0001", Text = "Original Task" },
            new TodoItem { Id = "0002", Text = "Follow-up Request" },
            new TodoItem { Id = "0003", Text = "Eventual Mistake" },
            new TodoItem { Id = "0004", Text = "Final Item" }
        };

        public void AddItem(TodoItem item)
        {
            item.Id = Guid.NewGuid().ToString();
            todoItems.Add(item);
        }

        public IEnumerable<TodoItem> GetItems()
        {
            return todoItems;
        }
    }
}

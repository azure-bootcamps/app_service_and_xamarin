using MobileBootcamp.Data;
using System.Collections.Generic;
using Xamarin.Forms;

namespace MobileBootcamp
{
    public class HomePage : ContentPage
    {

        public HomePage()
        {
            BuildContent();
        }

        private void BuildContent()
        {
            List<TodoItem> todoItems = new List<TodoItem>
            {
              new TodoItem { Id = "0001", Text = "Original Task" },
              new TodoItem { Id = "0002", Text = "Follow-up Request" },
              new TodoItem { Id = "0003", Text = "Eventual Mistake" }
            };

            DataTemplate todoTemplate = new DataTemplate(typeof(TextCell));
            todoTemplate.SetBinding(TextCell.TextProperty, "Text");
            todoTemplate.SetBinding(TextCell.DetailProperty, "Id");

            this.Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.Center,
                Children =
                {
                    new Label
                    {
                        HorizontalTextAlignment = TextAlignment.Center,
                        Text = "Todo List Manager"
                    },
                    new ListView
                    {
                        ItemsSource = todoItems,
                        ItemTemplate = todoTemplate
                    }
                }
            };
        }
    }
}

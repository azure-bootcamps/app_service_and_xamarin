using MobileBootcamp.Data;
using System.Collections.Generic;
using Xamarin.Forms;

namespace MobileBootcamp
{
    public class HomePage : ContentPage
    {
        private ITodoContext _context = new TodoInMemoryContext();

        public HomePage()
        {
            BuildContent();
        }

        private void BuildContent()
        {
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
                        ItemsSource = this._context.GetItems(),
                        ItemTemplate = todoTemplate
                    }
                }
            };
        }
    }
}

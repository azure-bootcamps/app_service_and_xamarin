using MobileBootcamp.Data;
using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace MobileBootcamp
{
    public class HomePage : ContentPage
    {
        private ITodoContext _context = new TodoInMemoryContext();
        private ObservableCollection<TodoItem> _todoItemsCollection;

        public HomePage()
        {
            BuildContent();
        }

        Entry textBox = new Entry();
        Button textButton = new Button { Text = "+" };

        private void BuildContent()
        {
            DataTemplate todoTemplate = new DataTemplate(typeof(TextCell));
            todoTemplate.SetBinding(TextCell.TextProperty, "Text");
            todoTemplate.SetBinding(TextCell.DetailProperty, "Id");

            textButton.Clicked += OnClick;

            _todoItemsCollection = new ObservableCollection<TodoItem>(this._context.GetItems());

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
                    textBox,
                    textButton,
                    new ListView
                    {
                        ItemsSource = _todoItemsCollection,
                        ItemTemplate = todoTemplate
                    }
                }
            };
        }

        private void OnClick(object sender, EventArgs e)
        {
            var newItem = new TodoItem
            {
                Text = textBox.Text
            };

            textBox.Text = String.Empty;

            this._context.AddItem(newItem);
            _todoItemsCollection.Add(newItem);

            DisplayAlert("New Item", "Your todo item has been added successfully", "OK");
        }
    }
}

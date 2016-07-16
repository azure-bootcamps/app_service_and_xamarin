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

        public Label titleLabel = new Label();
        public ListView listView = new ListView();
        public Entry textBox = new Entry();
        public Button textButton = new Button();

        public HomePage()
        {
            BuildContent();
        }

        private void BuildContent()
        {
            DataTemplate todoTemplate = new DataTemplate(typeof(TextCell));
            todoTemplate.SetBinding(TextCell.TextProperty, "Text");
            todoTemplate.SetBinding(TextCell.DetailProperty, "Id");

            textButton.Text = "+";
            textButton.Clicked += OnClick;

            _todoItemsCollection = new ObservableCollection<TodoItem>(this._context.GetItems());

            listView.ItemsSource = _todoItemsCollection;
            listView.ItemTemplate = todoTemplate;
            listView.ItemSelected += OnSelection;

            titleLabel.HorizontalTextAlignment = TextAlignment.Center;
            titleLabel.Text = "Todo List Manager";

            this.Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.Center,
                Children =
                {
                    titleLabel,
                    textBox,
                    textButton,
                    listView
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

        private async void OnSelection(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null && e.SelectedItem is TodoItem)
            {
                await Navigation.PushAsync(new DetailsPage(e.SelectedItem as TodoItem));
            }
        }
    }
}

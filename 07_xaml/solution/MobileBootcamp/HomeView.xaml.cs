using MobileBootcamp.Data;
using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace MobileBootcamp
{
    public partial class HomeView : ContentPage
    {
        private ITodoContext _context = new TodoInMemoryContext();
        private ObservableCollection<TodoItem> _todoItemsCollection;

        public HomeView()
        {
            InitializeComponent();

            LoadListData();
        }

        private void LoadListData()
        {
            _todoItemsCollection = new ObservableCollection<TodoItem>(this._context.GetItems());
            this.ListData.ItemsSource = _todoItemsCollection;
        }

        private void OnClick(object sender, EventArgs e)
        {
            var newItem = new TodoItem
            {
                Text = this.TextData.Text
            };

            this.TextData.Text = String.Empty;

            this._context.AddItem(newItem);
            _todoItemsCollection.Add(newItem);

            DisplayAlert("New Item", "Your todo item has been added successfully", "OK");
        }

        private async void OnSelection(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new DetailsView { BindingContext = e.SelectedItem });
            }
        }
    }
}

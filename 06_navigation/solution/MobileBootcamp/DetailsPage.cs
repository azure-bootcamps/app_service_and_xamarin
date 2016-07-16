using MobileBootcamp.Data;
using Xamarin.Forms;

namespace MobileBootcamp
{
    public class DetailsPage : ContentPage
    {
        public DetailsPage(TodoItem item)
        {
            BuildContent(item);
        }

        private void BuildContent(TodoItem item)
        {
            this.BindingContext = item;

            this.Content = new StackLayout
            {
                Children =
                {
                    new Label { Text = item.Id, FontSize = 30, FontAttributes = FontAttributes.Bold },
                    new Label { Text = item.Text }
                }
            };
        }
    }
}

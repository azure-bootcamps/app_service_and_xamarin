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
            this.Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.Center,
                Children = {
                        new Label {
                            HorizontalTextAlignment = TextAlignment.Center,
                            Text = "Todo List Manager"
                        }
                    }
            };
        }
    }
}

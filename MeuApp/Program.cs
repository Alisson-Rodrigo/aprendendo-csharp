using Xamarin.Forms;

namespace MeuApp
{
    public class MainPage : ContentPage
    {
        public MainPage()
        {
            var nameLabel = new Label
            {
                Text = "Digite seu nome:",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            var nameEntry = new Entry
            {
                Placeholder = "Nome",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            var submitButton = new Button
            {
                Text = "Enviar",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            submitButton.Clicked += (sender, e) =>
            {
                string nome = nameEntry.Text;
                DisplayAlert("Saudação", $"Olá, {nome}!", "OK");
            };

            Content = new StackLayout
            {
                Children = { nameLabel, nameEntry, submitButton },
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
        }
    }
}

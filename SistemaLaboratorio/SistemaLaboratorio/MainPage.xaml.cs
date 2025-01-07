using Windows.UI.Xaml.Controls;

namespace SistemaLaboratorio
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            NavView.ItemInvoked += NavView_ItemInvoked;
        }

        private void NavView_ItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
        {
            if (args.IsSettingsInvoked)
                return;

            var tag = args.InvokedItemContainer.Tag.ToString();

            switch (tag)
            {
                case "home":
                    // Navegar a la página de inicio
                    // ContentFrame.Navigate(typeof(HomePage));
                    break;
                case "results":
                    // Navegar a la página de resultados
                    // ContentFrame.Navigate(typeof(ResultsPage));
                    break;
            }
        }
    }
}
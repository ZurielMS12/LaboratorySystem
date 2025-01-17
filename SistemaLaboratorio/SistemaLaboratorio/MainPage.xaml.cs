using SistemaLaboratorio.OS;
using SistemaLaboratorio.UC;
using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Animation;

namespace SistemaLaboratorio
{
    public sealed partial class MainPage : Page
    {
        #region Properties
        Frame contentFrame;
        Frame ContentFrame => contentFrame ?? (contentFrame = new Frame() { CacheSize = 0 });
        #endregion

        #region Attributes
        MenuUC menuUC = null;
        #endregion

        #region Builder
        public MainPage()
        {
            this.InitializeComponent();
            InitializeValues();

            ContentFrame.Navigated += (s, e) =>
            {
                NavigationService.RootFrame = ContentFrame;
            };

            Loaded += (s, e) =>
            {
                ContentFrame.Navigate(typeof(ResultsPage));
            };
        }
        #endregion

        #region Methods
        public void InitializeValues()
        {
            containerMain.Children.Add(ContentFrame);
            Grid.SetColumnSpan(ContentFrame, 2);
            Grid.SetRowSpan(ContentFrame, 3);

            menuGrid.Children.Clear();
            menuUC = new MenuUC();
            menuGrid.Children.Add(menuUC);
        }
        #endregion
    }
}
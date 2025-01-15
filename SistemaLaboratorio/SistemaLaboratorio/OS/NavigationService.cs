using SistemaLaboratorio.Core.OS;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace SistemaLaboratorio.OS
{
    public partial class NavigationService : INavigationService
    {
        List<ContentDialog> dialog;
        List<ContentDialog> Dialog => dialog ?? (dialog = new List<ContentDialog>());

        [ThreadStatic]
        internal static Frame RootFrame;

        public void CloseWindow(object window)
        {
            throw new NotImplementedException();
        }

        public string GetCurrenPage()
        {
            throw new NotImplementedException();
        }

        public Task GoBack()
        {
            throw new NotImplementedException();
        }

        public Task Home()
        {
            throw new NotImplementedException();
        }

        public void NavigatePop()
        {
            throw new NotImplementedException();
        }

        public Task NavigateTo(string pageKey)
        {
            throw new NotImplementedException();
        }

        public Task NavigateTo(string pageKey, params object[] parameter)
        {
            throw new NotImplementedException();
        }

        public void NavigateToUrl(string url)
        {
            throw new NotImplementedException();
        }

        public Task PopModal()
        {
            throw new NotImplementedException();
        }

        public Task PushModal(string pageKey)
        {
            throw new NotImplementedException();
        }

        public Task PushModal(string pageKey, params object[] parameter)
        {
            throw new NotImplementedException();
        }

        public Task ShowAsStandaloneView(string pageKey, params object[] parameter)
        {
            throw new NotImplementedException();
        }

        public Task<object> ShowDialog(string dialogKey)
        {
            throw new NotImplementedException();
        }

        public Task ShowMessage(string message)
        {
            throw new NotImplementedException();
        }
    }
}

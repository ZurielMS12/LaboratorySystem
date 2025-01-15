using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace SistemaLaboratorio.UC
{
    public sealed partial class MenuOption : UserControl
    {
        #region Builder
        public MenuOption()
        {
            this.InitializeComponent();
        }
        #endregion

        #region Properties
        public string Title
        {
            get => (string)GetValue(TitleProperty); 
            set => SetValue(TitleProperty, value); 
        }

        public static readonly DependencyProperty TitleProperty = DependencyProperty.Register(nameof(Title), typeof(string), typeof(MenuOption),
            new PropertyMetadata(default(string), (bindable, e) =>
            {
                var me = (MenuOption)bindable;
                me.Title = e.NewValue.ToString();
                me.label.Text = me.Title ?? string.Empty;
            }));


        public SymbolIcon IconOption
        {
            get => (SymbolIcon)GetValue(IconOptionProperty);
            set => SetValue(IconOptionProperty, value); 
        }

        public static readonly DependencyProperty IconOptionProperty = DependencyProperty.Register(nameof(IconOption), typeof(SymbolIcon), typeof(MenuOption),
            new PropertyMetadata(default(SymbolIcon), (bindable, e) =>
            {
                var me = (MenuOption)bindable;
                me.IconOption = (SymbolIcon)e.NewValue;
                me.icon = me.IconOption;
            }));
        #endregion
    }
}

using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Animation;

namespace SistemaLaboratorio
{
    public sealed partial class HomePage : Page
    {
        public HomePage()
        {
            this.InitializeComponent();
            StartAnimation();
        }

        private void StartAnimation()
        {
            var liquidAnimation = new DoubleAnimation
            {
                From = 0,
                To = -50,
                Duration = new Duration(TimeSpan.FromSeconds(2)),
                AutoReverse = true,
                RepeatBehavior = RepeatBehavior.Forever
            };

            var bubble1Animation = new DoubleAnimation
            {
                From = 0,
                To = -100,
                Duration = new Duration(TimeSpan.FromSeconds(1.5)),
                AutoReverse = true,
                RepeatBehavior = RepeatBehavior.Forever
            };

            var bubble2Animation = new DoubleAnimation
            {
                From = 0,
                To = -80,
                Duration = new Duration(TimeSpan.FromSeconds(2)),
                AutoReverse = true,
                RepeatBehavior = RepeatBehavior.Forever
            };

            Storyboard.SetTarget(liquidAnimation, LiquidTransform);
            Storyboard.SetTargetProperty(liquidAnimation, "Y");

            Storyboard.SetTarget(bubble1Animation, Bubble1Transform);
            Storyboard.SetTargetProperty(bubble1Animation, "Y");

            Storyboard.SetTarget(bubble2Animation, Bubble2Transform);
            Storyboard.SetTargetProperty(bubble2Animation, "Y");

            var storyboard = new Storyboard();
            storyboard.Children.Add(liquidAnimation);
            storyboard.Children.Add(bubble1Animation);
            storyboard.Children.Add(bubble2Animation);

            storyboard.Begin();
        }
    }
}
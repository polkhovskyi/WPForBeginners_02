using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=391641

namespace WPForBeginners_02
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required;
            this.Loaded += MainPage_Loaded;
        }

        void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            Button dynamicButton = new Button();
            dynamicButton.Content = "Dynamic Hello";
            dynamicButton.Background = new SolidColorBrush(Colors.Green);
            dynamicButton.Click += dynamicButton_Click;
            this.DynamicStackPanel.Children.Add(dynamicButton);

            TextBlock dynamicTextBlock = new TextBlock();
            dynamicTextBlock.Name = "dynamicTextBlock";
            dynamicTextBlock.Text = string.Empty;
            dynamicTextBlock.Margin = new Thickness(12);
            dynamicTextBlock.FontSize = 48;
            this.DynamicStackPanel.Children.Add(dynamicTextBlock);

        }

        void dynamicButton_Click(object sender, RoutedEventArgs e)
        {
            (this.FindName("dynamicTextBlock") as TextBlock).Text = "Dynamic hello!";
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // TODO: Prepare page for display here.

            // TODO: If your application contains multiple pages, ensure that you are
            // handling the hardware Back button by registering for the
            // Windows.Phone.UI.Input.HardwareButtons.BackPressed event.
            // If you are using the NavigationHelper provided by some templates,
            // this event is handled for you.
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            this.HelloTextBlock.Text = "Hello!";
        }
    }
}

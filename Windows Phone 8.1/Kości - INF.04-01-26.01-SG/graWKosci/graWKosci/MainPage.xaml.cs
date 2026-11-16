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
using Windows.UI.Xaml.Media.Imaging;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=391641

namespace graWKosci
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>

    public sealed partial class MainPage : Page
    {
        bool[] activeDices = { true, true, true, true, true };
        int[] diceValues = new int[5];
        int userScore = 0;
        Random rnd = new Random();

        public MainPage()
        {
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required;
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

        private void Rzut_Click(object sender, RoutedEventArgs e)
        {
            //scoreTxt.Text = "";
            userScore = 0;
            for (int i = 0; i < 5; i++)
            {
                if (!activeDices[i])
                {
                    diceValues[i] = diceValues[i];
                }
                else
                    diceValues[i] = rnd.Next(6) + 1;
                userScore += diceValues[i];
                //scoreTxt.Text = scoreTxt.Text + diceValues[i].ToString() + " ";
            }
            scoreTxt.Text = userScore.ToString();
            dice1.Source =  new BitmapImage(new Uri($"ms-appx:///Assets/dices/d{diceValues[0].ToString()}.png", UriKind.Absolute));
            dice2.Source =  new BitmapImage(new Uri($"ms-appx:///Assets/dices/d{diceValues[1].ToString()}.png", UriKind.Absolute));
            dice3.Source =  new BitmapImage(new Uri($"ms-appx:///Assets/dices/d{diceValues[2].ToString()}.png", UriKind.Absolute));
            dice4.Source =  new BitmapImage(new Uri($"ms-appx:///Assets/dices/d{diceValues[3].ToString()}.png", UriKind.Absolute));
            dice5.Source =  new BitmapImage(new Uri($"ms-appx:///Assets/dices/d{diceValues[4].ToString()}.png", UriKind.Absolute));
        }

        private void dice1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (activeDices[0])
            {
                activeDices[0] = !activeDices[0];
                dice1.Opacity = 0.5;
            }
            else
            {
                activeDices[0] = !activeDices[0];
                dice1.Opacity = 1;
            }
        }

        private void dice2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (activeDices[1])
            {
                activeDices[1] = !activeDices[1];
                dice2.Opacity = 0.5;
            }
            else
            {
                activeDices[1] = !activeDices[1];
                dice2.Opacity = 1;
            }
        }

        private void dice3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (activeDices[2])
            {
                activeDices[2] = !activeDices[2];
                dice3.Opacity = 0.5;
            }
            else
            {
                activeDices[2] = !activeDices[2];
                dice3.Opacity = 1;
            }
        }

        private void dice4_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (activeDices[3])
            {
                activeDices[3] = !activeDices[3];
                dice4.Opacity = 0.5;
            }
            else
            {
                activeDices[3] = !activeDices[3];
                dice4.Opacity = 1;
            }
        }

        private void dice5_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (activeDices[4])
            {
                activeDices[4] = !activeDices[4];
                dice5.Opacity = 0.5;
            }
            else
            {
                activeDices[4] = !activeDices[4];
                dice5.Opacity = 1;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace CS2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Card1_MouseEnter(object sender, MouseEventArgs e)
        {
            Card1.Opacity = 1;
            Video1.Visibility = Visibility.Visible;
            Video1.Play();
            Card1Label.Visibility = Visibility.Collapsed;
        }

        private void Card1_MouseLeave(object sender, MouseEventArgs e)
        {
            Card1.Opacity = 0.5;
            Video1.Visibility = Visibility.Collapsed;
            Video1.Stop();
            Card1Label.Visibility = Visibility.Visible;
        }

        private void Video1_MediaEnded(object sender, RoutedEventArgs e)
        {
            Video1.Position = TimeSpan.Zero;
            Video1.Play();
        }

        private void Card2_MouseLeave(object sender, MouseEventArgs e)
        {
            Card2.Opacity = 0.5;
            Video2.Visibility = Visibility.Collapsed;
            Video2.Stop();
            Card2Label.Visibility = Visibility.Visible;
        }

        private void Card2_MouseEnter(object sender, MouseEventArgs e)
        {
            Card2.Opacity = 1;
            Video2.Visibility = Visibility.Visible;
            Video2.Play();
            Card2Label.Visibility = Visibility.Collapsed;
        }

        private void Video2_MediaEnded(object sender, RoutedEventArgs e)
        {
            Video2.Position = TimeSpan.Zero;
            Video2.Play();
        }

        private void Card3_MouseEnter(object sender, MouseEventArgs e)
        {
            Card3.Opacity = 1;
            Video3.Visibility = Visibility.Visible;
            Video3.Play();
            Card3Label.Visibility = Visibility.Collapsed;
        }

        private void Card3_MouseLeave(object sender, MouseEventArgs e)
        {
            Card3.Opacity = 0.5;
            Video3.Visibility = Visibility.Collapsed;
            Video3.Stop();
            Card3Label.Visibility = Visibility.Visible;
        }

        private void Video3_MediaEnded(object sender, RoutedEventArgs e)
        {
            Video2.Position = TimeSpan.Zero;
            Video2.Play();
        }
    }
}

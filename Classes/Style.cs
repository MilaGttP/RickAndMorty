
using System.Windows;
using System.Windows.Controls;

namespace RickAndMorty
{
    public class Style
    {
        private UserControl control;
        public Style(UserControl control)
        {
            this.control = control;
        }
        public void Close_Click(object sender, RoutedEventArgs e)
        {
            Window window = Window.GetWindow(control);
            if (window != null) window.Close();
        }
        public void Minimize_Click(object sender, RoutedEventArgs e)
        {
            Window window = Window.GetWindow(control);
            if (window != null) window.WindowState = WindowState.Minimized;
        }
        public void Maximize_Click(object sender, RoutedEventArgs e)
        {
            Window window = Window.GetWindow(control);
            if (window != null) window.WindowState = WindowState.Maximized;
        }
    }
}
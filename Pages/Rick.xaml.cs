using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace RickAndMorty
{
    public partial class Rick : UserControl
    {
        public Rick()
        {
            InitializeComponent();
            Style style = new Style(this);
            Back.Click += style.Back_Click;
        }

        private void RickPage_Loaded(object sender, RoutedEventArgs e)
        {
            Character Rick = JsonWork.GetCharacter(1);
            Name.Text = Rick.Name;
            if (Rick.Type == "") Type.Text = "unknown";
            else Type.Text = Rick.Type;
            Gender.Text = Rick.Gender;
            Location.Text = JsonWork.GetLocationForCharacter(1);
            List<string> episodes = new List<string>();
            episodes = JsonWork.GetEpisodesForCharacter(1);
            Episode.Text = $"{episodes[0]}, {episodes[1]}, {episodes[2]}, {episodes[3]}, {episodes[4]}";
            Url.Text = Rick.Url;
        }
    }
}

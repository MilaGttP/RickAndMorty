using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace RickAndMorty
{
    public partial class Jerry : UserControl
    {
        public Jerry()
        {
            InitializeComponent();
            Style style = new Style(this);
            Back.Click += style.Back_Click;
        }

        private void JerryPage_Loaded(object sender, RoutedEventArgs e)
        {
            Character Jerry = JsonWork.GetCharacter(5);
            Name.Text = Jerry.Name;
            if (Jerry.Type == "") Type.Text = "unknown";
            else Type.Text = Jerry.Type;
            Gender.Text = Jerry.Gender;
            Location.Text = JsonWork.GetLocationForCharacter(5);
            List<string> episodes = new List<string>();
            episodes = JsonWork.GetEpisodesForCharacter(5);
            Episode.Text = $"{episodes[0]}, {episodes[1]}, {episodes[2]}";
            Url.Text = Jerry.Url;
        }
    }
}

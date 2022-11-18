using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace RickAndMorty
{
    public partial class Summer : UserControl
    {
        public Summer()
        {
            InitializeComponent();            
            Style style = new Style(this);
            Back.Click += style.Back_Click;
        }

        private void SummerPage_Loaded(object sender, RoutedEventArgs e)
        {
            Character Summer = JsonWork.GetCharacter(3);
            Name.Text = Summer.Name;
            if (Summer.Type == "") Type.Text = "unknown";
            else Type.Text = Summer.Type;
            Gender.Text = Summer.Gender;
            Location.Text = JsonWork.GetLocationForCharacter(3);
            List<string> episodes = new List<string>();
            episodes = JsonWork.GetEpisodesForCharacter(3);
            Episode.Text = $"{episodes[0]}, {episodes[1]}, {episodes[2]}";
            Url.Text = Summer.Url;
        }
    }
}

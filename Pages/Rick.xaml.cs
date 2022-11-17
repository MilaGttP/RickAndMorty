using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace RickAndMorty
{
    /// <summary>
    /// Логика взаимодействия для Rick.xaml
    /// </summary>
    public partial class Rick : UserControl
    {
        List<Character> characters;
        public Rick()
        {
            InitializeComponent();
            characters = new List<Character>();
            JsonWork.GetCharactersFromJson(ref characters);
            Style style = new Style(this);
            Back.Click += style.Back_Click;
        }

        private void RickPage_Loaded(object sender, RoutedEventArgs e)
        {
            Character Rick = JsonWork.GetCharacter(ref characters, 1);
            Name.Text = Rick.Name;
            if (Rick.Type == "") Type.Text = "unknown";
            else Type.Text = Rick.Type;
            Gender.Text = Rick.Gender;
            Location.Text = JsonWork.GetLocationForCharacter(ref characters, 1);
            List<string> episodes = new List<string>();
            episodes = JsonWork.GetEpisodesForCharacter(ref characters, 1);
            Episode.Text = $"{episodes[0]}, {episodes[1]}, {episodes[2]}, {episodes[3]}, {episodes[4]}";
            Url.Text = Rick.Url;
        }
    }
}

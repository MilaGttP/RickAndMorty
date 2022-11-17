using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace RickAndMorty
{
    /// <summary>
    /// Логика взаимодействия для Jerry.xaml
    /// </summary>
    public partial class Jerry : UserControl
    {
        List<Character> characters;
        public Jerry()
        {
            InitializeComponent();
            characters = new List<Character>();
            JsonWork.GetCharactersFromJson(ref characters);
            Style style = new Style(this);
            Back.Click += style.Back_Click;
        }

        private void JerryPage_Loaded(object sender, RoutedEventArgs e)
        {
            Character Jerry = JsonWork.GetCharacter(ref characters, 5);
            Name.Text = Jerry.Name;
            if (Jerry.Type == "") Type.Text = "unknown";
            else Type.Text = Jerry.Type;
            Gender.Text = Jerry.Gender;
            Location.Text = JsonWork.GetLocationForCharacter(ref characters, 5);
            List<string> episodes = new List<string>();
            episodes = JsonWork.GetEpisodesForCharacter(ref characters, 5);
            Episode.Text = $"{episodes[0]}, {episodes[1]}, {episodes[2]}";
            Url.Text = Jerry.Url;
        }
    }
}

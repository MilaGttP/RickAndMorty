using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace RickAndMorty
{
    /// <summary>
    /// Логика взаимодействия для Beth.xaml
    /// </summary>
    public partial class Beth : UserControl
    {
        List<Character> characters;
        public Beth()
        {
            InitializeComponent();
            characters = new List<Character>();
            JsonWork.GetCharactersFromJson(ref characters);
            Style style = new Style(this);
            Back.Click += style.Back_Click;
        }

        private void BethPage_Loaded(object sender, RoutedEventArgs e)
        {
            Character Beth = JsonWork.GetCharacter(4);
            Name.Text = Beth.Name;
            if (Beth.Type == "") Type.Text = "unknown";
            else Type.Text = Beth.Type;
            Gender.Text = Beth.Gender;
            Location.Text = JsonWork.GetLocationForCharacter(4);
            List<string> episodes = new List<string>();
            episodes = JsonWork.GetEpisodesForCharacter(4);
            Episode.Text = $"{episodes[0]}, {episodes[1]}, {episodes[2]}";
            Url.Text = Beth.Url;
        }
    }
}

using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace RickAndMorty
{
    /// <summary>
    /// Логика взаимодействия для Summer.xaml
    /// </summary>
    public partial class Summer : UserControl
    {
        List<Character> characters;
        public Summer()
        {
            InitializeComponent();
            characters = new List<Character>();
            JsonWork.GetCharactersFromJson(ref characters);
            Style style = new Style(this);
            Back.Click += style.Back_Click;
        }

        private void SummerPage_Loaded(object sender, RoutedEventArgs e)
        {
            Character Summer = JsonWork.GetCharacter(ref characters, 3);
            Name.Text = Summer.Name;
            if (Summer.Type == "") Type.Text = "unknown";
            else Type.Text = Summer.Type;
            Gender.Text = Summer.Gender;
            Location.Text = JsonWork.GetLocationForCharacter(ref characters, 3);
            List<string> episodes = new List<string>();
            episodes = JsonWork.GetEpisodesForCharacter(ref characters, 3);
            Episode.Text = $"{episodes[0]}, {episodes[1]}, {episodes[2]}";
            Url.Text = Summer.Url;
        }
    }
}

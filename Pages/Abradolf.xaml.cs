using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace RickAndMorty
{
    public partial class Abradolf : UserControl
    {
        List<Character> characters;
        public Abradolf()
        {
            InitializeComponent();
            characters = new List<Character>();
            JsonWork.GetCharactersFromJson(ref characters);
            Style style = new Style(this);
            Back.Click += style.Back_Click;
        }

        private void AbradolfPage_Loaded(object sender, RoutedEventArgs e)
        {
            Character Abradolf = JsonWork.GetCharacter(7);
            Name.Text = Abradolf.Name;
            if (Abradolf.Type == "") Type.Text = "unknown";
            else Type.Text = Abradolf.Type;
            Gender.Text = Abradolf.Gender;
            Location.Text = JsonWork.GetLocationForCharacter(7);
            List<string> episodes = new List<string>();
            episodes = JsonWork.GetEpisodesForCharacter(7);
            Episode.Text = $"{episodes[0]}, {episodes[1]}";
            Url.Text = Abradolf.Url;
        }
    }
}

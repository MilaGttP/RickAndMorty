using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace RickAndMorty
{
    public partial class Morty : UserControl
    {
        List<Character> characters;
        public Morty()
        {
            InitializeComponent();
            characters = new List<Character>();
            JsonWork.GetCharactersFromJson(ref characters);
            Style style = new Style(this);
            Back.Click += style.Back_Click;
        }

        private void MortyPage_Loaded(object sender, RoutedEventArgs e)
        {
            Character Morty = JsonWork.GetCharacter(2);
            Name.Text = Morty.Name;
            if (Morty.Type == "") Type.Text = "unknown";
            else Type.Text = Morty.Type;
            Gender.Text = Morty.Gender;
            Location.Text = JsonWork.GetLocationForCharacter(2);
            List<string> episodes = new List<string>();
            episodes = JsonWork.GetEpisodesForCharacter(2);
            Episode.Text = $"{episodes[0]}, {episodes[1]}, {episodes[2]}, {episodes[3]}, {episodes[4]}";
            Url.Text = Morty.Url;
        }
    }
}


using System.Windows.Controls;
using System.Collections.Generic;
using System.Windows;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Net;
using System.Linq;

namespace RickAndMorty
{
    /// <summary>
    /// Логика взаимодействия для Main.xaml
    /// </summary>
    public partial class Main : UserControl
    {
        List<Character> characters;
        public Main()
        {
            InitializeComponent();
            characters = new List<Character>();
            JsonWork.GetCharactersFromJson(ref characters);
            JsonWork.GetEpisodesForCharacter(ref characters, 1);

            Style style = new Style(this);
            CloseButton.Click += style.Close_Click;
            MinimizeButton.Click += style.Minimize_Click;
            MaximizeButton.Click += style.Maximize_Click;
        }

        private void Main_Loaded(object sender, RoutedEventArgs e)
        {
            Character JerrySmith = new Character();
            JerrySmith = JsonWork.GetCharacter(ref characters, 5);
            JerryName.Text = JerrySmith.Name;
            JerryStatus.Text = $"{JerrySmith.Status} - {JerrySmith.Species}\n";
            JerryLastLoc.Text = $"{JsonWork.GetLocationForCharacter(ref characters, 5)}\n";
            JerryFSeen.Text = JsonWork.GetFirstEpisodeForCharacter(ref characters, 5);

            Character Rick = new Character();
            Rick = JsonWork.GetCharacter(ref characters, 1);
            RickName.Text = Rick.Name;  
            RickStatus.Text = $"{Rick.Status} - {Rick.Species}\n";
            RickLastLoc.Text = $"{JsonWork.GetLocationForCharacter(ref characters, 1)}\n";
            RickFSeen.Text = JsonWork.GetFirstEpisodeForCharacter(ref characters, 1);

            Character Morty = new Character();
            Morty = JsonWork.GetCharacter(ref characters, 2);
            MortyName.Text = Morty.Name;
            MortyStatus.Text = $"{Morty.Status} - {Morty.Species}\n";
            MortyLastLoc.Text = $"{JsonWork.GetLocationForCharacter(ref characters, 2)}\n";
            MortyFSeen.Text = JsonWork.GetFirstEpisodeForCharacter(ref characters, 2);
        }
    }
}

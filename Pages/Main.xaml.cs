
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

            Style style = new Style(this);
            CloseButton.Click += style.Close_Click;
            MinimizeButton.Click += style.Minimize_Click;
            MaximizeButton.Click += style.Maximize_Click;
        }

        private void Main_Loaded(object sender, RoutedEventArgs e)
        {
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

            Character Summer = new Character();
            Summer = JsonWork.GetCharacter(ref characters, 3);
            SummerName.Text = Summer.Name;
            SummerStatus.Text = $"{Summer.Status} - {Summer.Species}\n";
            SummerLastLoc.Text = $"{JsonWork.GetLocationForCharacter(ref characters, 3)}\n";
            SummerFSeen.Text = JsonWork.GetFirstEpisodeForCharacter(ref characters, 3);

            Character Beth = new Character();
            Beth = JsonWork.GetCharacter(ref characters, 4);
            BethName.Text = Beth.Name;
            BethStatus.Text = $"{Beth.Status} - {Beth.Species}\n";
            BethLastLoc.Text = $"{JsonWork.GetLocationForCharacter(ref characters, 4)}\n";
            BethFSeen.Text = JsonWork.GetFirstEpisodeForCharacter(ref characters, 4);

            Character JerrySmith = new Character();
            JerrySmith = JsonWork.GetCharacter(ref characters, 5);
            JerryName.Text = JerrySmith.Name;
            JerryStatus.Text = $"{JerrySmith.Status} - {JerrySmith.Species}\n";
            JerryLastLoc.Text = $"{JsonWork.GetLocationForCharacter(ref characters, 5)}\n";
            JerryFSeen.Text = JsonWork.GetFirstEpisodeForCharacter(ref characters, 5);

            Character Abradolf = new Character();
            Abradolf = JsonWork.GetCharacter(ref characters, 7);
            AbradolfName.Text = Abradolf.Name;
            AbradolfStatus.Text = $"{Abradolf.Status} - {Abradolf.Species}\n";
            AbradolfLastLoc.Text = $"{JsonWork.GetLocationForCharacter(ref characters, 7)}\n";
            AbradolfFSeen.Text = JsonWork.GetFirstEpisodeForCharacter(ref characters, 7);
        }

        private void Rick_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new MoreCharacterInfo());
        }
    }
}

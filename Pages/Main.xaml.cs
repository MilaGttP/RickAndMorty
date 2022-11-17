
using System.Windows.Controls;
using System.Collections.Generic;
using System.Windows;

namespace RickAndMorty
{
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
            Rick = JsonWork.GetCharacter(1);
            RickName.Text = Rick.Name;
            RickStatus.Text = $"{Rick.Status} - {Rick.Species}\n";
            RickLastLoc.Text = $"{JsonWork.GetLocationForCharacter(1)}\n";
            RickFSeen.Text = JsonWork.GetFirstEpisodeForCharacter(1);

            Character Morty = new Character();
            Morty = JsonWork.GetCharacter(2);
            MortyName.Text = Morty.Name;
            MortyStatus.Text = $"{Morty.Status} - {Morty.Species}\n";
            MortyLastLoc.Text = $"{JsonWork.GetLocationForCharacter(2)}\n";
            MortyFSeen.Text = JsonWork.GetFirstEpisodeForCharacter(2);

            Character Summer = new Character();
            Summer = JsonWork.GetCharacter(3);
            SummerName.Text = Summer.Name;
            SummerStatus.Text = $"{Summer.Status} - {Summer.Species}\n";
            SummerLastLoc.Text = $"{JsonWork.GetLocationForCharacter(3)}\n";
            SummerFSeen.Text = JsonWork.GetFirstEpisodeForCharacter(3);

            Character Beth = new Character();
            Beth = JsonWork.GetCharacter(4);
            BethName.Text = Beth.Name;
            BethStatus.Text = $"{Beth.Status} - {Beth.Species}\n";
            BethLastLoc.Text = $"{JsonWork.GetLocationForCharacter(4)}\n";
            BethFSeen.Text = JsonWork.GetFirstEpisodeForCharacter(4);

            Character Jerry = new Character();
            Jerry = JsonWork.GetCharacter(5);
            JerryName.Text = Jerry.Name;
            JerryStatus.Text = $"{Jerry.Status} - {Jerry.Species}\n";
            JerryLastLoc.Text = $"{JsonWork.GetLocationForCharacter(5)}\n";
            JerryFSeen.Text = JsonWork.GetFirstEpisodeForCharacter(5);

            Character Abradolf = new Character();
            Abradolf = JsonWork.GetCharacter(7);
            AbradolfName.Text = Abradolf.Name;
            AbradolfStatus.Text = $"{Abradolf.Status} - {Abradolf.Species}\n";
            AbradolfLastLoc.Text = $"{JsonWork.GetLocationForCharacter(7)}\n";
            AbradolfFSeen.Text = JsonWork.GetFirstEpisodeForCharacter(7);
        }

        private void Rick_Click(object sender, RoutedEventArgs e) => Switcher.Switch(new Rick());
        private void Morty_Click(object sender, RoutedEventArgs e) => Switcher.Switch(new Morty());
        private void Summer_Click(object sender, RoutedEventArgs e) => Switcher.Switch(new Summer());
        private void Beth_Click(object sender, RoutedEventArgs e) => Switcher.Switch(new Beth());
        private void Jerry_Click(object sender, RoutedEventArgs e) => Switcher.Switch(new Jerry());
        private void Abradolf_Click(object sender, RoutedEventArgs e) => Switcher.Switch(new Abradolf());
    }
}


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
            Character JerrySmith = new Character();
            JerrySmith = JsonWork.GetCharacter(ref characters, 5);
            FirstName.Text = JerrySmith.Name;
            FirstStatus.Text = $"{JerrySmith.Status} - {JerrySmith.Species}\n";
            FirstLastLoc.Text = $"{JerrySmith.Location.ToString()}\n";
            FirstFSeen.Text = JerrySmith.Episode[0].ToString();
        }
    }
}

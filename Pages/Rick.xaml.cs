using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RickAndMorty
{
    /// <summary>
    /// Логика взаимодействия для MoreCharacterInfo.xaml
    /// </summary>
    public partial class MoreCharacterInfo : UserControl
    {
        List<Character> characters;
        public MoreCharacterInfo()
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

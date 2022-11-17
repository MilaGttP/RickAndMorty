using System;
using System.Collections.Generic;
using System.Linq;
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
        }

        private void Back_Click(object sender, RoutedEventArgs e) => Switcher.Switch(new Main());

        private void RickPage_Loaded(object sender, RoutedEventArgs e)
        {
            Character Rick = JsonWork.GetCharacter(ref characters, 1);
            Name.Text = Rick.Name;
        }
    }
}

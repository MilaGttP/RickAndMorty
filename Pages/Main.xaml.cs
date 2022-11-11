
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
        List<Location> locations;
        public Main()
        {
            InitializeComponent();
            locations = new List<Location>();
            GetLocationFromJson();
        }
        public void GetLocationFromJson()
        {
            var webRequest = WebRequest.Create("https://rickandmortyapi.com/api/location") as HttpWebRequest;
            if (webRequest == null) return;
            webRequest.ContentType = "application/json";
            webRequest.UserAgent = "Nothing";
            using (var s = webRequest.GetResponse().GetResponseStream())
            {
                using (var sr = new StreamReader(s))
                {
                    var locationsAsJson = sr.ReadToEnd();
                    JObject json = JObject.Parse(locationsAsJson);
                    List<JToken> jTokens = json["results"].Children().ToList();
                    foreach (JToken item in jTokens)
                    {
                        Location newLocation = item.ToObject<Location>();
                        locations.Add(newLocation);
                        MessageBox.Show(item.ToString());
                    }
                }
            }
        }
    }
}

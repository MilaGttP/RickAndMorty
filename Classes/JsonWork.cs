
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows;

namespace RickAndMorty
{
    public static class JsonWork
    {
        public static void GetCharactersFromJson(ref List<Character> characters)
        {
            var webRequest = WebRequest.Create("https://rickandmortyapi.com/api/character") as HttpWebRequest;
            if (webRequest == null) return;
            webRequest.ContentType = "application/json";
            webRequest.UserAgent = "Nothing";
            using (var s = webRequest.GetResponse().GetResponseStream())
            {
                using (var sr = new StreamReader(s))
                {
                    var charactersAsJson = sr.ReadToEnd();
                    JObject json = JObject.Parse(charactersAsJson);
                    List<JToken> jTokens = json["results"].Children().ToList();
                    foreach (JToken item in jTokens)
                    {
                        Character newCharacter = item.ToObject<Character>();
                        characters.Add(newCharacter);
                    }
                }
            }
        }

        public static Character GetCharacter(ref List<Character> characters, int id)
        {
            Character result = new Character();
            for (int i = 0; i < characters.Count; i++) if (i == id - 1) result = characters[i];
            return result;
        }

        public static void GetLocationsFromJson(ref List<Location> locations)
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
                    }
                }
            }
        }

        public static void GetLocationsForCharacter(ref List<Character> characters)
        {

        }

        public static void GetEpisodesFromJson(ref List<Episode> episodes)
        {
            var webRequest = WebRequest.Create("https://rickandmortyapi.com/api/episode") as HttpWebRequest;
            if (webRequest == null) return;
            webRequest.ContentType = "application/json";
            webRequest.UserAgent = "Nothing";
            using (var s = webRequest.GetResponse().GetResponseStream())
            {
                using (var sr = new StreamReader(s))
                {
                    var episodesAsJson = sr.ReadToEnd();
                    JObject json = JObject.Parse(episodesAsJson);
                    List<JToken> jTokens = json["results"].Children().ToList();
                    foreach (JToken item in jTokens)
                    {
                        Episode newEpisode = item.ToObject<Episode>();
                        episodes.Add(newEpisode);
                    }
                }
            }
        }

        public static void GetEpisodesForCharacter(ref List<Character> characters)
        {

        }
    }
}

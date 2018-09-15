// <auto-generated>
// Code generated by LUISGen
// Tool github: https://github.com/microsoft/botbuilder-tools
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>
using Microsoft.Bot.Builder;
using Newtonsoft.Json;
using System.Collections.Generic;
namespace Luis
{
    public class Dispatch : IRecognizerConvert
    {
        public string Text;
        public string AlteredText;
        public enum Intent
        {
            l_EnterpriseBot_General,
            q_EnterpriseBot_faq,
            None
        };
        public Dictionary<Intent, IntentScore> Intents;

        public class _Entities
        {

            // Instance
            public class _Instance
            {
            }
            [JsonProperty("$instance")]
            public _Instance _instance;
        }
        public _Entities Entities;

        [JsonExtensionData(ReadData = true, WriteData = true)]
        public IDictionary<string, object> Properties { get; set; }

        public void Convert(dynamic result)
        {
            var app = JsonConvert.DeserializeObject<Dispatch>(JsonConvert.SerializeObject(result));
            Text = app.Text;
            AlteredText = app.AlteredText;
            Intents = app.Intents;
            Entities = app.Entities;
            Properties = app.Properties;
        }

        public (Intent intent, double score) TopIntent()
        {
            Intent maxIntent = Intent.None;
            var max = 0.0;
            foreach (var entry in Intents)
            {
                if (entry.Value.Score > max)
                {
                    maxIntent = entry.Key;
                    max = (double)entry.Value.Score;
                }
            }
            return (maxIntent, max);
        }
    }
}
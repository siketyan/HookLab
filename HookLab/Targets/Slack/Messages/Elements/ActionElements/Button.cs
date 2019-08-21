using System;
using HookLab.Targets.Slack.Messages.Elements.Texts;
using Newtonsoft.Json;

namespace HookLab.Targets.Slack.Messages.Elements.ActionElements
{
    public class Button : IActionElement
    {
        [JsonProperty("type")]
        public ActionElementType Type { get; } = ActionElementType.Button;
        
        [JsonProperty("text")]
        public PlainText Text { get; set; }
        
        [JsonProperty("url")]
        public Uri Url { get; set; }

        public static Button Create(string text, Uri url)
        {
            return new Button
            {
                Text = PlainText.Create(text),
                Url = url
            };
        }
    }
}

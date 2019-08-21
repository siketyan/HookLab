using Newtonsoft.Json;

namespace HookLab.Targets.Slack.Messages
{
    public class TextMessage : Message
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }
}

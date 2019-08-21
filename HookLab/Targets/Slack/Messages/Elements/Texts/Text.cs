using Newtonsoft.Json;

namespace HookLab.Targets.Slack.Messages.Elements.Texts
{
    public abstract class Text
    {
        [JsonProperty("text")]
        public string Content { get; set; }
    }
}

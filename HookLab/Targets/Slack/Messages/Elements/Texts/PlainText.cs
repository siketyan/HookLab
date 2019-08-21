using Newtonsoft.Json;

namespace HookLab.Targets.Slack.Messages.Elements.Texts
{
    public class PlainText : Text
    {
        [JsonProperty("type")]
        public TextType Type { get; } = TextType.PlainText;
        
        [JsonProperty("emoji")]
        public bool Emoji { get; set; }

        public static PlainText Create(string content, bool emoji = false)
        {
            return Create<PlainText>(content, emoji);
        }

        protected static T Create<T>(string content, bool emoji = false) where T : PlainText, new()
        {
            return new T
            {
                Content = content,
                Emoji = emoji
            };
        }
    }
}

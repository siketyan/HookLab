using Newtonsoft.Json;

namespace HookLab.Targets.Slack.Messages.Elements.Texts
{
    public class Markdown : Text
    {
        [JsonProperty("type")]
        public TextType Type { get; } = TextType.Markdown;

        public static Markdown Create(string content)
        {
            return Create<Markdown>(content);
        }

        protected static T Create<T>(string content) where T : Markdown, new()
        {
            return new T
            {
                Content = content
            };
        }
    }
}

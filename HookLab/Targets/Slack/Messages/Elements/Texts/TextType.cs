using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace HookLab.Targets.Slack.Messages.Elements.Texts
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TextType
    {
        [EnumMember(Value = "plain_text")]
        PlainText,
        
        [EnumMember(Value = "mrkdwn")]
        Markdown
    }
}

using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace HookLab.Targets.Slack.Messages.Elements.ContextElements
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ContextElementType
    {
        [EnumMember(Value = "plain_text")]
        PlainText,
        
        [EnumMember(Value = "markdown")]
        Markdown,
        
        [EnumMember(Value = "image")]
        Image
    }
}

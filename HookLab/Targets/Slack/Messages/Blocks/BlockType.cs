using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace HookLab.Targets.Slack.Messages.Blocks
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum BlockType
    {
        [EnumMember(Value = "section")]
        Section,
        
        [EnumMember(Value = "image")]
        Image,
        
        [EnumMember(Value = "context")]
        Context,
        
        [EnumMember(Value = "actions")]
        Actions,
        
        [EnumMember(Value = "divider")]
        Divider
    }
}

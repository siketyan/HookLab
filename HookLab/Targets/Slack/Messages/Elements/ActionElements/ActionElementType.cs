using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace HookLab.Targets.Slack.Messages.Elements.ActionElements
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ActionElementType
    {
        [EnumMember(Value = "static_select")]
        StaticSelect,
        
        [EnumMember(Value = "users_select")]
        UsersSelect,
        
        [EnumMember(Value = "conversations_select")]
        ConversationsSelect,
        
        [EnumMember(Value = "channels_select")]
        ChannelsSelect,
        
        [EnumMember(Value = "external_select")]
        ExternalSelect,
        
        [EnumMember(Value = "button")]
        Button,
        
        [EnumMember(Value = "overflow")]
        Overflow, 
        
        [EnumMember(Value = "datepicker")]
        Datepicker,
        
        [EnumMember(Value = "range_datepicker")]
        RangeDatepicker
    }
}

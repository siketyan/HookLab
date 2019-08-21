using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace HookLab.Providers.GitLab.Events
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ObjectKind
    {
        [EnumMember(Value = "push")]
        Push,
        
        [EnumMember(Value = "tag")]
        Tag,
        
        [EnumMember(Value = "issue")]
        Issue,
        
        [EnumMember(Value = "note")]
        Note,
        
        [EnumMember(Value = "merge_request")]
        MergeRequest,
        
        [EnumMember(Value = "wiki_page")]
        WikiPage,
        
        [EnumMember(Value = "pipeline")]
        Pipeline,
        
        [EnumMember(Value = "job")]
        Job
    }
}

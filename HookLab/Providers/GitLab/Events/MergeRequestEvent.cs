using HookLab.Providers.GitLab.Models;
using Newtonsoft.Json;

namespace HookLab.Providers.GitLab.Events
{
    public class MergeRequestEvent : Event
    {
        [JsonProperty("object_attributes")]
        public MergeRequest MergeRequest { get; set; }
    }
}

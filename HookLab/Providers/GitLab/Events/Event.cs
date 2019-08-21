using Newtonsoft.Json;

namespace HookLab.Providers.GitLab.Events
{
    public abstract class Event
    {
        [JsonProperty("object_kind")]
        public ObjectKind ObjectKind { get; set; }
    }
}

using HookLab.Providers.GitLab.Models;
using Newtonsoft.Json;

namespace HookLab.Providers.GitLab.Events
{
    public abstract class UserAwareEvent : Event
    {
        [JsonProperty("user")]
        public User User { get; set; }
    }
}

using System;
using Newtonsoft.Json;

namespace HookLab.Providers.GitLab.Models
{
    public class Project : Repository
    {
        [JsonProperty("id")]
        public long Id { get; set; }
        
        [JsonProperty("namespace")]
        public string Namespace { get; set; }
        
        [JsonProperty("path_with_namespace")]
        public string PathWithNamespace { get; set; }
        
        [JsonProperty("default_branch")]
        public string DefaultBranch { get; set; }
        
        [JsonProperty("visibility_level")]
        public VisibilityLevel VisibilityLevel { get; set; }
        
        [JsonProperty("web_url")]
        public Uri WebUrl { get; set; }
        
        [JsonProperty("avatar_url")]
        public Uri AvatarUrl { get; set; }
        
        [JsonProperty("git_ssh_url")]
        public Uri GitSshUrl { get; set; }
        
        [JsonProperty("git_http_url")]
        public Uri GitHttpUrl { get; set; }
    }
}

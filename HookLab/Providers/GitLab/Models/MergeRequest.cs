using System;
using System.Collections.Generic;
using HookLab.Providers.GitLab.Converters;
using Newtonsoft.Json;

namespace HookLab.Providers.GitLab.Models
{
    public class MergeRequest
    {
        [JsonProperty("id")]
        public long Id { get; set; }
        
        [JsonProperty("iid")]
        public long Iid { get; set; }
        
        [JsonProperty("assignee_id")]
        public long AssigneeId { get; set; }
        
        [JsonProperty("author_id")]
        public long AuthorId { get; set; }
        
        [JsonProperty("head_pipeline_id")]
        public long? HeadPipelineId { get; set; }
        
        [JsonProperty("updated_by_id")]
        public long? UpdatedById { get; set; }
        
        [JsonProperty("last_edited_by_id")]
        public long? LastEditedById { get; set; }
        
        [JsonProperty("assignee_ids")]
        public IEnumerable<long> AssigneeIds { get; set; }
            
        [JsonProperty("title")]
        public string Title { get; set; }
        
        [JsonProperty("source_branch")]
        public string SourceBranch { get; set; }
        
        [JsonProperty("target_branch")]
        public string TargetBranch { get; set; }
        
        [JsonProperty("work_in_progress")]
        public bool WorkInProgress { get; set; }
        
        [JsonProperty("source")]
        public Project Source { get; set; }
        
        [JsonProperty("target")]
        public Project Target { get; set; }
        
        [JsonProperty("url")]
        public Uri Url { get; set; }
        
        [JsonProperty("created_at")]
        [JsonConverter(typeof(GitLabDateTimeConverter))]
        public DateTime CreatedAt { get; set; }
        
        [JsonProperty("updated_at")]
        [JsonConverter(typeof(GitLabDateTimeConverter))]
        public DateTime? UpdatedAt { get; set; }
        
        [JsonProperty("last_edited_at")]
        [JsonConverter(typeof(GitLabDateTimeConverter))]
        public DateTime? LastEditedAt { get; set; }
    }
}

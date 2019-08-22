using System;
using System.IO;
using HookLab.Models;
using HookLab.Providers.GitLab.Events;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace HookLab.Providers.GitLab
{
    public class GitLabProvider : IProvider
    {
        private const string DefaultHeaderKey = "X-Gitlab-Event";

        public Notification Provide(HttpRequest request)
        {
            var json = new StreamReader(request.Body).ReadToEnd();
            var eventType = request.Headers[DefaultHeaderKey];
            
            switch (eventType)
            {
                case "Note Hook":
                {
                    var e = Deserialize<NoteEvent>(json);
                
                    return new Notification(this)
                    {
                        Title = e.User.Name,
                        Content = e.Note.Content,
                        Header = e.Project.PathWithNamespace,
                        Url = e.Note.Url,
                        Sender = e.User.Username
                    };
                }
                
                default: throw new NotSupportedException(
                    "The hook is not supported yet."
                );
            }
        }

        public bool Supports(HttpRequest request)
        {
            return request.Headers.ContainsKey(DefaultHeaderKey);
        }

        private static T Deserialize<T>(string json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}

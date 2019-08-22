using System;
using HookLab.Providers;
using Microsoft.AspNetCore.Http;

namespace HookLab.Models
{
    public class Notification
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Header { get; set; }
        public string Sender { get; set; }
        public Uri Url { get; set; }
        public IProvider Provider { get; }

        public Notification(IProvider provider)
        {
            Provider = provider;
        }
        
        public class Builder
        {
            private readonly ProviderResolver _resolver;

            public Builder(ProviderResolver resolver)
            {
                _resolver = resolver;
            }
            
            public Notification Build(HttpRequest request)
            {
                return _resolver
                    .Resolve(request)
                    .Provide(request);
            }
        }
    }
}

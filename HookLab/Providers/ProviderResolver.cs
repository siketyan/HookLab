using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;

namespace HookLab.Providers
{
    public class ProviderResolver
    {
        private readonly IEnumerable<IProvider> _providers;

        public ProviderResolver(IEnumerable<IProvider> providers)
        {
            _providers = providers;
        }

        public IProvider Resolve(HttpRequest request)
        {
            foreach (var provider in _providers)
            {
                if (provider.Supports(request))
                {
                    return provider;
                }
            }
            
            throw new NotSupportedException(
                "No provider supports the request."
            );
        }
    }
}

using System.Threading.Tasks;
using HookLab.Configurations;
using HookLab.Models;
using HookLab.Providers;
using HookLab.Targets;
using Microsoft.AspNetCore.Http;

namespace HookLab
{
    public class Notifier
    {
        private readonly TargetManager _targetManager;
        private readonly Notification.Builder _builder;

        public Notifier()
        {
            var providerResolver = new ProviderResolver(Services.Providers);
            
            _targetManager = new TargetManager(Services.Targets);
            _builder = new Notification.Builder(providerResolver);
        }
        
        public async Task NotifyAsync(HttpRequest request)
        {
            await _targetManager.BroadcastAsync(
                _builder.Build(request)
            );
        }
    }
}

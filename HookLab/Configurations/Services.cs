using System.Collections.Generic;
using HookLab.Providers;
using HookLab.Providers.GitLab;
using HookLab.Targets;
using HookLab.Targets.Slack;

namespace HookLab.Configurations
{
    public static class Services
    {
        public static readonly IEnumerable<IProvider> Providers = new[]
        {
            new GitLabProvider()
        };

        public static readonly IEnumerable<ITarget> Targets = new[]
        {
            new SlackTarget(
                Configuration.Get(
                    Configuration.Keys.SlackWebhookUrl
                )
            )
        };
    }
}

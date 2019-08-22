using System.Collections.Generic;
using HookLab.Providers;
using HookLab.Providers.GitLab;
using HookLab.Targets;
using HookLab.Targets.Slack;
using HookLab.UserDictionaries;

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
                    Configuration.Keys.SlackBotToken
                ),
                new UserDictionaryManager(new IUserDictionary[]
                {
                    new GitLabSlackUserDictionary(
                        Configuration.Get(
                            Configuration.Keys.GitLabSlackUserDictionary
                        )
                    ), 
                })
            )
        };
    }
}

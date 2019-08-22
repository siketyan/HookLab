using System;

namespace HookLab.Configurations
{
    public static class Configuration
    {
        public static string Get(string key)
        {
            return Environment.GetEnvironmentVariable(key);
        }

        public static class Keys
        {
            public const string GitLabSlackUserDictionary = "GITLAB_SLACK_USER_DICTIONARY";
            public const string SlackBotToken = "SLACK_BOT_TOKEN";
        }
    }
}

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
            public const string SlackWebhookUrl = "SLACK_WEBHOOK_URL";
        }
    }
}

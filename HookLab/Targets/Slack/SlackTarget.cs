using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using HookLab.Models;
using HookLab.Targets.Slack.Messages;
using Newtonsoft.Json;

namespace HookLab.Targets.Slack
{
    public class SlackTarget : ITarget
    {
        private const string ContentType = "application/json";

        private readonly string _webhookUri;

        public SlackTarget(string webhookUri)
        {
            _webhookUri = webhookUri;
        }

        public async Task SendAsync(Notification notification)
        {
            using (var client = new HttpClient())
            {
                var json = JsonConvert.SerializeObject(
                    Message.Builder.Build(notification)
                );

                await client.PostAsync(
                    _webhookUri,
                    new StringContent(json, Encoding.UTF8, ContentType)
                );
            }
        }
    }
}

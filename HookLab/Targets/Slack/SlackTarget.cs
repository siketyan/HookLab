using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using HookLab.Models;
using HookLab.Targets.Slack.Messages;
using HookLab.UserDictionaries;
using Newtonsoft.Json;

namespace HookLab.Targets.Slack
{
    public class SlackTarget : ITarget
    {
        private const string Endpoint = "https://slack.com/api/chat.postMessage";
        private const string ContentType = "application/json";

        private readonly string _token;
        private readonly UserDictionaryManager _userDictionaryManager;

        public SlackTarget(string token, UserDictionaryManager userDictionaryManager)
        {
            _token = token;
            _userDictionaryManager = userDictionaryManager;
        }

        public async Task SendAsync(Notification notification)
        {
            using (var client = new HttpClient())
            {
                var json = JsonConvert.SerializeObject(
                    new Message.Builder(_userDictionaryManager, this).Build(notification)
                );
                
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _token);

                await client.PostAsync(
                    Endpoint,
                    new StringContent(json, Encoding.UTF8, ContentType)
                );
            }
        }
    }
}

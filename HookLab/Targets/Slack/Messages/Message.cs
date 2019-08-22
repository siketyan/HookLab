using HookLab.Models;
using HookLab.Targets.Slack.Messages.Blocks;
using HookLab.Targets.Slack.Messages.Elements.ActionElements;
using HookLab.Targets.Slack.Messages.Elements.ContextElements;
using HookLab.Targets.Slack.Messages.Elements.Texts;
using HookLab.UserDictionaries;
using Newtonsoft.Json;

namespace HookLab.Targets.Slack.Messages
{
    public abstract class Message
    {
        [JsonProperty("channel")]
        public string ChannelId { get; set; }

        [JsonProperty("as_user")]
        public bool AsUser { get; set; } = true;
        
        public class Builder
        {
            private readonly UserDictionaryManager _userDictionaryManager;
            private readonly SlackTarget _target;

            public Builder(UserDictionaryManager userDictionaryManager, SlackTarget target)
            {
                _userDictionaryManager = userDictionaryManager;
                _target = target;
            }
            
            public Message Build(Notification notification)
            {
                var message = BlocksMessage.Create(
                    ContextBlock.Create(
                        PlainTextContextElement.Create(notification.Header)
                    ),
                    SectionBlock.Create(
                        Markdown.Create($"*{notification.Title}*\n{notification.Content}")
                    ),
                    ActionsBlock.Create(
                        Button.Create("Open in browser", notification.Url)
                    )
                );

                message.ChannelId = _userDictionaryManager.Find(notification, _target);
                return message;
            }
        }
    }
}

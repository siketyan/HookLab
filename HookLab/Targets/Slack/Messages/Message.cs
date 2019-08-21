using HookLab.Models;
using HookLab.Targets.Slack.Messages.Blocks;
using HookLab.Targets.Slack.Messages.Elements.ActionElements;
using HookLab.Targets.Slack.Messages.Elements.ContextElements;
using HookLab.Targets.Slack.Messages.Elements.Texts;

namespace HookLab.Targets.Slack.Messages
{
    public abstract class Message
    {
        public static class Builder
        {
            public static Message Build(Notification notification)
            {
                return BlocksMessage.Create(
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
            }
        }
    }
}

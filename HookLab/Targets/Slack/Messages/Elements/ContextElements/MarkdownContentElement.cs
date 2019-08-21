using HookLab.Targets.Slack.Messages.Elements.Texts;
using Newtonsoft.Json;

namespace HookLab.Targets.Slack.Messages.Elements.ContextElements
{
    public class MarkdownContentElement : Markdown, IContextElement
    {
        [JsonProperty("type")]
        public new ContextElementType Type { get; } = ContextElementType.Markdown;

        public new static MarkdownContentElement Create(string content)
        {
            return Create<MarkdownContentElement>(content);
        }
    }
}

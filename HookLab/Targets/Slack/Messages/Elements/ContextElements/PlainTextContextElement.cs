using HookLab.Targets.Slack.Messages.Elements.Texts;
using Newtonsoft.Json;

namespace HookLab.Targets.Slack.Messages.Elements.ContextElements
{
    public class PlainTextContextElement : PlainText, IContextElement
    {
        [JsonProperty("type")] 
        public new ContextElementType Type { get; } = ContextElementType.PlainText;
        
        public new static PlainTextContextElement Create(string content, bool emoji = false)
        {
            return Create<PlainTextContextElement>(content, emoji);
        }
    }
}

using Newtonsoft.Json;

namespace HookLab.Targets.Slack.Messages.Elements.ContextElements
{
    public interface IContextElement
    {
        [JsonProperty("type")] 
        ContextElementType Type { get; }
    }
}

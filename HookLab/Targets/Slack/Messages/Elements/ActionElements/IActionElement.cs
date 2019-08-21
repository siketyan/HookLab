using Newtonsoft.Json;

namespace HookLab.Targets.Slack.Messages.Elements.ActionElements
{
    public interface IActionElement
    {
        [JsonProperty("type")]
        ActionElementType Type { get; }
    }
}

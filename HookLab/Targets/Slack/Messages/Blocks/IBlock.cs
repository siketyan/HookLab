using Newtonsoft.Json;

namespace HookLab.Targets.Slack.Messages.Blocks
{
    public interface IBlock
    {
        [JsonProperty("type")]
        BlockType Type { get; }
    }
}

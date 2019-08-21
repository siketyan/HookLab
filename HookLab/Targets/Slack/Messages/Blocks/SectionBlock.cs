using HookLab.Targets.Slack.Messages.Elements.Texts;
using Newtonsoft.Json;

namespace HookLab.Targets.Slack.Messages.Blocks
{
    public class SectionBlock : IBlock
    {
        [JsonProperty("type")]
        public BlockType Type { get; } = BlockType.Section;
        
        [JsonProperty("text")]
        public Text Text { get; set; }

        public static SectionBlock Create(Text text)
        {
            return new SectionBlock
            {
                Text = text
            };
        }
    }
}

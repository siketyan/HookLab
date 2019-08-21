using System.Collections.Generic;
using HookLab.Targets.Slack.Messages.Elements.ActionElements;
using Newtonsoft.Json;

namespace HookLab.Targets.Slack.Messages.Blocks
{
    public class ActionsBlock : IBlock
    {
        [JsonProperty("type")]
        public BlockType Type { get; } = BlockType.Actions;
        
        [JsonProperty("elements")]
        public IEnumerable<IActionElement> Elements { get; set; }

        public static ActionsBlock Create(params IActionElement[] elements)
        {
            return new ActionsBlock
            {
                Elements = elements
            };
        }
    }
}

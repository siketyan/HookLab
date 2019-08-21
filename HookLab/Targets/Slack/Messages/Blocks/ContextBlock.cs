using System.Collections.Generic;
using HookLab.Targets.Slack.Messages.Elements.ContextElements;
using Newtonsoft.Json;

namespace HookLab.Targets.Slack.Messages.Blocks
{
    public class ContextBlock : IBlock
    {
        [JsonProperty("type")]
        public BlockType Type { get; } = BlockType.Context;
        
        [JsonProperty("elements")]
        public IEnumerable<IContextElement> Elements { get; set; }

        public static ContextBlock Create(params IContextElement[] elements)
        {
            return new ContextBlock
            {
                Elements = elements
            };
        }
    }
}

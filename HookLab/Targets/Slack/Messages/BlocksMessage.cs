using System.Collections.Generic;
using HookLab.Targets.Slack.Messages.Blocks;
using Newtonsoft.Json;

namespace HookLab.Targets.Slack.Messages
{
    public class BlocksMessage : Message
    {
        [JsonProperty("blocks")]
        public IEnumerable<IBlock> Blocks { get; set; }

        public static BlocksMessage Create(params IBlock[] blocks)
        {
            return new BlocksMessage
            {
                Blocks = blocks
            };
        }
    }
}

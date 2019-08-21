using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using HookLab.Models;

namespace HookLab.Targets
{
    public class TargetManager
    {
        private readonly IEnumerable<ITarget> _targets;

        public TargetManager(IEnumerable<ITarget> targets)
        {
            _targets = targets;
        }

        public async Task BroadcastAsync(Notification notification, bool continueOnException = true)
        {
            foreach (var target in _targets)
            {
                try
                {
                    await target.SendAsync(notification);
                }
                catch (Exception e)
                {
                    if (!continueOnException)
                    {
                        throw;
                    }
                    
                    Console.WriteLine(e);
                }
            }
        }
    }
}

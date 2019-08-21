using System.Threading.Tasks;
using HookLab.Models;

namespace HookLab.Targets
{
    public interface ITarget
    {
        Task SendAsync(Notification notification);
    }
}

using HookLab.Models;
using HookLab.Targets;

namespace HookLab.UserDictionaries
{
    public interface IUserDictionary
    {
        string Find(Notification notification);
        bool Supports(Notification notification, ITarget target);
    }
}

using HookLab.Models;
using Microsoft.AspNetCore.Http;

namespace HookLab.Providers
{
    public interface IProvider
    {
        Notification Provide(HttpRequest request);
        bool Supports(HttpRequest request);
    }
}

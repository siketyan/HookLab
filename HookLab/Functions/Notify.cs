using System;
using System.Threading.Tasks;
using System.Web.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace HookLab.Functions
{
    // ReSharper disable once UnusedMember.Global
    public static class Notify
    {
        [FunctionName("Notify")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "post")]
            HttpRequest request,
            ILogger logger
        )
        {
            try
            {
                await new Notifier().NotifyAsync(request);
            }
            catch (Exception e)
            {
                logger.LogError(e, "An exception occured during the invocation.");
                return new InternalServerErrorResult();
            }
            
            return new OkResult();
        }
    }
}

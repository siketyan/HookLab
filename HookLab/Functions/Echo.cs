using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace HookLab.Functions
{
    public static class Echo
    {
        [FunctionName("Echo")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)]
            HttpRequest req,
            ILogger log
        )
        {
            log.LogInformation($"An event was reported from GitLab: {req.Headers["X-Gitlab-Event"]}");
            log.LogInformation(await new StreamReader(req.Body).ReadToEndAsync());

            return new OkResult();
        }
    }
}

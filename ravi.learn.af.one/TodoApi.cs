using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using ravi.learn.af.one.Models;

namespace ravi.learn.af.one
{
    public static class TodoApi
    {
        private static IList<TodoModel> items = new List<TodoModel>();

        [FunctionName("CreateTodo")]
        public static async Task<IActionResult> CreateTodo(
            [HttpTrigger(AuthorizationLevel.Anonymous, "post", Route = "todo")] HttpRequest req, ILogger log)
        {
            log.LogInformation("Creating a new todo item");

            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            var input = JsonConvert.DeserializeObject<TodoCreateModel>(requestBody);

            var todo = new TodoModel { Description = input.Description}
            ;
            items.Add(todo);

            return  new OkObjectResult(todo);
        }

        public static async Task<IActionResult> GetTodoById([HttpTrigger])
    }
}

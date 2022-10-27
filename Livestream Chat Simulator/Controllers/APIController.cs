using Livestream_Chat_Simulator.Classes;
using Livestream_Chat_Simulator.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Livestream_Chat_Simulator.Controllers
{
    public class APIController : Controller
    {
        [HttpPost]
        [Route("API/GetRandomChatResponse/")]
        public string GetRandomChatResponse([FromBody] Dictionary<string, string> foo)
        {


            DateTime startTime = DateTime.Now;
            dynamic input = (dynamic)foo;
            _ = foo.TryGetValue("Mode", out string mode);
            _ = foo.TryGetValue("Topics", out string topics);

            ChatResponseViewModel chatResponseViewModel = new ChatResponseViewModel();
            chatResponseViewModel.UserName = RandomData.GetRandomName();
            chatResponseViewModel.Response = RandomData.GetRandomResponse(mode, topics, chatResponseViewModel.UserName);
            chatResponseViewModel.TimeStamp = DateTime.UtcNow;

            return JsonConvert.SerializeObject(chatResponseViewModel);
        }
    }
}

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
        private const string AvatarFolder = "/images/avatars/";

        [HttpPost]
        [Route("API/GetRandomChatResponse/")]
        public string GetRandomChatResponse([FromBody] Dictionary<string, string> foo)
        {
            Random random = new Random();
            DateTime startTime = DateTime.Now;
            dynamic input = (dynamic)foo;
            _ = foo.TryGetValue("Mode", out string mode);
            _ = foo.TryGetValue("Topics", out string topics);

            List<User> users = UserFactory.GetUsers(AvatarFolder);
            User currentUser = users[random.Next(users.Count)];

            ChatResponseViewModel chatResponseViewModel = new ChatResponseViewModel();
            chatResponseViewModel.User = currentUser;
            chatResponseViewModel.Response = RandomData.GetRandomResponse(mode, topics, "blah blah");
            chatResponseViewModel.TimeStamp = DateTime.UtcNow;

            return JsonConvert.SerializeObject(chatResponseViewModel);
        }
    }
}

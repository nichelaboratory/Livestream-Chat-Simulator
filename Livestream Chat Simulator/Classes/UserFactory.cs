using System.Collections.Generic;
using Livestream_Chat_Simulator.Models;

namespace Livestream_Chat_Simulator.Classes
{
    public static class UserFactory
    {
        public static List<User> GetUsers(string avatarFolder)
        {
            List<User> users = new List<User>();

            User user = new User();
            user.Name = "Towa";
            user.HTMLColour = "#A83135";
            user.AvatarImageUrl = avatarFolder + "Towa-Avatar.jpg";
            users.Add(user);

            user = new User();
            user.Name = "Uzuki";
            user.HTMLColour = "#F95D17";
            user.AvatarImageUrl = avatarFolder + "Uzuki-Avatar.jpg";
            users.Add(user);

            user = new User();
            user.Name = "Rena";
            user.HTMLColour = "#6057B1";
            user.AvatarImageUrl = avatarFolder + "Rena-Avatar.jpg";
            users.Add(user);

            user = new User();
            user.Name = "Asuna";
            user.HTMLColour = "#C0C000";
            user.AvatarImageUrl = avatarFolder + "Asuna-Avatar.jpg";
            users.Add(user);

            return users;
        }

    }
}

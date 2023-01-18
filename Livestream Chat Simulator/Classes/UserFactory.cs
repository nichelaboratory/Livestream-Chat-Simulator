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

            user = new User();
            user.Name = "Misaki";
            user.HTMLColour = "#800080";
            user.AvatarImageUrl = avatarFolder + "Misaki-Avatar.jpg";
            users.Add(user);

            user = new User();
            user.Name = "Yayoi";
            user.HTMLColour = "#21F9FB";
            user.AvatarImageUrl = avatarFolder + "Yayoi-Avatar.jpg";
            users.Add(user);

            user = new User();
            user.Name = "Kirika";
            user.HTMLColour = "#33ADF3";
            user.AvatarImageUrl = avatarFolder + "Kirika_Avatar.jpg";
            users.Add(user);

            user = new User();
            user.Name = "Kizuna";
            user.HTMLColour = "#85C2CB";
            user.AvatarImageUrl = avatarFolder + "Kizuna-Avatar.jpg";
            users.Add(user);

            user = new User();
            user.Name = "Rin";
            user.HTMLColour = "#17D8FB";
            user.AvatarImageUrl = avatarFolder + "Rin-Avatar.jpg";
            users.Add(user);

            user = new User();
            user.Name = "Kazuha";
            user.HTMLColour = "#E33939";
            user.AvatarImageUrl = avatarFolder + "Kazuha-Avatar.jpg";
            users.Add(user);

            user = new User();
            user.Name = "Iori";
            user.HTMLColour = "#B349A5";
            user.AvatarImageUrl = avatarFolder + "Iori-Avatar.jpg";
            users.Add(user);

            user = new User();
            user.Name = "Mytyl";
            user.HTMLColour = "#86872F";
            user.AvatarImageUrl = avatarFolder + "Mytyl-Avatar.jpg";
            users.Add(user);

            return users;
        }

    }
}

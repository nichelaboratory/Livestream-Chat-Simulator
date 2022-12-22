using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Faker;

namespace Livestream_Chat_Simulator.Classes
{

    public static class RandomData
    {
        public static string[] NamingWords = { "Princess", "Diamond", "Luna", "Lunar", "Chef", "Rabbit", "Neko", "Kek", "Killa", "Domino", "Fish", "Chips", "Liar", "Bubba", "Bunny", "Rabbit", "Neko", "Kek", "Killa", "Domino", "Wool", "Shaver", "Knight", "Hot", "Minecraft", "Lotus", "Ford", "Nut", "Nutz", "Pinky", "London", "Paris", "Cheese", "Cheezer", "Swiss", "Dynamite", "Dynamo", "Orange", "Fibber", "Ur", "Mom", "UrMom", "Sucks", "Blocks", "Cox", "Cock", "Restricted", "Private", "Laugh", "Troller", "Trolley", "Troll", "Trollz", "Anonymous", "Banker", "Tea", "Photo", "Selfie", "Prik", "Nob", "Noob", "NoobTuber", "N00b", "Anonymus", "April", "Christmas", "Amerika", "Ferrari", "Subaru", "Wolf", "Wolfie", "Powered", "Zipped", "Speed", "Group", "Think", "Thinker", "Thik", "Offensive", "Dirt", "Bike", "Rider", "Easy", "Wood", "Heaven", "Heavenly", "Thicc", "Kek", "Kik", "Bizarre", "Cool", "Cool", "Joe", "Hood", "Hooza", "Hoodz", "Blakey", "Weird", "Wierd", "Zzz", "Aaa", "Ba", "BC", "Weirdo", "C00l", "Leet", "L33t", "Coder", "Conner", "Connor", "Cactus", "Lily", "Tree", "Wooden", "Oscoa", "Osca", "find", "Nerd", "Geek", "Nerdz", "Biscuit", "Cookie", "Cookee" };
        public static string[] CannedResponses = { "Lolllllllll", "Sage", "Ban hammer needed", "Anyone else here coz theyr banned from T%", "Loooooooooooooooooolllll", "Ur funny man", "Imma so high right now", "I'm totally lit", "Has anybody eaten yet", "When does this stream finish", "I'm soooo hot 4 U", "Love ur accent", "I wanna quit my job and become a coder", "Coders are the new rock stars", "P% is really l33t", "Fish", "Chips", "How much RedBull u drank", "This ain't no chillstream", "Do a dance", "I thought this stuff only happened on T%", "Neko", "Kek", "Top Kek", "F% gonna have a meltdown man", "Woah", "This makes me wanna put on a dress", "I get what ur sayin' man", "Neat", "I wanna make a Minecraft mod", "Hackerzz", "L33t", "P% is sooooo hard", "P% does my head in", "Pinky", "London", "Paris", "Cheese", "Cheezer", "Swiss", "Dynamite", "Any vegans in the house", "F% sooo funny", "This channel is sh1t", "Ur", "Mom", "This channel is the dogs", "This channel is soooo lame", "Blocks", "Cox", "Cook", "Restricted", "Suck my dic", "I laughed", "F% got me", "P% is sooooo hard I don't know if I should continue or just not", "Anybody else done a code camp", "Can u do more hacking tutorials", "Trying to keep up with the chat", "People is mad today", "Gonna smoke me so weed later", "Photo", "Selfie", "My boss is a prick", "Nob", "Noob", "NoobTuber", "N00b", "Anonymus", "April", "Christmas", "Amerika", "Ferrari", "Subaru", "Wolf", "Wolfie", "Powered", "Zipped", "Speed", "Group", "Think", "Thinker", "Thik", "Offensive", "Dirt", "Bike", "Rider", "Easy", "Wood", "Heaven", "Heavenly", "Thicc", "Kek", "Kik", "Bizarre", "Cool", "Cool", "Joe", "Hood", "Hooza", "Hoodz", "Blakey", "Weird", "Wierd", "Zzz", "Aaa", "Ba", "BC", "Cum", "C00l", "Leet", "L33t", "Coder", "Conner", "Connor", "Cactus", "Lily", "Tree", "Wooden", "Oscoa", "P% makes me sad", "F% should stream tutorials on Twitch", "Like Like Like", "Awesome as always", "He speaks the truth", "Listen to this man", "F% if I had any money I'd sent it to F% straight away", "F% shud stream more often", "Wicked", "Anyone else hate coding tests?", "Coding is such a terrible career anyway", "Wish I could be a streamer", "Start naming names", "Anybody else eating M% at 2pm", "Anyone else eating M% at 6am", "Who else likes pizza for breakfast?", "My code camp was a waste of money", "This guy's videos are better value then a code camp", "How do I donate?", "Send this guy money.", "Coders are the new rockstars.", "U need a green screen dude", "Great chill stream, I have this one when I'm doing yoga", "Fantastic advice, thanx" };
        //P%
        public static string[] ProgrammingLanguages = { "C#", "ASP.NET", "MVC", ".NET Core", "SQL", "Python", "Unity", "Vue.js", "VBA", "MySQL", "SQL Server", "C++", "Arduino", "C", "Arduino Uno" };
        //F%
        public static string[] FirstPerson = { "You", "U" };
        //T%
        public static string[] TechPlatforms = { "TikTok", "Twitch", "Facebook", "Reddit", "Vimeo", "Slack", "Fortnite", "The Metaverse" };

        //M%
        public static string[] Meals = { "breakfast", "lunch", "snacks", "PoP Tarts", "toast", "Cheetos", "hummous", "pizza", "&#127856;", "&#129386;", "&#129472;", "&#127829;", "eggs", "pies", "sodas", "ramen noodles", "yaki soba" };

        //S%
        public static List<string> SubjectAreas = new List<string>() { "Tech", "Technology", "Programming", "Coding", "Software development" };

        //I%
        public static string[] TechInfluencers = { "4Chan", "DaniWeb", "StackOverflow", "Coding with Brett" };

        public static string[] ChillPhrases = { "Chill, man", "U go girl", "Wow", "This guy's on point", "Chillax", "Relax", "Calm down" };

        public static string[] Insults = { "is a complete tool", "sucks", "is annoying", "is really fugly", "is horrible", "sux", "gonna suck on a lemon", "is so stupid", "is lamer", "is lame", "is l33tr", "totally lit", "is a waste of space", "is awful", "is sooooo dumb", "is the worst person ever", "is such an npc", "talks trash" };
        public static string[] Emojis = { "&#128508;", "&#128512;", "&#128151;", "&#128507;", "&#128509;", "&#128511;", "&#128512;", "&#128513;", "&#128514;", "&#128515;", "&#128516;", "&#128517;", "&#128508;", "&#128512;", "&#128151;", "&#128507;", "&#128509;", "&#128511;", "&#128512;", "&#128513;", "&#128514;", "&#128515;", "&#128516;", "&#128517;", "&#128523;", "&#128525;", "&#128526;", "&#128527;", "&#128541;", "&#128556;", "&#128561;", "&#128567;", "&#128576;", "&#128585;", "&#129318;", "&#129326;", "&#129351;", "&#9748;", "&#9940;", "&#127752;", "&#127755;", "&#127797;", "&#127812;", "&#127813;", "&#127828;", "&#127829;", "&#128013;", "&#128025;", "&#128039;", "&#128041;", "&#128064;", "&#128084;", "&#128125;", "&#128163;", "&#128161;", "&#128169;", "&#128169;", "&#128173;", "&#128266;", "&#128187;", "&#128186;", "&#128184;", "&#128199;", "&#128225;", "&#129472;", "&#129497;", "&#129428;", "&#129425;", "&#129369;", "&#129315;", "&#129314;", "&#128760;" };

        public static List<string> UsedNames = new List<string>();

        public static string GetNamingWord()
        {
            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            int i = rnd.Next(0, NamingWords.Length);
            return NamingWords[i];
        }

        public static string GetRandomName()
        {
            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            int rnd1 = rnd.Next(0, 16);
            string name = string.Empty;

            switch (rnd1)
            {
                case 0:
                    name = Faker.Name.First();
                    break;
                case 1:
                    name = Faker.Name.Middle();
                    break;
                case 2:
                    name = Faker.Name.Last();
                    break;
                case 3:
                    name = Faker.Name.FullName();
                    break;
                case 4:
                    name = Faker.Name.First();
                    break;
                case 5:
                    name = Faker.Name.First();
                    break;
                case 6:
                    name = Faker.Internet.UserName();
                    break;
                case 7:
                    name = Faker.Internet.UserName();
                    break;
                case 8:
                    name = Faker.RandomNumber.Next(1234567, 9999999).ToString();
                    break;
                case 9:
                    name = Faker.Currency.Name();
                    break;
                case 10:
                    name = GetNamingWord() + "_" + Faker.RandomNumber.Next(1234, 9999).ToString();
                    break;
                case 11:
                    name = GetNamingWord() + GetNamingWord();
                    break;
                case 12:
                    name = GetNamingWord() + GetNamingWord() + Faker.RandomNumber.Next(10, 99).ToString();
                    break;
                case 13:
                    name = Faker.Identification.UsPassportNumber();
                    break;
                case 14:
                    name = Faker.Address.Country() + GetNamingWord();
                    break;
                case 15:
                    name = GetNamingWord() + Faker.Address.City();
                    break;
            }

            rnd1 = rnd.Next(0, 10);

            switch (rnd1)
            {
                case 0:
                    name = name.ToLower();
                    break;
                case 1:
                    name = name.ToUpper();
                    break;
                case 2:
                    name = name + "-" + Faker.RandomNumber.Next(123, 5678).ToString();
                    break;
                case 3:
                    name = name.ToUpper() + Faker.RandomNumber.Next(0, 99).ToString();
                    break;
            }

            rnd1 = rnd.Next(0, 20);

            switch (rnd1)
            {
                case 0:
                    name = Faker.Name.Prefix() + " " + name;
                    break;
                case 1:
                    name = new string(name.Reverse().ToArray());
                    break;
            }

            return name;
        }

        public static string GetRandomResponse(string mode, string topics, string userName)
        {
            string response = string.Empty;

            UsedNames.Add(userName);

            if (!string.IsNullOrEmpty(topics))
            {
                string[] topicsList = topics.Split(',');
                foreach (string topic in topicsList) { SubjectAreas.Add(topic.Trim()); }
            }

            if (mode.ToUpper() == "ANGRY")
            {
                response = GetRandomAngryResponse();
            }
            if (mode.ToUpper() == "HARDWARE")
            {
                response = GetRandomHardwareResponse();
            }

            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            int i = rnd.Next(0, ProgrammingLanguages.Length);
            response = response.Replace("P%", ProgrammingLanguages[i]);
            i = rnd.Next(0, FirstPerson.Length);
            response = response.Replace("F%", FirstPerson[i]);
            i = rnd.Next(0, TechPlatforms.Length);
            response = response.Replace("T%", TechPlatforms[i]);
            i = rnd.Next(0, TechInfluencers.Length);
            response = response.Replace("I%", TechInfluencers[i]);
            i = rnd.Next(0, SubjectAreas.Count);
            response = response.Replace("S%", SubjectAreas[i]);
            i = rnd.Next(0, Meals.Length);
            response = response.Replace("M%", Meals[i]);

            i = rnd.Next(0, 20);
            if (i > 16) { response = response.ToLower(); }

            return response;
        }

        public static string GetRandomAngryResponse()
        {
            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            int i = rnd.Next(0, CannedResponses.Length);
            string response = CannedResponses[i];
            int rnd1 = rnd.Next(0, 12);

            switch (rnd1)
            {
                case 0:
                    response = GenerateRandomTutorialsPhrase();
                    break;
                case 1:
                    response = GenerateRandomInsult();
                    break;
                case 2:
                    response = GenerateRandomChillPhrase();
                    break;
                case 3:
                    if (UsedNames.Count > 5)
                    {
                        response = GenerateRandomFlame();
                    }
                    break;
                case 4:
                    response = GenerateGenericResponse();
                    break;
                case 5:
                    response = GenerateRandomEmojiString();
                    break;
            }

            response = PostModifyResponse(response);
            return response;
        }

        public static string GetRandomHardwareResponse()
        {
            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            int i = rnd.Next(0, CannedResponses.Length);
            string response = CannedResponses[i];
            int rnd1 = rnd.Next(0, 12);

            switch (rnd1)
            {
                case 0:
                    response = GenerateRandomTutorialsPhrase();
                    break;
                case 1:
                    response = GenerateRandomInsult();
                    break;
                case 2:
                    response = GenerateRandomChillPhrase();
                    break;
                case 3:
                    if (UsedNames.Count > 5)
                    {
                        response = GenerateRandomFlame();
                    }
                    break;
                case 4:
                    response = GenerateGenericResponse();
                    break;
                case 5:
                    response = GenerateRandomEmojiString();
                    break;
                case 6:
                    int j = rnd.Next(0, 10);
                    switch (j)
                    {
                        case 0:
                            response = "F% da go to man for S% videos";
                            break;
                        case 1:
                            response = "Without your videos I wouldn't know how to start with S%";
                            break;
                        case 2:
                            response = "I found S% soooo difficult until I found ur channel";
                            break;
                        case 3:
                            response = "Is S% dangerous? It looks risky to me";
                            break;
                        case 4:
                            response = "Is S% difficult?";
                            break;
                        case 5:
                            response = "I need to try this but I gotta eat M%";
                            break;
                        case 6:
                            response = "F% da man on anything S%";
                            break;
                        case 7:
                            response = "I'm getting back into S% after a couple of years chillin'";
                            break;
                        case 8:
                            response = "S% is tricky as hell";
                            break;
                        case 9:
                            response = "I need better glasses for this";
                            break;
                    }
                    break;
            }

            response = PostModifyResponse(response);
            return response;
        }

        private static string GenerateRandomEmojiString()
        {
            string response = string.Empty;
            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            int i = rnd.Next(0, Emojis.Length);
            for (int j = 0; j < rnd.Next(1, 20); ++j) { response += Emojis[i]; }
            return response;
        }

        private static string GenerateRandomChillPhrase()
        {
            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            int i = rnd.Next(0, ChillPhrases.Length);
            return ChillPhrases[i];
        }

        private static string GenerateRandomTutorialsPhrase()
        {
            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            int i = rnd.Next(0, 10);

            switch (i)
            {
                case 0:
                    return "F% should make more P% tutorials";
                case 1:
                    return "F% make the most engaging P% lessons";
                case 2:
                    return "F% are so good at explaining P%";
                case 3:
                    return "P% is so awful to learn but you have really helped me a lot";
                case 4:
                    return "F% rock man";
                case 5:
                    return "F% should make more P% vids";
                case 6:
                    return "F% should do more P% videos";
                case 7:
                    return "F% should focus on making more P% videos";
                case 8:
                    return "F% should make more P% tutorials";
                default:
                    return "F% needs make more P% tutorials";
            }


        }

        private static string GenerateRandomInsult()
        {
            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            int i = rnd.Next(0, Insults.Length);
            int j = rnd.Next(0, 10);
            if (j > 4)
            {
                return "I find P% " + Insults[i];
            }
            else
            {
                return "I find T% " + Insults[i];
            }
        }

        private static string GenerateGenericResponse()
        {
            string response = string.Empty;
            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            int i = rnd.Next(0, 24);
            if (i == 0) { response = "Greetings from " + Faker.Country.Name(); }
            if (i == 1) { response = "Greetings from " + Faker.Address.City(); }
            if (i == 2) { response = "Hi from " + Faker.Country.Name(); }
            if (i == 3) { response = Faker.Country.Name() + " in da house"; }
            if (i == 4) { response = "Coding is soooo hard in " + Faker.Country.Name() + " cuz there no jobs"; }
            if (i == 5) { response = "Coding is sooo hard in " + Faker.Country.Name() + " goz the internet is sooo slow"; }
            if (i == 6) { response = "Anybody else from " + Faker.Address.City(); }
            if (i == 7) { response = "Anybody else from I%"; }
            if (i == 8) { response = "Anyone else from I%?"; }
            if (i == 9) { response = "Anyone else from " + Faker.Country.Name(); }
            if (i == 10) { response = "Anyone else from " + Faker.Address.City() + "?"; }
            if (i == 11) { response = "Anyone else find P% is rock hard?"; }
            if (i == 12) { response = "Coding is soooo hard in " + Faker.Country.Name() + " cuz there no books about P%"; }
            if (i == 13) { response = "Coding is so hard in " + Faker.Country.Name() + " cuz there no P% jobs"; }
            if (i == 14) { response = "I need to learn this. There are so many P% jobs in " + Faker.Country.Name(); }
            if (i == 15) { response = "I need to learn this. There are a ton of P% jobs in " + Faker.Address.City(); }

            return response;
        }

        private static string GenerateRandomFlame()
        {
            if (UsedNames.Count == 0) { return ""; }
            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            string response = string.Empty;
            int i = rnd.Next(0, UsedNames.Count);
            response = UsedNames[i];
            i = rnd.Next(0, Insults.Length);
            response += " " + Insults[i];
            UsedNames.RemoveRange(0, 1);
            return response;
        }

        private static string PostModifyResponse(string response)
        {
            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            int rnd1 = rnd.Next(0, 15);
            int rnd2 = rnd.Next(1, 7);
            int j = rnd.Next(0, Emojis.Length);
            switch (rnd1)
            {
                case 0:
                    response += new string('!', rnd2);
                    break;
                case 1:
                    response += new string('?', rnd2);
                    break;
                case 2:
                    response += new string('.', rnd2);
                    break;
                case 3:
                    response += ".";
                    break;
                case 4:
                    response += " " + Emojis[j];
                    break;
                case 5:
                    response += " " + Emojis[j] + Emojis[j];
                    break;
                case 6:
                    response += " " + Emojis[j] + Emojis[j] + Emojis[j];
                    break;
                case 7:
                    response += " " + Emojis[j] + Emojis[j] + Emojis[j] + Emojis[j];
                    break;
                case 8:
                    response += Emojis[j];
                    break;
                case 9:
                    response = Emojis[j] + " " + response + " " + Emojis[j];
                    break;
                case 10:
                    response += Emojis[j] + " " + Emojis[j];
                    break;
                case 11:
                    response = response.ToUpper();
                    break;
            }

            return response;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Faker;
using Livestream_Chat_Simulator.Models;

namespace Livestream_Chat_Simulator.Classes
{

    public static class RandomData
    {
        public static string[] NamingWords = { "Princess", "Diamond", "Luna", "Lunar", "Chef", "Rabbit", "Neko", "Kek", "Killa", "Domino", "Fish", "Chips", "Liar", "Bubba", "Bunny", "Rabbit", "Neko", "Kek", "Killa", "Domino", "Wool", "Shaver", "Knight", "Hot", "Minecraft", "Lotus", "Ford", "Nut", "Nutz", "Pinky", "London", "Paris", "Cheese", "Cheezer", "Swiss", "Dynamite", "Dynamo", "Orange", "Fibber", "Ur", "Mom", "UrMom", "Sucks", "Blocks", "Cox", "Cock", "Restricted", "Private", "Laugh", "Troller", "Trolley", "Troll", "Trollz", "Anonymous", "Banker", "Tea", "Photo", "Selfie", "Prik", "Nob", "Noob", "NoobTuber", "N00b", "Anonymus", "April", "Christmas", "Amerika", "Ferrari", "Subaru", "Wolf", "Wolfie", "Powered", "Zipped", "Speed", "Group", "Think", "Thinker", "Thik", "Offensive", "Dirt", "Bike", "Rider", "Easy", "Wood", "Heaven", "Heavenly", "Thicc", "Kek", "Kik", "Bizarre", "Cool", "Cool", "Joe", "Hood", "Hooza", "Hoodz", "Blakey", "Weird", "Wierd", "Zzz", "Aaa", "Ba", "BC", "Weirdo", "C00l", "Leet", "L33t", "Lazy bitch", "Conner", "Connor", "Cactus", "Lily", "Tree", "Fake", "plastic", "Nerd", "Geek", "Nerdz", "Biscuit", "Cookie", "Cookee" };
        public static string[] CannedResponses = { "Lolllllllll", "This is not interesting", "Ban hammer needed", "Anyone else here coz theyr banned from T%", "Loooooooooooooooooolllll", "Ur funny man", "Imma so high right now", "I'm totally lit", "Has anybody eaten yet", "When does this stream finish", "I'm soooo hot 4 U", "Love ur accent", "I wanna quit my job and become a scalper", "Dolls are so awesome are we not?", "P% is really l33t", "Fish", "Chips", "How much RedBull u drank", "This ain't no chillstream", "Do a dance", "I thought this stuff only happened on T%", "Neko", "When I watch this I forget about my sewing machine injuries", "You make me forget about the world and its problems", "F% gonna have a meltdown man", "Woah", "This makes me wanna put on a dress", "I get what ur sayin' man", "Neat", "I wanna 3D print an entire boyfriend", "I want to change my gender", "I need to swap outfits ASAP", "I can never remember where I left my A%", "My A% should arrive today", "My A% should arrive tomorrow", "London", "Paris", "Cheese", "Cheezer", "Swiss", "Dynamite", "Any vegans in the house", "F% sooo funny", "This is a lonely time of year", "This is a bad time of year for me", "This is the worst time of year for me", "This channel is the dogs", "This channel is soooo lame", "Blocks", "I'm having a bad hair day", "Somebody has stolen my A%", "Restricted", "I'm not following this today", "I laughed", "F% got me", "P% is sooooo hard I don't know if I should continue or just not", "Anybody else done a code camp", "Can u do more hacking tutorials", "Trying to keep up with the chat", "People is mad today", "Gonna smoke me some weed later", "Photo", "Selfie", "April", "Christmas", "Amerika", "Ferrari", "My joints ache today", "My neck aches today", "My eyes fell out while I was asleep", "This wig is really tight", "My elbows feel really creaky today", "Why aren't there any male dolls in our house?", "Why aren't there any boy dolls in our house?", "Think", "Thinker", "Thik", "Offensive", "Dirt", "Bike", "Rider", "Easy", "Wood", "Heaven", "Heavenly", "Thicc", "Are my lips too small?", "Do my lips look too small?", "Do you think my faceup is hot?", "Weird", "Wierd", "Zzz", "Cactus", "Lily", "Tree", "Wooden", "Oscoa", "P% makes me sad", "F% should stream tutorials on Twitch", "Like Like Like", "Awesome as always", "He speaks the truth", "Listen to this man", "F% if I had any money I'd sent it to F% straight away", "F% shud stream more often", "Wicked", "Anyone else hate coding tests?", "Coding is such a terrible career anyway", "Wish I could be a streamer", "Start naming names", "Anybody else eating M% at 2pm", "Anyone else eating M% at 6am", "Who else likes pizza for breakfast?", "My code camp was a waste of money", "This guy's videos are so good", "How do I donate?", "Send this guy money.", "Doll collectors are the new rockstars.", "U need a green screen dude", "Great chill stream, I have this one when I'm doing H%", "Fantastic advice, thanx", "I would not be seen dead wearing that" };
        //P%
        public static string[] DollTypes = { "dolls", "vinyl dolls", "ball jointed dolls", "ball-jointed dolls", "BJDs", "dollies", "anime dolls" };
        //F%
        public static string[] FirstPerson = { "You", "U" };
        //T%
        public static string[] TechPlatforms = { "TikTok", "Twitch", "Facebook", "Reddit", "Vimeo", "Slack", "Fortnite", "The Metaverse", "KawaiiDolls", "DollTube", "Dollbook" };

        //V%
        public static string[] AuctionVendors = { "Mandarake", "eBay", "eBay", "Facebook Marketplace", "eBay", "Yahoo Auctions" };

        //H%
        public static string[] Hobbies = { "yoga", "bitching about my friends behind their backs", "sewing", "sleeping", "dining out", "borrowing my friends' clothes", "spending senpai's money", "dreaming about Kaito", "dreaming about Len", "falling over on my face", "looking bored" };

        //M%
        public static string[] Meals = { "breakfast", "lunch", "snacks", "PoP Tarts", "toast", "Cheetos", "hummous", "pizza", "&#127856;", "&#129386;", "&#129472;", "&#127829;", "eggs", "pies", "sodas", "ramen noodles", "yaki soba" };

        //O%
        public static string[] Occupations = { "Modelling", "Blogging", "Fashion modelling", "Being a Vocaloid", "Being an influencer" };

        //S%
        public static List<string> SubjectAreas = new List<string>() { "Toys", "Collectibles", "Collecting", "Doll collecting", "Face-ups", "Unboxings", "Dress-ups" };

        //A% 
        public static string[] Accessories = { "hairbrush", "bodysuit", "Shoes Boutique heels", "wig cap", "wig", "pointing hands", "peace hands", "default eyes", "angry eyes", "small bust", "hairband", "cats ears", "nyan hands", "flat shoes", "Mary-Jane shoes", "socks", "loose socks", "necklace", "pantsu", "panties", "lingerie", "knickers", "hair pins", "bracelets", "thigh-high socks", "earrings", "kitty ears", "neko ears", "rabbit ears", "cute pantsu" };

        //I%
        public static string[] DollInfluencers = { "Miku Hatsune", "Kizuna AI", "Doll Dreaming Forum", "DenOfAngels", "Kawaii Dolls", "KawaiiDolls.TV"};

        public static string[] ChillPhrases = { "Chill, girl", "U go girl", "Wow", "This guy's on point", "Chillax", "Relax", "Calm down", "Don't have a meltdown" };

        public static string[] Insults = { "is a trashy whore", "is really thicc", "is so stupid sometimes", "is annoying", "is really fugly", "is horrible", "sux", "is not my friend today", "is so stupid", "once stole my boyfriend", "slept with my bff", "is lamer", "is lame", "is l33tr", "totally lit", "are a waste of space", "is awful", "are sooooo dumb", "is the worst person ever", "is such an npc", "talks trash", "and I are not speaking today", "is a fat cow", "is so thicc", "wears skirts so short you can see her pantsu", "is totally clueless", "stole my last boyfriend", "snores so loudly", "isn't as hot as she thinks she is", "once bodyshamed me", "spends all day reading magazines", "spends all day reading her horoscopes", "is a total attention whore", "talks about everybody behind their backs", "is a terrible gossip"};
        public static string[] Praise = { "is the best person in the entire world", "is the best friend you could ever wish for", "has the most amazing eyes", "has the most amazing outfits", "is really pretty", "is so cute", "is really hot", "really helped me when I was at my lowest point" };

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
            string name = GetSensibleCountryName();// string.Empty;

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
                    name = GetSensibleCountryName() + GetNamingWord();
                    break;
                case 15:
                    name = GetNamingWord() + GetSensibleCityName();
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

        public static string GetRandomResponse(string mode, string topics, User user)
        {
            string response = string.Empty;

            UsedNames.Add(user.Name);

            if (!string.IsNullOrEmpty(topics))
            {
                string[] topicsList = topics.Split(',');
                foreach (string topic in topicsList) { SubjectAreas.Add(topic.Trim()); }
            }

            if (mode.ToUpper() == "ANGRY")
            {
                response = GetRandomAngryResponse();
            }
            if (mode.ToUpper() == "DOLLS")
            {
                response = GetRandomDollResponse();
            }

            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            int i = rnd.Next(0, DollTypes.Length);
            response = response.Replace("P%", DollTypes[i]);
            i = rnd.Next(0, FirstPerson.Length);
            response = response.Replace("F%", FirstPerson[i]);
            i = rnd.Next(0, TechPlatforms.Length);
            response = response.Replace("T%", TechPlatforms[i]);
            i = rnd.Next(0, DollInfluencers.Length);
            response = response.Replace("I%", DollInfluencers[i]);
            i = rnd.Next(0, SubjectAreas.Count);
            response = response.Replace("S%", SubjectAreas[i]);
            i = rnd.Next(0, Meals.Length);
            response = response.Replace("M%", Meals[i]);
            i = rnd.Next(0, AuctionVendors.Length);
            response = response.Replace("V%", AuctionVendors[i]);
            i = rnd.Next(0, Accessories.Length);
            response = response.Replace("A%", Accessories[i]);
            i = rnd.Next(0, Occupations.Length);
            response = response.Replace("O%", Occupations[i]);
            i = rnd.Next(0, Hobbies.Length);
            response = response.Replace("H%", Hobbies[i]);

            i = rnd.Next(0, 20);
            if (i > 16) { response = response.ToLower(); }

            return response;
        }

        public static string GetRandomAngryResponse()
        {
            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            int i = rnd.Next(0, CannedResponses.Length);
            string response = CannedResponses[i];
            int rnd1 = rnd.Next(0, 13);

            switch (rnd1)
            {
                case 0:
                    response = GenerateRandomTutorialsPhrase();
                    break;
                case 1:
                    response = GenerateRandomInsult();
                    break;
                case 2:
                    response = GenerateRandomPraise();
                    break;
                case 3:
                    response = GenerateRandomChillPhrase();
                    break;
                case 4:
                    if (UsedNames.Count > 5)
                    {
                        response = GenerateRandomFlame();
                    }
                    break;
                case 5:
                    response = GenerateGenericResponse();
                    break;
                case 6:
                    response = GenerateRandomEmojiString();
                    break;
            }

            response = PostModifyResponse(response);
            return response;
        }

        public static string GetRandomDollResponse()
        {
            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            int i = rnd.Next(0, CannedResponses.Length);
            string response = CannedResponses[i];
            int rnd1 = rnd.Next(0, 13);

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
                            response = "Are S% dangerous? They look risky to me";
                            break;
                        case 4:
                            response = "Are S% expensive?";
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
                            response = "S% are tricky as hell";
                            break;
                        case 9:
                            response = "I need better glasses for this";
                            break;
                    }
                    break;
                case 7:
                    response = GenerateAccessoryResponse();
                    break;
            }

            response = PostModifyResponse(response);
            return response;
        }

        private static string GenerateRandomEmojiString()
        {
            string response = GetSensibleCountryName();// string.Empty;
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

        /// <summary>
        /// Filters Faker's country names, removing any really long ones
        /// </summary>
        /// <returns></returns>
        private static string GetSensibleCountryName()
        {
            string countryName = Faker.Address.Country();
            while (countryName.Contains(" "))
            {
                countryName = Faker.Address.Country();
            }
            return countryName;
        }

        /// <summary>
        /// Filters Faker's country names, removing any really long ones
        /// </summary>
        /// <returns></returns>
        private static string GetSensibleCityName()
        {
            string cityName = Faker.Address.City();
            while (cityName.Contains(" "))
            {
                cityName = Faker.Address.City();
            }
            return cityName;
        }

        private static string GenerateRandomTutorialsPhrase()
        {
            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            int i = rnd.Next(0, 10);

            switch (i)
            {
                case 0:
                    return "F% should make more P% unboxing videos";
                case 1:
                    return "F% make the most engaging videos about P%";
                case 2:
                    return "F% are so good at explaining P%";
                case 3:
                    return "P% have such a steep learning curve but you have really helped me a lot";
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

        private static string GenerateRandomPraise()
        {
            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            int i = rnd.Next(0, Praise.Length);
            int j = rnd.Next(0, 16);
            if (j > 5)
            {
                return "I find P% " + Praise[i];
            }
            else if (j > 10)
            {
                return "I think P% " + Praise[i];
            } else
            {
                return "P% " + Praise[i];
            }
        }

        private static string GenerateGenericResponse()
        {
            string response = string.Empty;
            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            int i = rnd.Next(0, 15);
            if (i == 0) { response = "Greetings from " + GetSensibleCountryName(); }
            if (i == 1) { response = "Greetings from " + GetSensibleCityName(); }
            if (i == 2) { response = "Hi from " + GetSensibleCountryName(); }
            if (i == 3) { response = GetSensibleCountryName() + " in da house"; }
            if (i == 4) { response = "Being a doll is soooo hard in " + GetSensibleCountryName() + " cuz there are no boutiques"; }
            if (i == 5) { response = "Living in " + GetSensibleCountryName() + " coz the sunshine might turn me yellow"; }
            if (i == 6) { response = "Anybody else from " + GetSensibleCityName(); }
            if (i == 7) { response = "Anybody else as fanatical about P% as we are?"; }
            if (i == 8) { response = "Anyone else from I%?"; }
            if (i == 9) { response = "Anyone else from " + GetSensibleCountryName(); }
            if (i == 10) { response = "Anyone else from " + GetSensibleCityName() + "?"; }
            if (i == 11) { response = "Anyone else find they can't stop H%"; }
            if (i == 12) { response = "Living is soooo hard in " + GetSensibleCountryName() + " cuz there no books about this hobby"; }
            if (i == 13) { response = "H% should be made illegal in " + GetSensibleCountryName(); }
            if (i == 14) { response = "I don't know if V% ship to " + GetSensibleCountryName(); }
            if (i == 15) { response = GetSensibleCityName() + " is a great city for shopping"; }

            return response;
        }

        private static string GenerateAccessoryResponse()
        {
            string response = string.Empty;
            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            int i = rnd.Next(0, 18);
            //if (i == 0) { response = "Greetings from " + Faker.Country.Name(); }
            //if (i == 1) { response = "Greetings from " + Faker.Address.City(); }
            //if (i == 2) { response = "Hi from " + Faker.Country.Name(); }
            //if (i == 3) { response = Faker.Country.Name() + " in da house"; }
            //if (i == 4) { response = "Being a doll is soooo hard in " + Faker.Country.Name() + " cuz there are no boutiques"; }
            //if (i == 5) { response = "Living in " + Faker.Country.Name() + " coz the sunshine might turn me yellow"; }
            //if (i == 6) { response = "Anybody else from " + Faker.Address.City(); }
            if (i == 0) { response = "Has anybody used my A%?"; }
            if (i == 1) { response = "Has anybody seen my A%?"; }
            if (i == 2) { response = "I can't find my favourite A%!"; }
            if (i == 3) { response = "I badly need new A%!"; }
            if (i == 4) { response = "Did somebody sell my favourite A% on V%?"; }
            if (i == 5) { response = "Anyone else from T%?"; }
            if (i == 6) { response = "O% is so hard when you keep losing your A%"; }
            if (i == 7) { response = "O% is so difficult when you keep misplacing your A%"; }
            if (i == 8) { response = "The A% are rubbish compared to the ones you can get in " + Faker.Country.Name(); }
            if (i == 9) { response = "The A% are sooo bad compared to the ones you can get in " + Faker.Country.Name(); }
            if (i == 10) { response = "There's been a surge in interest in P% lately"; }
            if (i == 11) { response = "There's been a surge in interest in P% since " + GetRecentYear(); }
            if (i == 12) { response = "I haven't done O% since " + GetRecentYear(); }
            if (i == 13) { response = "I haven't been on V% since " + GetRecentYear(); }
            if (i == 14) { response = GetRecentYear() + " was the last time I logged into the V% website"; }
            if (i == 15) { response = "T% really started going downhill after " + GetRecentYear(); }
            if (i == 16) { response = "I registered for T% in " + GetRecentYear() + " but haven't logged in since."; }
            if (i == 17) { response = "P% are so expensive on V% these days"; }
            if (i == 18) { response = "P% aren't very common on V% these anymore"; }
            //if (i == 10) { response = "Anyone else from " + Faker.Address.City() + "?"; }
            //if (i == 11) { response = "Anyone else find P% is rock hard?"; }
            //if (i == 12) { response = "Coding is soooo hard in " + Faker.Country.Name() + " cuz there no books about P%"; }
            //if (i == 13) { response = "Coding is so hard in " + Faker.Country.Name() + " cuz there no P% jobs"; }
            //if (i == 14) { response = "I need to learn this. There are so many P% jobs in " + Faker.Country.Name(); }
            //if (i == 15) { response = "I need to learn this. There are a ton of P% jobs in " + Faker.Address.City(); }

            return response;
        }

        private static string GetRecentYear()
        {
            int year = DateTime.Now.Year;
            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            year = year - rnd.Next(0, 5);
            return year.ToString();
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

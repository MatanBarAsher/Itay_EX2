namespace Itay_EX2.Model
{
    using System.Security.Cryptography;
    using System.Xml.Linq;

  
        public class Game
        {
            int AppId;
            string Name;
            float Price;
            float Rank;
            DateTime ReleasDate;
            string Description;
            string Headerimage;
            string Website;
            Boolean Windows;
            Boolean Mac;
            Boolean Linux;
            string Recommendations;
            string Publisher;

            static List<Game> gameList = new List<Game>();

            public int AppId1 { get => AppId; set => AppId = value; }
            public string Name1 { get => Name; set => Name = value; }
            public float Price1 { get => Price; set => Price = value; }
            public float Rank1 { get => Rank; set => Rank = value; }
            public DateTime ReleasDate1 { get => ReleasDate; set => ReleasDate = value; }
            public string Description1 { get => Description; set => Description = value; }
            public string Headerimage1 { get => Headerimage; set => Headerimage = value; }
            public string Website1 { get => Website; set => Website = value; }
            public bool Windows1 { get => Windows; set => Windows = value; }
            public bool Mac1 { get => Mac; set => Mac = value; }
            public bool Linux1 { get => Linux; set => Linux = value; }
            public string Recommendations1 { get => Recommendations; set => Recommendations = value; }
            public string Publisher1 { get => Publisher; set => Publisher = value; }

            public Game()
            {

            }

            public Game(int appId, string name, float price, float rank, DateTime releasDate, string description, string headerimage,
                string website, bool windows, bool mac, bool linux, string recommendations, string publisher)
            {
                AppId1 = appId;
                Name1 = name;
                Price1 = price;
                Rank1 = rank;
                ReleasDate1 = releasDate;
                Description1 = description;
                Headerimage1 = headerimage;
                Website1 = website;
                Windows1 = windows;
                Mac1 = mac;
                Linux1 = linux;
                Recommendations1 = recommendations;
                Publisher1 = publisher;
            }

            public bool InsertGame(Game newGame)
            {
                foreach (Game tempGame in gameList)
                {
                    if (newGame.AppId1 == tempGame.AppId1 && newGame.Description1 == tempGame.Description1)
                    {
                        return false;
                    }
                }
                gameList.Add(newGame);
                return true;
            }
            public List<Game> Read()
            {
                return gameList;
            }


            public List<Game> GetByPrice(float minPrice)
            {
                List<Game> gameListByPrice = new List<Game>();

               foreach (Game tempGame in gameList)
               {
                       if (tempGame.Price > minPrice)
                       {
                         gameListByPrice.Add(tempGame);
                       }
               }
               return gameListByPrice;
            }

            public List<Game> GetByRankScore(int rankScore)
            {
                List<Game> gameListByPrice = new List<Game>();

                foreach (Game tempGame in gameList)
                {
                    if (tempGame.Rank1 > rankScore)
                    {
                        gameListByPrice.Add(tempGame);
                    }
                }
                return gameListByPrice;
            }

    }
    
}

namespace Itay_EX2.Model
{
        public class User
        {
            int ID;
            string Name;
            string Email;
            string Password;

            static List<User> UserList = new List<User>();

            public User(int iD, string name, string email, string password)
            {
                ID1 = iD;
                Name1 = name;
                Email1 = email;
                Password1 = password;
            }

            public int ID1 { get => ID; set => ID = value; }
            public string Name1 { get => Name; set => Name = value; }
            public string Email1 { get => Email; set => Email = value; }
            public string Password1 { get => Password; set => Password = value; }


            public User()
            {

            }
            public bool InsertUser(User newUser)
            {
                foreach (User tempUser in UserList)
                {
                    if (newUser.ID1 == tempUser.ID1)
                    {
                        return false;
                    }
                }

                UserList.Add(newUser);
                return true;
            }

            public List<User> readUser()
            {
                return UserList;
            }

        }


    
}

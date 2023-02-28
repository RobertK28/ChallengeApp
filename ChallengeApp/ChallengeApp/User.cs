namespace ChallengeApp
{
    public class User
    {
        public static string GameName = "Diablo";
        //private string login;
        //private string password;
        List<int> score = new List<int>();
        public User(string login, string password)
        {
            this.Login = login;
            this.Password = password;

        }

        public User(string login)
        { 
            this.Login = login;
        }

        public string Login { get; private set; }
        public string Password { get; private set; }

        public int Score
        {
            get
            {
                return score.Sum();
            }

        }
        public void AddScore(int nr)
        {
            this.score.Add(nr);
            this.score.Add(-1);
        }
    }
}

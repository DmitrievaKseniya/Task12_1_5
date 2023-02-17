namespace Task12_1_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Заполним список из этих пользователей
            var listUser = GetListUser();

            foreach (User user in listUser)
            {
                Console.WriteLine($"Привет, {user.Name}\n");
                if (!user.IsPremium)
                {
                    ShowAds();
                }
            }
        }
        static void ShowAds()
        {
            Console.WriteLine("***РЕКЛАМНАЯ ПАУЗА***");

            Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
            // Остановка на 1 с
            Thread.Sleep(1000);

            Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
            // Остановка на 2 с
            Thread.Sleep(2000);

            Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
            // Остановка на 3 с
            Thread.Sleep(3000);

            Console.WriteLine("***РЕКЛАМА ЗАКОНЧИЛАСЬ***\n");
        }

        static List<User> GetListUser()
        {
            //Создадим несколько пользователей
            var user1 = new User();
            user1.Login = "user1";
            user1.Name = "Сергей";
            user1.IsPremium = true;

            var user2 = new User();
            user2.Login = "user2";
            user2.Name = "Екатерина";
            user2.IsPremium = false;

            var user3 = new User();
            user3.Login = "user3";
            user3.Name = "Иван";
            user3.IsPremium = true;

            //Заполним список из этих пользователей
            var listUser = new List<User>();
            listUser.Add(user1);
            listUser.Add(user2);
            listUser.Add(user3);

            return listUser;
        }
    }
}
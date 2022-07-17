
namespace atm
{
    class Process
    {
        public static bool UserControl(string userName)
        {
            if (Log.GetUsers().Contains(userName)) { return true; }
            else { return false; }
        }
        public static void AddUser(string username)
        {
            Log.AddUser(username);
        }
        public static void ParaCek(string username, int prc)
        {
            Log.AddLog(username, $"{prc} TL çekim yapıldı.");
            Console.WriteLine($"{prc} TL çekim yapıldı.\n");
        }
        public static void ParaYatir(string username, int prc)
        {
            Log.AddLog(username, $"{prc} TL yatırma işlemi yapıldı.");
            Console.WriteLine($"{prc} TL yatırma işlemi yapıldı.\n");
        }
        public static void OdemeYap(string username, int prc, string islemAdi)
        {
            Log.AddLog(username, $"{islemAdi} işlemi için {prc} TL ödeme yapıldı.");
            Console.WriteLine($"{islemAdi} işlemi için {prc} TL ödeme yapıldı.\n");
        }
        public static void GunSonuAl()
        {
            List<string> list = Log.GetLogs();

            for (int i = list.Count - 1; i > 0; i--)
            {
                DateTime dt = Convert.ToDateTime((list[i].Split(list[i][list[i].IndexOf(' ')]))[0]);
                if (dt.Day == DateTime.Now.Day && dt.Month == DateTime.Now.Month)
                    Console.WriteLine(list[i]);
            }
        }
    }
    class Log
    {
        static string path1 = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\ATMusers.txt";
        static string path2 = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\ATMlogs.txt";

        public static List<string> GetUsers()
        {
            fileControl();
            List<string> list = new List<string>();

            using (StreamReader sr = new StreamReader(path1))
            {
                try
                {
                    while (!sr.EndOfStream)
                    {
                        string satir = sr.ReadLine();
                        if (!String.IsNullOrEmpty(satir))
                            list.Add(satir.TrimEnd().TrimStart());
                    }
                }
                catch { }
            }
            return list;
        }
        public static List<string> GetLogs()
        {
            fileControl();
            List<string> list = new List<string>();

            using (StreamReader sr = new StreamReader(path2))
            {
                try
                {
                    while (!sr.EndOfStream)
                    {
                        string satir = sr.ReadLine();
                        if (!String.IsNullOrEmpty(satir))
                            list.Add(satir.TrimEnd().TrimStart());
                    }
                }
                catch { }
            }
            return list;
        }
        public static void AddUser(string username)
        {
            fileControl();

            using (StreamWriter sw = new StreamWriter(path1, append: true))
            {
                sw.WriteLine(username.TrimEnd().TrimStart());
            }
        }
        public static void AddLog(string username, string log)
        {
            fileControl();

            using (StreamWriter sw = new StreamWriter(path2, append: true))
            {
                sw.WriteLine($"{DateTime.Now} {username}: " + log);
            }
        }
        static void fileControl()
        {
            if (!File.Exists(path1))
                File.Create(path1).Close();

            if (!File.Exists(path2))
                File.Create(path2).Close();
        }
    }
    class User
    {
        public string username;

        public User(string username)
        {
            this.username = username;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oylama
{
    internal class Register
    {
        static string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\votingLog.txt";

        public Register(string username)
        {
            if (!File.Exists(path))
                File.Create(path).Close();

            using (StreamWriter sr = new StreamWriter(path, append: true))
            {
                sr.WriteLine("\n{0}", username);
            }

        }
        static public bool Login(string username)
        {
            if (!File.Exists(path))
                File.Create(path).Close();
            using (StreamReader sr = new StreamReader(path))
            {
                while (!sr.EndOfStream)
                    if (sr.ReadLine().Contains(username))
                        return true;
                return false;
            }
        }
    }
    class Voting
    {
        static string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\votingLog1.txt";
        public Voting(int vote)
        {
            if (!File.Exists(path))
                File.Create(path).Close();
            using (StreamWriter sr = new StreamWriter(path, append: true))
            {
                sr.WriteLine("\n{0}", vote);
            }
        }
        public static string getResult()
        {
            double spor = 0, müzik = 0, sinema = 0;
            string res = "";

            using (StreamReader sr = new StreamReader(path))
            {
                while (!sr.EndOfStream)
                    switch (sr.ReadLine().TrimEnd().TrimStart())
                    {
                        case "1": spor++; break;
                        case "2": müzik++; break;
                        case "3": sinema++; break;

                        default: break;
                    } 
                res = String.Format($"\nSonuçlar;" +
                $"\nSpor -> %{spor / (spor + müzik + sinema) * 100}" +
                $"\nMüzik -> %{müzik / (spor + müzik + sinema) * 100}" +
                $"\nSinema -> %{sinema / (spor + müzik + sinema) * 100}");
            }

            return res;
        }
    }
}
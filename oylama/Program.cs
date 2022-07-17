using oylama;

Console.WriteLine("Lütfen kullanıcı adınızı giriniz: ");
string user = Console.ReadLine().TrimEnd().TrimStart();

bool log = Register.Login(user);
if (!log)
{
    Console.WriteLine("\nKaydınız bulunamadı. Kaydınızı gerçekleştiriyoruz..");
    Register reg = new Register(user);
}
Console.WriteLine("\nHoşgeldin {0}", user);
Console.WriteLine("\nLütfen oy vereceğiniz seçeneği seçiniz," +
    "\nSpor için 1," +
    "\nMüzik için 2," +
    "\nSinema için 3 yazınız.");

Voting vot = new Voting(int.Parse(Console.ReadLine()));

Console.WriteLine(Voting.getResult());
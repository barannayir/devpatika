
using atm;

Console.WriteLine("Lütfen kullanıcı adınızı giriniz: ");

string username = Console.ReadLine().TrimEnd();

if (!Process.UserControl(username))
{
    Console.WriteLine("Görüyorum ki adınıza kayıtlı hesap yok, HEMEN OLUŞTURULAM MI \nE/H");
    if (Console.ReadLine().ToUpper() == "E")
        Process.AddUser(username);
    else
        return;
}

Console.WriteLine("\nHoşgeldiniz {0}, Lütfen Yapmak İstediğiniz İşlemi Seçiniz: \n", username);
while (true)
{
    Console.WriteLine("\nPara Yatırma İçin 1," +
    "\nPara Çekmek İçin 2," +
    "\nÖdeme Yapmak için 3," +
    "\nGün Sonu Almak için 4 yazıp entere basınız.");

    int secim = int.Parse(Console.ReadLine());
    switch (secim)
    {
        case 1:
            Console.WriteLine("\nYatırmak istediğiniz miktarı giriniz: ");
            Process.ParaYatir(username, int.Parse(Console.ReadLine().TrimEnd()));
            break;
        case 2:
            Console.WriteLine("\nÇekmek istediğiniz miktarı giriniz: ");
            Process.ParaCek(username, int.Parse(Console.ReadLine().TrimEnd()));
            break;
        case 3:
            Console.WriteLine("\nÖdeme türünü giriniz..");
            string odeme = Console.ReadLine();
            Console.WriteLine("\nYatırılacak miktarı giriniz");
            int prc = int.Parse(Console.ReadLine());
            Process.OdemeYap(username, prc, odeme);
            break;
        case 4:
            Console.WriteLine("\nGün sonu raporu alınıyor..");
            Process.GunSonuAl();
            break;
        default: 
            break;
    }
}
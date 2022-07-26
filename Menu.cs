using System;
using System.Collections.Generic;
using System.Threading;

namespace ClassMetotDemo;

public class Menu
{
    public  void Menus()
    {
        MusteriManager musteriManager = new MusteriManager();
        
        string Header = "Banka Müsteri Takip Sistemi v1.0";
        string programMenu = "1-Müşteri Ekle\n2-Müşteri Listele\n3-Müşteri Sil\n4-Müşteri Güncelle\n5-Çıkış\nSeçiniz: ";
        Console.SetCursorPosition((Console.WindowWidth - Header.Length) / 2, Console.CursorTop);
        Console.WriteLine(Header);
        Console.Write(programMenu);
        string programFooter = "Programın son haliyle kullanıldığınızdan teşekkür ederiz.";
        int menu = Convert.ToInt16(Console.ReadLine());
        List<Musteri> musteris = new List<Musteri>();
        switch (menu)
        {
           
            case 1:

                musteris = musteriManager.Ekleme();
                Console.Write("Devam ");
                char key = Convert.ToChar(Console.ReadLine().Trim().ToUpper());
                if (key == 'E')
                {
                    altmenu(musteris);
                }
                break;
            case 2:
                {
                    musteriManager.Listeleme(musteris);
                }
                break;
            case 3:
                musteriManager.Silme(musteris);
                break;
            case 4:
                Console.WriteLine("Güncelleme işlemi yapılacak");
                break;
            case 5:
                Console.WriteLine(programFooter);
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Geçersiz seçim");

                Menus();
                break;
        }
       
    }

    private void altmenu(List<Musteri> musteris)
    {
        Console.Clear();
        MusteriManager musteriManager = new MusteriManager();
        string programMenu = "1-Müşteri Ekle\n2-Müşteri Listele\n3-Müşteri Sil\n4-Müşteri Güncelle\n5-Çıkış\nSeçiniz: ";
        string Header = "Banka Müsteri Takip Sistemi v1.0";
        string programFooter = "Programın son haliyle kullanıldığınızdan teşekkür ederiz.";
        Console.SetCursorPosition((Console.WindowWidth - Header.Length) / 2, Console.CursorTop);
        Console.WriteLine(Header);
        Console.Write(programMenu);
        int menu = Convert.ToInt16(Console.ReadLine());

        switch (menu)
        {
            case 1:

                musteris = musteriManager.Ekleme();
                Console.Write("Devam ");
                AltMenuSorgusu(musteris);
                break;
            case 2:
                {
                    musteriManager.Listeleme(musteris);
                    AltMenuSorgusu(musteris);

                }
                break;
            case 3:
                musteriManager.Silme(musteris);
                AltMenuSorgusu(musteris);

                break;
            case 4:
                Console.WriteLine("Güncelleme işlemi yapılacak");
                AltMenuSorgusu(musteris);

                break;
            case 5:
                Console.WriteLine(programFooter);
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Geçersiz seçim");

                Menus();
                break;
        }
    }

    private void AltMenuSorgusu(List<Musteri> musteris)
    {
        Thread.Sleep(5000);
        Console.Clear();
        char key = Convert.ToChar(Console.ReadLine().Trim().ToUpper());
        if (key == 'E')
        {
            altmenu(musteris);
        }
    }
}
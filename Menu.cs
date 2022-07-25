using System;
using System.Collections.Generic;

namespace ClassMetotDemo;

public class Menu
{
    public  void Menus()
    {
        MusteriManager musteriManager = new MusteriManager();
        string programHeader = "Banka Müsteri Takip Sistemi v1.0";
        string programFooter = "Programın son haliyle kullanıldığınızdan teşekkür ederiz."; 
        string programMenu = "1-Müşteri Ekle\n2-Müşteri Listele\n3-Müşteri Sil\n4-Müşteri Güncelle\n5-Çıkış\nSeçiniz: ";
            
        Console.SetCursorPosition((Console.WindowWidth - programHeader.Length) / 2, Console.CursorTop);
        Console.WriteLine(programHeader);
        Console.Write(programMenu);
        int menu=Convert.ToInt16(Console.ReadLine());
        switch (menu) 
        {
            case 1:
                musteriManager.Ekleme(null);
                break;
            case 2:
            {
                musteriManager.Listeleme(null);
            }
                break;
            case 3:
                musteriManager.Silme();
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
    
}
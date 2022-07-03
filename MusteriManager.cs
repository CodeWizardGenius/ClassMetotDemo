using System;

namespace ClassMetotDemo
{
    public class MusteriManager
    {
        
        public void Ekleme()
        {
          
           Console.WriteLine("Kaç Adet Müşteri Eklenecek?");
           int adet = Convert.ToInt32(Console.ReadLine());
           Musteri[]  musteriler = new Musteri[adet];
           for (int i = 0; i < adet; i++)
           {
               Console.WriteLine("Müşteri Adı:");
               musteriler[i].Name=Console.ReadLine();
               Console.WriteLine("Müşteri Soyadı:");
               musteriler[i].SurName = Console.ReadLine();
               Console.WriteLine("Müşteri Cinsiyeti:");
               char ch;
               char.TryParse(Console.ReadLine(), out ch);
               musteriler[i].Gender = ch;
               Console.WriteLine("Enter a date: ");
               DateTime userDateTime;
               if (DateTime.TryParse(Console.ReadLine(), out userDateTime))
               {
                   Console.WriteLine("The day of the week is: " + userDateTime.DayOfWeek);
               }
               else
               {
                   Console.WriteLine("You have entered an incorrect value");
               }
               musteriler[i].BirthDate=userDateTime;
               Console.WriteLine("Medeni Hali:");
                musteriler[i].MaritalStatus = Console.ReadLine();
                Console.WriteLine("Yaşadınız Şehir:");
                musteriler[i].City = Console.ReadLine();
                Console.WriteLine("Yaşadınız ülke:");
                musteriler[i].Country = Console.ReadLine();
                Console.WriteLine("Müşteri Telefon Numarası:");
                musteriler[i].Phone = Console.ReadLine();
                Console.WriteLine("Müşteri E-Posta Adresi:");
                musteriler[i].Email = Console.ReadLine();
                

           }
        }

        // public void Listeleme()
        // {
        //     foreach (var item in musteriler)
        //     {
        //         Console.WriteLine("Müşteri Adı:" + item.Name);
        //         Console.WriteLine("Müşteri Soyadı:" + item.SurName);
        //         Console.WriteLine("Müsteri Cinsiyeti: " + item.Gender);
        //         Console.WriteLine("Müsteri Doğum Tarihi:" + item.BirthDate);
        //         Console.WriteLine("Müsteri Medeni Hali:" + item.MaritalStatus);
        //         Console.WriteLine("Müsteri Yaşadığı Şehir:" + item.City);
        //         Console.WriteLine("Müsteri Yaşadığı Ülke:" + item.Country);
        //         Console.WriteLine("Müsteri Telefon Numarası:" + item.Phone);
        //         Console.WriteLine("Müsteri E-Posta Adresi:" + item.Email);
        //         Console.WriteLine("-----------------------------------------------------");
        //     }
        // }

        public void Silme()
        {
            
        }
    }
}
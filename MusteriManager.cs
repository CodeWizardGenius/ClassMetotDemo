using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassMetotDemo
{
    public class MusteriManager
    {
        private List<Musteri> musteriListesi; 
        public void Ekleme()
        {
            int adet= 0;
           Console.WriteLine("Kaç Adet Müşteri Eklenecek?");
            adet= Convert.ToInt32(Console.ReadLine());
           musteriListesi=Enumerable.Range(0, adet).Select(_ => new Musteri()).ToList();
           for (int i = 0; i < adet; i++)
           {
               Console.WriteLine("Müşteri Adı:");
               musteriListesi[i].Name=Console.ReadLine();
               Console.WriteLine("Müşteri Soyadı:");
               Console.WriteLine("Müşteri Cinsiyeti:");
               char ch;
               char.TryParse(Console.ReadLine(), out ch);
               musteriListesi[i].Gender = ch;
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
               musteriListesi[i].BirthDate=userDateTime;
               Console.WriteLine("Medeni Hali:");
                musteriListesi[i].MaritalStatus = Console.ReadLine();
                Console.WriteLine("Yaşadınız Şehir:");
                musteriListesi[i].City = Console.ReadLine();
                Console.WriteLine("Yaşadınız ülke:");
                musteriListesi[i].Country = Console.ReadLine();
                Console.WriteLine("Müşteri Telefon Numarası:");
                musteriListesi[i].Phone = Console.ReadLine();
                Console.WriteLine("Müşteri E-Posta Adresi:");
                musteriListesi[i].Email = Console.ReadLine();
                

           }
        }

        public void Listeleme()
        {
            foreach (var item in musteriListesi )
            {
                Console.WriteLine("Müşteri Adı:" + item.Name);
                Console.WriteLine("Müşteri Soyadı:" + item.SurName);
                Console.WriteLine("Müsteri Cinsiyeti: " + item.Gender);
                Console.WriteLine("Müsteri Doğum Tarihi:" + item.BirthDate);
                Console.WriteLine("Müsteri Medeni Hali:" + item.MaritalStatus);
                Console.WriteLine("Müsteri Yaşadığı Şehir:" + item.City);
                Console.WriteLine("Müsteri Yaşadığı Ülke:" + item.Country);
                Console.WriteLine("Müsteri Telefon Numarası:" + item.Phone);
                Console.WriteLine("Müsteri E-Posta Adresi:" + item.Email);
                Console.WriteLine("-----------------------------------------------------");
            }
        }

        public void Silme()
        {
            
        }
    }
}
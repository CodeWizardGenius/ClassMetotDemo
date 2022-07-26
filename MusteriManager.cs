using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassMetotDemo
{
    public class MusteriManager
    {
        public List<Musteri> musteriListesi;
        
        public List<Musteri> EklemeListe()
        {
            #region 
            List<Musteri> musteriListesi1; 
            int adet = 0;
            Console.WriteLine("Kaç Adet Müşteri Eklenecek?");
            adet = Convert.ToInt32(Console.ReadLine());
            musteriListesi1 = Enumerable.Range(0, adet).Select(_ => new Musteri()).ToList();
            for (int i = 0; i < adet; i++)
            {
                Console.WriteLine("Müşteri Adı:");
                musteriListesi1[i].Name = Console.ReadLine();
                Console.WriteLine("Müşteri Soyadı:");
                musteriListesi1[i].SurName = Console.ReadLine();
                Console.WriteLine("Müşteri Cinsiyeti:");
                //char ch;
                //char.TryParse(Console.ReadLine(), out ch);
                //musteriListesi1[i].Gender = ch;
                //Console.WriteLine("Enter a date: ");
                //DateTime userDateTime;
                //if (DateTime.TryParse(Console.ReadLine(), out userDateTime))
                //{
                //    Console.WriteLine("The day of the week is: " + userDateTime.DayOfWeek);
                //}
                //else
                //{
                //    Console.WriteLine("You have entered an incorrect value");
                //}
                //musteriListesi1[i].BirthDate = userDateTime;
                //Console.WriteLine("Medeni Hali:");
                //musteriListesi1[i].MaritalStatus = Console.ReadLine();
                //Console.WriteLine("Yaşadınız Şehir:");
                //musteriListesi1[i].City = Console.ReadLine();
                //Console.WriteLine("Yaşadınız ülke:");
                //musteriListesi1[i].Country = Console.ReadLine();
                //Console.WriteLine("Müşteri Telefon Numarası:");
                //musteriListesi1[i].Phone = Console.ReadLine();
                //Console.WriteLine("Müşteri E-Posta Adresi:");
                //musteriListesi1[i].Email = Console.ReadLine();

           
            }
          
          
            return (musteriListesi1);


            #endregion

        }

        public List<Musteri> Ekleme()
        {
            musteriListesi = EklemeListe();
            return musteriListesi;
        }

        public void Listeleme(List<Musteri> musteriListesi)
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

using System;
using System.Collections.Generic;

namespace UzbekEnglishDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            // So'z juftlari va havolalar sonini saqlash uchun lug'at yaratiildi
            Dictionary<string, Tuple<string, int>> dictionary = new Dictionary<string, Tuple<string, int>>();

            //Lug'atni to'ldirish (siz so'zlarni qo'lda qo'shishingiz yoki fayldan import qilishingiz mumkin)
            dictionary.Add("salom", Tuple.Create("hello", 0));
            dictionary.Add("xayr", Tuple.Create("goodbye", 0));
            //... qoʻshimcha soʻz juftlarini qoʻshsa ham bo'ladi

            // Lug'atni alifbo tartibida ko'rsatish
            DisplayDictionary(dictionary);

            // Foydalanuvchining o'zaro ta'siri va ma'lumotnomalarni kuzatish funksiyasini amalga oshirish
            // ... (tarjimalarni qidirish, havolalar sonini yangilash va hokazolar uchun kod qo'shish)
        }

        static void DisplayDictionary(Dictionary<string, Tuple<string, int>> dictionary)
        {
            foreach (KeyValuePair<string, Tuple<string, int>> entry in dictionary.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{entry.Key} - {entry.Value.Item1} ({entry.Value.Item2} references)");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace LessonTask01
{
    public class Pharmacy
    {
        private List<Drug> drugs;

        public Pharmacy()
        {
            drugs = new List<Drug>();
        }

        public void AddDrug(Drug d)
        {
            foreach (var item in drugs)
            {
                if (item.Id == d.Id)
                {
                    Console.WriteLine($"Xəta: {d.Id} ID-li dərman artıq mövcuddur!");
                    return; 
                }
            }
            drugs.Add(d);
            Console.WriteLine("Dərman uğurla əlavə edildi.");
        }

        public void SearchDrug(string name)
        {
            int tapilanlarinSayi = 0;
            foreach (var drug in drugs)
            {
                if (drug.Name.ToLower().Contains(name.ToLower()))
                {
                    drug.ShowInfo();
                    tapilanlarinSayi = tapilanlarinSayi + 1; 
                }
            }
            if (tapilanlarinSayi == 0)
            {
                Console.WriteLine("Axtarışa uyğun dərman tapılmadı.");
            }
        }


        public void RemoveDrug(int id)
        {
            foreach (var item in drugs)
            {
                if (item.Id == id)
                {
                    drugs.Remove(item); 
                    Console.WriteLine($"{id} ID-li dərman uğurla silindi.");
                    return; 
                }
            }
            Console.WriteLine($"Xəta: {id} ID-li dərman tapılmadı!");
        }


        public void GetAllDrugs()
        {
            if (drugs.Count == 0)
            {
                Console.WriteLine("Aptekdə heç bir dərman yoxdur.");
                return;
            }
            Console.WriteLine("\n--- Bütün Dərmanların Siyahısı ---");
            foreach (var drug in drugs)
            {
                drug.ShowInfo();
            }
        }

        public void GetByCategory(string category)
        {
            int tapilanlarinSayi = 0;

            Console.WriteLine($"\n--- {category} Kateqoriyasındakı Dərmanlar ---");
            foreach (var drug in drugs)
            {
                if (drug.Category.ToLower() == category.ToLower())
                {
                    drug.ShowInfo(); 
                    tapilanlarinSayi = tapilanlarinSayi + 1; 
                }
            }
            if (tapilanlarinSayi == 0)
            {
                Console.WriteLine($"'{category}' kateqoriyasında dərman tapılmadı.");
            }
        }

    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonTask01
{
    public class Drug
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }
        public Drug(int id,string name,double price,string category)
        {
            Id=id;
            Name=name;
            Price=price;
            Category=category;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Məhsulun adı:{Name} Məhsulun qiyməti:{Price} AZN Məhsulun kateqoriyası: {Category}");
        }
    }
}

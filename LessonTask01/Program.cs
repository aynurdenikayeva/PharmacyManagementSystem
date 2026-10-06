using LessonTask01;
using System;
using System.IO;
namespace LessonTask01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; 

            Pharmacy myPharmacy = new Pharmacy();
            bool running = true;

            myPharmacy.AddDrug(new Drug(1, "Parasetamol", 1.20, "Baş"));
            myPharmacy.AddDrug(new Drug(2, "Kardiomaqnil", 4.50, "Ürək"));
            myPharmacy.AddDrug(new Drug(3, "Mezim", 3.80, "Mədə"));
            myPharmacy.AddDrug(new Drug(4, "Festal", 1.00, "Mədə"));
            myPharmacy.AddDrug(new Drug(5, "Offdol", 7.55, "Baş"));

            Console.Clear();

            while (running)
            {
                Console.Write("---------------------------------");
                Console.Write("Aptek Məhsullarımız");
                Console.Write("---------------------------------");
                Console.WriteLine("\n1. Əlavə et");
                Console.WriteLine("\n2. Axtar");
                Console.WriteLine("\n3. Sil");
                Console.WriteLine("\n4. Hamısı");
                Console.WriteLine("\n5. Kateqoriya");
                Console.WriteLine("\n6. Çıxış");
                Console.Write("---------------------------------");
                Console.Write("Seçiminiz (1-6): ");
                Console.Write("---------------------------------\n");

                switch (Console.ReadLine())
                {
                    case "1":
                        Console.Write("ID: ");
                        if (!int.TryParse(Console.ReadLine(), out int id)) 
                        { 
                            Console.WriteLine("Xəta: ID rəqəm olmalıdır!");
                            break; 
                        }
                        Console.Write("Ad: ");
                        string name = Console.ReadLine();

                        Console.Write("Qiymət (məsələn 2,50): ");
                        string duzReqem = Console.ReadLine().Replace(",", "").Replace(".", "");
                        if (!double.TryParse(duzReqem, out double price))
                        {
                            Console.WriteLine("Xəta: Qiymət səhvdir!");
                            break;
                        }
                        price = price / 100;

                        Console.WriteLine("Kateqoriya seçin:\n1. Baş\n2. Ürək\n3. Mədə");
                        Console.Write("Seçiminiz (1-3): ");
                        string item1 = Console.ReadLine();

                        string category = "";
                        if (item1 == "1") category = "Baş";
                        else if (item1 == "2") category = "Ürək";
                        else if (item1 == "3") category = "Mədə";
                        else
                        {
                            Console.WriteLine("Xəta: Yanlış kateqoriya seçimi!");
                            break;
                        }
                        myPharmacy.AddDrug(new Drug(id, name, price, category));
                        break;

                    case "2":
                        Console.Write("Axtarılan ad: ");
                        myPharmacy.SearchDrug(Console.ReadLine());
                        break;

                    case "3":
                        Console.Write("Silinəcək ID: ");
                        if (int.TryParse(Console.ReadLine(), out int removeId)) myPharmacy.RemoveDrug(removeId);
                        else Console.WriteLine("Xəta: ID rəqəm olmalıdır!");
                        break;

                    case "4":
                        myPharmacy.GetAllDrugs();
                        break;
                    case "5":
                        Console.WriteLine("Baxmaq istədiyiniz kateqoriyanı seçin:\n1. Baş\n2. Ürək\n3. Mədə");
                        Console.Write("Seçiminiz (1-3): ");
                        string item2 = Console.ReadLine();
                        string filterCategory = "";
                        if (item2 == "1") filterCategory = "Baş";
                        else if (item2 == "2") filterCategory = "Ürək";
                        else if (item2 == "3") filterCategory = "Mədə";
                        else
                        {
                            Console.WriteLine("Xəta: Yanlış seçim!");
                            break;
                        }
                        myPharmacy.GetByCategory(filterCategory);
                        break;
                    case "6":
                        running = false;
                        Console.WriteLine("Sağ olun!");
                        break;

                    default:
                        Console.WriteLine("Yanlış seçim!");
                        break;
                }
            }

        }
    }
    }
    

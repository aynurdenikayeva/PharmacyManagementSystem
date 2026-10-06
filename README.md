# Pharmacy Management System (Console Application)

A lightweight and interactive **C# Console Application** designed to manage a pharmacy's drug inventory. This project demonstrates core **Object-Oriented Programming (OOP)** principles, safe user input validation, and dynamic collection handling in .NET.

## 🚀 Features
* **Add New Drugs:** Insert products with unique IDs, dynamic price formatting, and categorized types (e.g., Head, Heart, Stomach).
* **Duplicate Prevention:** Validates drug IDs before entry to prevent duplicate records.
* **Search Functionality:** Case-insensitive search to quickly locate medicines by name.
* **Remove Inventory:** Delete entries instantly from the system using their unique ID.
* **Categorized Filtering:** List and view products filtered strictly by their therapeutic category.
* **View Full Inventory:** Display a complete breakdown of all available medicines in the pharmacy.

## 🛠️ Technical Implementation
* **Language:** C# (.NET Core / .NET Standard)
* **Application Type:** Console Application CLI
* **Data Management:** Dynamic `List<T>` collection for CRUD-like operations in memory.
* **Input Validation:** Implementation of safe parsing (`int.TryParse`, `double.TryParse`) to prevent runtime crashes.
* **Encapsulation:** Proper modularity across `Program`, `Pharmacy`, and `Drug` classes.

  
# Aptek İdarəetmə Sistemi (Console Application)

Aptekin dərman inventarını idarə etmək üçün nəzərdə tutulmuş yüngül və interaktiv **C# Console tətbiqidir**. Bu layihə **Obyektyönümlü Proqramlaşdırmanın (OOP)** əsas prinsiplərini, istifadəçi daxiletmələrinin təhlükəsiz yoxlanılmasını (validation) və .NET mühitində dinamik kolleksiyalarla işləməyi nümayiş etdirir.

## 🚀 Funksiyalar
* **Yeni Dərman Əlavə Edilməsi:** Unikal ID, dinamik qiymət formatı və müəyyən kateqoriyalar (məsələn: Baş, Ürək, Mədə) ilə məhsulların daxil edilməsi.
* **Təkrarlanmanın Qarşısının Alınması:** Dublikat qeydlərin yaranmaması üçün sistemə əlavə edilməzdən əvvəl dərman ID-lərinin yoxlanılması.
* **Axtarış Sistemi:** Dərmanları adlarına görə tez bir zamanda tapmaq üçün böyük/kiçik hərf həssaslığı olmayan (case-insensitive) axtarış.
* **İnventardan Silmə:** Unikal ID-dən istifadə edərək qeydlərin sistemdən dərhal silinməsi.
* **Kateqoriyaya Görə Filtrləmə:** Məhsulların yalnız seçilmiş terapevtik kateqoriyaya uyğun olaraq siyahıya alınması və göstərilməsi.
* **Bütün İnventara Baxış:** Aptekdə mövcud olan bütün dərmanların tam siyahısının nümayişi.

## 🛠️ Texniki İcra
* **Proqramlaşdırma Dili:** C# (.NET Core / .NET Standard)
* **Tətbiq Növü:** Console Application CLI (Əmr sətri interfeysi)
* **Məlumatların İdarə Edilməsi:** Yaddaşda CRUD tipli əməliyyatların aparılması üçün dinamik `List<T>` kolleksiyası.
* **Daxiletmələrin Yoxlanılması:** Proqramın iş zamanı çökməsinin (crash) qarşısını almaq üçün təhlükəsiz parsing mexanizmlərinin (`int.TryParse`, `double.TryParse`) tətbiqi.
* **Enkapsulyasiya (Kapsulalama):** `Program`, `Pharmacy` və `Drug` klassları arasında düzgün modulyarlığın təmin edilməsi.

using System;
using JSon;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            CarGallery gallery = new CarGallery { Name = "MyCarGallery" };
            gallery.LoadFromFile();

            while (true)
            {
                Console.WriteLine("1. Avtomobil əlavə et");
                Console.WriteLine("2. Avtomobili sil");
                Console.WriteLine("3. Bütün avtomobilləri göstər");
                Console.WriteLine("4. ID ilə avtomobili göstər");
                Console.WriteLine("5. Çıxış");

                var choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        AddCar(gallery);
                        break;
                    case "2":
                        RemoveCar(gallery);
                        break;
                    case "3":
                        gallery.GetAllCars();
                        break;
                    case "4":
                        GetCarById(gallery);
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Yanlış seçim. Zəhmət olmasa yenidən cəhd edin.");
                        break;
                }
            }
        }

        static void AddCar(CarGallery gallery)
        {
            Console.Write("ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Marka: ");
            string marka = Console.ReadLine();
            Console.Write("Model: ");
            string model = Console.ReadLine();
            Console.Write("İl: ");
            int year = int.Parse(Console.ReadLine());

            Car car = new Car { Id = id, Marka = marka, Model = model, Year = year };
            gallery.AddCar(car);
        }

        static void RemoveCar(CarGallery gallery)
        {
            Console.Write("Silinməli olan avtomobilin ID-si: ");
            int id = int.Parse(Console.ReadLine());
            gallery.RemoveCar(id);
        }

        static void GetCarById(CarGallery gallery)
        {
            Console.Write("Göstərmək istədiyiniz avtomobilin ID-si: ");
            int id = int.Parse(Console.ReadLine());
            Car car = gallery.GetById(id);
            if (car != null)
            {
                Console.WriteLine(car);
            }
            else
            {
                Console.WriteLine("Bu ID ilə avtomobil tapılmadı.");
            }
        }
    }
}

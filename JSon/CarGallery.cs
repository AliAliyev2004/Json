using JSon;
using System.Xml;

namespace ConsoleApp12
{
    public class CarGallery
    {
        public string Name { get; set; }
        public List<Car> Cars { get; set; } = new List<Car>();

        public void AddCar(Car car)
        {
            Cars.Add(car);
            SaveToFile();
        }

        public void RemoveCar(int carId)
        {
            var car = Cars.FirstOrDefault(c => c.Id == carId);
            if (car != null)
            {
                Cars.Remove(car);
                SaveToFile();
            }
        }

        public void GetAllCars()
        {
            foreach (var car in Cars)
            {
                Console.WriteLine(car);
            }
        }

        public Car GetById(int id)
        {
            return Cars.FirstOrDefault(c => c.Id == id);
        }

        public void SaveToFile()
        {
            var json = JSonConvert.SerializeObject(Cars, Formatting.Indented);
            File.WriteAllText($"{Name}_cars.json", json);
        }

        public void LoadFromFile()
        {
            if (File.Exists($"{Name}_cars.json"))
            {
                var json = File.ReadAllText($"{Name}_cars.json");
                Cars = JsonConvert.DeserializeObject<List<Car>>(json);
            }
        }
    }
}


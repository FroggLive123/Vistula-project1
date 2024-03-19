using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Witam, tutaj możesz napisać charakterystykę swojego samochodu");
        Car car = new Car();
        car.setBrand();
        car.setColor();
        car.setEngine();
        car.setSize();
        car.setGearbox();
        car.read();
    }
    public class Car()
    {
        string carBrand;
        string color;
        string engine;
        string size;
        string gearbox;
        public void setBrand()
        {
            Console.WriteLine("Podaj markę samochodu");
            carBrand = Console.ReadLine();
            
        }

        public void setColor()
        {
            Console.WriteLine("Podaj kolor");
            color = Console.ReadLine();
        }

        public void setEngine()
        {
            Console.WriteLine("Określ typ silnika");
            engine = Console.ReadLine();
        }

        public void setSize()
        {
            Console.WriteLine("Zapisz wymiary samochodu");
            size = Console.ReadLine();
        }

        public void setGearbox()
        {
            Console.WriteLine("Określ żądany typ skrzyni biegów");
            gearbox = Console.ReadLine();
        }
        public void read()
        {
        Console.WriteLine("Twoja marka samochodu: " + carBrand);
        Console.WriteLine("Kolor Twojego samochodu: " + color);
        Console.WriteLine("Silnik Twojego samochodu:: " + engine);
        Console.WriteLine("Rozmiar Twojego samochodu: " + size);
        Console.WriteLine("Typ skrzyni biegów do Twojego samochodu: " + gearbox);

        }

    }
}
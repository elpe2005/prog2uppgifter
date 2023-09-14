using System.Formats.Asn1;
using System.Security.Cryptography;

namespace prog2uppgifter
{
    public class Text 
    {
        public void Rectangleut()
        {
            Console.Clear();
            Console.WriteLine("Du har valt Rektangel");
            Console.WriteLine("Skriv in höjden.");
            int height = int.Parse(Console.ReadLine());
            Console.WriteLine("Skriv in bredden.");
            int width = int.Parse(Console.ReadLine());
            Rectangle p1 = new Rectangle(width, height);
            Console.WriteLine($"Höjd: {height} \nbredd: {width}");
            p1.Area();
            p1.Omkrets();
        }
        public void Triangelut()
        {
            Console.Clear();
            Console.WriteLine("Du har valt Triangel");
            Console.WriteLine("Skriv in höjden.");
            int height = int.Parse(Console.ReadLine());
            Console.WriteLine("Skriv in bredden.");
            int width = int.Parse(Console.ReadLine());
            Triangle p2 = new Triangle(width, height);
            Console.WriteLine($"Höjd: {height} \nbredd: {width}");
            p2.Area();
            p2.Omkrets();
        }
    }
}
// See https://aka.ms/new-console-template for more information
using System.Net;
using System.Reflection.Metadata.Ecma335;
using prog2uppgifter;

class Program{
    static void Main(){
        Text p1 = new Text();
        Console.WriteLine("Vill du räkna ut omkretsen och Arean på en rektangel eller Triangel, skriv 1 för rektangel och 2 för triangel");
        int meny = int.Parse(Console.ReadLine());
        switch (meny)
        {
            case 1:
            {
                p1.Rectangleut();
            break;
            }
            case 2:
            {
                p1.Triangelut();
            break;
            }
            
        }
        
    }
}
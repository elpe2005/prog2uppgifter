namespace prog2uppgifter
{
    public class Rectangle : Shape
    {        
        public void Area(int area){
            area = width*height;
        }
        public void Omkrets(int omkrets){
            omkrets = 2*height + 2*width;
        }
        public Rectangle(int width,int height) : base(width,height){
            width = width;
            height = height;
            Console.WriteLine("Vill du räkna ut Arean eller Omkretsen för en Rektangel?");
        }
    }
}
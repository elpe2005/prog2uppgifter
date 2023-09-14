namespace prog2uppgifter
{
    public class Rectangle : Shape
    {        
        public void Area(){
           int area = width*height;
           Console.WriteLine($"Area: {area}");
        }
        public void Omkrets(){
           int omkrets = 2*height + 2*width;
           Console.WriteLine($"omkretsen: {omkrets}");
        }
        public Rectangle(int width,int height) : base(width,height){
        }
    }
}
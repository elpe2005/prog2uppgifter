namespace prog2uppgifter
{
    public class Triangle : Shape
    {
        public void Area(){
            int area = width*height/2;
            Console.WriteLine(Area);
        }
        public void Omkrets(){
            double omkrets = Math.Sqrt(width*width + height*height);
            Console.WriteLine(Omkrets);
        }
        public Triangle(int width,int height) : base(width,height){
        width = width;
        height = height;
        Console.WriteLine("Vill du räkna ut Arean eller Omkretsen för en Triangel?");
        }
    }

    
}
namespace prog2uppgifter
{
    public class Triangle : Shape
    {
        public void Area(){
            int area = width*height/2;
            Console.WriteLine($"Arean: {area}");
        }
        public void Omkrets(){
            double omkrets = Math.Sqrt(width*width + height*height);
            omkrets = omkrets + Convert.ToDouble(height + width);
            Console.WriteLine($"omkretsen{omkrets}");
        }
        public Triangle(int width,int height) : base(width,height){

        }
    }

    
}
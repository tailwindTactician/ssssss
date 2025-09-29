    public class Rectangle : Shape
    {
        private double length;
        private double width;

        public Rectangle(string color, double length, double width) 
            : base(color)
        {
            this.length = length;
            this.width = width;
        }

        public double GetLength()
        {
            return length;
        }

        public double GetWidth()
        {
            return width;
        }

        public double GetArea()
        {
            return length * width;
        }
    }

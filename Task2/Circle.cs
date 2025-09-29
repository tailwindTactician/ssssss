    public class Circle : Shape
    {
        private double radius;

        public Circle(string color, double radius) 
            : base(color)
        {
            this.radius = radius;
        }

        public double GetRadius()
        {
            return radius;
        }

        public double GetArea()
        {
            return Math.PI * radius * radius;
        }
    }


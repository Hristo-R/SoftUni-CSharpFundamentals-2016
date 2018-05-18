namespace Shapes
{
    public class Rhombus : BasicShape
    {
        private double altitude;

        public Rhombus(double width, double height, double altitude) : base(width, height)
        {
            this.Altitude = altitude;
        }

        public double Altitude
        {
            get
            {
                return this.altitude;
            }

            set
            {
                this.altitude = value;
            }
        }

        public override double CalculateArea()
        {
            return this.Width * this.Altitude;
        }

        public override double CalculatePerimeter()
        {
            return 4 * this.Width;
        }
    }
}

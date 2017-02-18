using System;

namespace Triangle_Surface_by_Side_and_Altitude
{
    class Triangle
    {
        public Triangle() { }

        private double Surf;
        private double Surf2;
        private double Surf3;

        public double A { get; set; }
        public double H { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        public int Angle { get; set; }

        public void Surface()
        {
            Surf = ((A * H)/2);
            Console.WriteLine(Surf);
        }

        public void SurfaceByThreeSides()
        {
            double S = ((A + B + C)/2);
            Surf2 = Math.Sqrt((S*(S-A)*(S-B)*(S-C)));
            Console.WriteLine("{0:F2}", Surf2);
        }

        public void SurfaceByTwoSidesAndAnAngle()
        {
            double ang = Math.Sin((Math.PI * Angle)/180);
            Surf3 = ((A * B * ang) / 2);
            Console.WriteLine("{0:F2}", Surf3);
        }
    }
}

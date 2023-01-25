using System;
namespace bai_tap
{
    class  Cercle
    {
        private double rayon;
        public  Cercle( double rayon)
        {
            this.rayon=rayon;
        }
        public double GetArea()
        {
            return Math.Round(Math.Pow(rayon,2)*Math.PI,2);
        }
        public double  GetPerimeter()
        {
            return Math.Round(rayon*2*Math.PI,2);
        }
    }
}
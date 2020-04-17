using System;

namespace MethodsAndScope
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Circumference();
            AreaCirc();
            Volume();
            AreaTri();
            Quadratic();

        }//end of Main

        static void Circumference ()
        {
            Console.WriteLine("Time for Circumference Of A Circle");
            double radius = GetRadius();
            double circumference = 2 * radius * Math.PI;
            Console.WriteLine("The Circumference is: " + circumference);
        } //end of Circumference

        static void AreaCirc()
        {
            Console.WriteLine("Time for Area Of A Circle");
            double radius = GetRadius();
            double areaCirc = radius * radius * Math.PI;
            Console.WriteLine("The Area is: " + areaCirc);
        } //end of Area

        static void Volume()
        {
            Console.WriteLine("Time for Volume Of A Hemisphere");
            double radius = GetRadius();
            double volume = radius * radius * Math.PI;
            Console.WriteLine("The Volume is: " + volume);
        } //end of Volume

        static void AreaTri()
        {
            Console.WriteLine("Time for Area Of A Triangle (Heron's Formula)");
            double a, b, c;
            ( a , b, c) = GetAbc();
            double p = (a + b + c) / 2 ;
            double areaTri = Math.Sqrt( p * (p - a) * (p - b) * (p - c));
            Console.WriteLine("The Area is: " + areaTri);
        } //end of AreaTri

        static void Quadratic()
        {
            Console.WriteLine("Time for the Quadratic Formula");
            double a, b, c;
            (a, b, c) = GetAbc();
            double x = (-b + Math.Sqrt(b * b - 4.0 * a * c)) / (2.0 * a);
            double y = (-b - Math.Sqrt(b * b - 4.0 * a * c)) / (2.0 * a);
            Console.WriteLine($"Solution 1: {x}");
            Console.WriteLine($"Solution 2: {y}");
            Console.WriteLine("Yay! We are all done!!");

        } //end of Quadratic

        static double GetRadius()
        {
            Console.Write("Radius: ");
            double radius = double.Parse(Console.ReadLine());
            return radius;
        } //end of GetRadius

        static (double, double, double) GetAbc()
        {
            Console.Write("a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("b: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("c: ");
            double c = double.Parse(Console.ReadLine());
            return ( a , b , c );

        } //end of GetAbc
    }
}

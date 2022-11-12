using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TP03
{
    public class Point
    {
        private double x;
        private double y;
        // Constructeur de la classe par défaut
        public Point()
        {
            this.x = 0;
            this.y = 0;
        }

        // Constructeur de la classe pour définir un x et y par défaut
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        // Fonctions pour obtenir les positions du x et y ou les définir
        public double getCordX()
        {
            return x;
        }
        public double getCordY()
        {
            return y;
        }
        public void setCordY(double x)
        {
            this.x = x;
        }
        public void setCordY(double y)
        {
            this.y = y;
        }
        public double CalcDistance(Point point)
        {
            double d;
            d = Math.Sqrt(Math.Pow(this.x - point.x, 2) + Math.Pow(this.y - point.y, 2));
            return d;
        }
        public bool Eq(ref Point point)
        {
            return (this.x == point.x) && (this.y == point.y);
        }
        public Point Translation(double x = 0, double y = 0)
        {
            this.x += x;
            this.y += y;
            return this;
        }
        public bool Linearity(Point a, Point b)
        {
            double area = x * (a.y - b.y) + a.x * (b.y - y) + b.x * (y - a.y);
            return (area == 0);
        }

    }
    class Exercise_1
    {
        public static void Main(string[] args)
        {
            Point p1 = new Point(2, 5);
            Point p2 = new Point(3, 8);
            Point p3 = new Point(1, 2);
            Console.WriteLine("p1({0},{1}) ", p1.getCordX(), p1.getCordY());
            Console.WriteLine("p2({0},{1}) ", p2.getCordX(), p2.getCordY());
            Console.WriteLine("the distance between p1 and p2 : " + p1.CalcDistance(p2));
            Console.Write("Linearity between p1({0},{1}) and p2({2},{3}) and p3({4},{5}) : ", p1.getCordX(), p1.getCordY(), p2.getCordX(), p2.getCordY(), p3.getCordX(), p3.getCordY());
            if (p1.Linearity(p2, p3))
            {
                Console.WriteLine("true");

            }
            else
            {
                Console.WriteLine("false");
            }
            Console.ReadKey();
        }
    }
}

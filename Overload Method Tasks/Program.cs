using System;

namespace Overload_Tasks
{
    class Program
    {
        static int Main()
        {

            Console.WriteLine(Area(6, "cycle"));
            Console.WriteLine(Area(10, 15, "rectangular"));
            Console.WriteLine(Area(3, 4, 6, "Rectangular parallelepiped"));
            Console.WriteLine(Perimetr(10, 30, 50, "The perimetr of a circle drawn inside a triangle"));
            Console.WriteLine(Field(6, 10, "The area of a circle drawn inside a triangle"));
            Console.ReadLine();

            return 0;
        }


        static int Area(int radius, string figure)
        {
            int result;
            if (figure == "cycle")
            {
                result = radius * radius * 3;
            }
            else
            {
                result = -1;
            }
            return result;
        }

        static int Area(int width, int height, string figure)
        {
            int result;
            if (figure == "rectangular")
            {
                result = width * height;
            }
            else
            {
                result = -1;
            }
            return result;
        }

        static int Area(int a, int b, int c, string figure)
        {
            int result;
            if (figure == "Rectangular parallelepiped")
            {
                result = (a * b + a * c + b * c) * 2;
            }
            else
            {
                result = -1;
            }
            return result;
        }

        static int Perimetr(int a, int b, int c, string figure)
        {
            int result;
            if (figure == "The perimetr of a circle drawn inside a triangle")
            {
                result = (a + b + c) / 2;
            }
            else
            {
                result = -1;
            }
            return result;
        }

        static int Field(int perimetr, int radius, string figure)
        {
            int result;
            if (figure == "The area of a circle drawn inside a triangle")
            {
                result = perimetr * radius;
            }
            else
            {
                result = -1;
            }
            return result;
        }
    }
}

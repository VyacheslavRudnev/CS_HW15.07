using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain2
{
    namespace Triangle
    {
        public class Figure
        {
            public int x;
            public int y;
            public int z;

            public int X
            {
                get { return x; }
                set { x = value; }
            }

            public int Y
            {
                get { return y; }
                set { y = value; }
            }

            public int Z
            {
                get { return z; }
                set { z = value; }
            }
            public Figure() { }
            public Figure(int x, int y, int z)
            {
                this.x = x;
                this.y = y;
                this.z = z;
            }
            public void IsTriangle()
            {
                if (x > 0 && y > 0 && z > 0)
                {
                    if (x + y >= z && x + z >= y && y + z >= x)
                    {
                        if (x == y && y == z)
                        {
                            Console.WriteLine("Трикутник існує. Трикутник рівносторонній");
                        }
                        else if (x == y || x == z || y == z)
                        {
                            Console.WriteLine("Трикутник існує. Трикутник рівнобедрений");
                        }
                        else
                        {
                            Console.WriteLine("Трикутник існує");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Трикутник не існує. Довжина кожної сторони трикутника повинна бути більше 0");
                }
            }
        }
    }

    namespace Rectangle
    {
        public class Figure
        {
            public int x;
            public int y;
            public int z;

            public int X
            {
                get { return x; }
                set { x = value; }
            }

            public int Y
            {
                get { return y; }
                set { y = value; }
            }
            public int Z
            {
                get { return z; }
                set { z = value; }
            }
            public Figure() { }
            public Figure(int x, int y, int z)
            {
                this.x = x;
                this.y = y;
                this.z = z;
            }
            public void IsRectangle()
            {
                if ((x != 0 && y != 0 && z == 0 && x != y) ||
                    (x != 0 && y == 0 && z != 0 && x != z) ||
                    (x == 0 && y != 0 && z != 0 && y != z))
                {
                    Console.WriteLine("Прямокутник існує");
                }
                else
                {
                    Console.WriteLine("Прямокутник не існує");
                }
            }
        }
    }
    namespace Square
    {
        public class Figure
        {
            public int x;
            public int y;
            public int z;

            public int X
            {
                get { return x; }
                set { x = value; }
            }
            public int Y
            {
                get { return y; }
                set { y = value; }
            }
            public int Z
            {
                get { return z; }
                set { z = value; }
            }

            public Figure() { }
            public Figure(int x, int y, int z)
            {
                this.x = x;
                this.y = y;
                this.z = z;
            }
            public void IsSquare()
            {
                if ((z == 0 && x == y) || (x == 0 && y == z) || (y == 0 && x == z))
                {
                    Console.WriteLine("Квадрат існує");
                }
                else
                {
                    Console.WriteLine("Квадрат не існує");
                }
            }
        }
    }
}

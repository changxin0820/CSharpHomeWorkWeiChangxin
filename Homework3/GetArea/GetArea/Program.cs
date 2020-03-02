using System;

namespace GetArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(10.0,1.0);
            r.getarea();
            Square s = new Square(10.0);
            s.getarea();
            Triangle tri = new Triangle(3.0, 4.0, 5.0);
            tri.getarea();
        }

        interface Area
        {

            bool judge();
            void getarea();


        }


        class Rectangle : Area
        {
            double lline;
            double sline;
            double area;
            public Rectangle(double a, double b)
            {
                lline = a;
                sline = b;
            }
            
            public bool judge()
            {
                return lline > 0 && sline > 0;
                
            }
             public void getarea()
            {
                if (!judge())
                {
                    Console.WriteLine("该长方形不合法！");
                    return;
                }
                area = lline * sline;
                Console.WriteLine("该长方形的面积为：" + area);

            }
    
        }
       
        class Square:Area
        {
            double line;
            double area;
            public Square (double a)
            {
                line = a;
            }
            public bool judge()
            {
                return line > 0;
                
            }
            public void getarea()
            {
                if (!judge())
                {
                    Console.WriteLine("该正方形形状不合法！");
                    return;
                }
                area = line * line;
                Console.WriteLine("该正方形的面积为：" + area);
            }

        }
        class Triangle:Area
        {
            double aline;
            double bline;
            double cline;
            double high;
            public Triangle (double a,double b,double c)
            {
                aline = a;
                bline = b;
                cline = c;
            }
            public bool judge()
            {
                return aline > 0 && bline > 0&&cline>0&&aline+bline>cline&&aline+cline>bline&&bline+cline>aline;
               
            }
            public void getarea()
            {
                if (!judge())
                {
                    Console.WriteLine("该三角形不合法！");
                    return;
                }
                double p = (aline + bline + cline) / 2;
                double area = Math.Sqrt(p * (p - aline) * (p - bline) * (p - cline));
                Console.WriteLine("该三角形的面积为:" + area);
            }
        }
     

    }
}

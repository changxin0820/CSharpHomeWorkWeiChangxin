using System;

namespace ShapeFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeFactory rectangleFactory = new RectangleFactory();
            ShapeFactory squareFactory = new SquareFactory();
            ShapeFactory tritangleFactory = new TritangleFactory();
            int allarea = 0;
            for (int i = 0; i < 10; i++)
            {
               
                Random random = new Random(); //在外面生成对象
                int r = random.Next(1, 4);
                switch (r)
                {
                    case 1:
                        
                        allarea+=rectangleFactory.createShape().getarea();
                        Console.WriteLine("产生了一个长方形，面积为：{0}", rectangleFactory.createShape().getarea());
                        break;
                    case 2:
                        allarea += squareFactory.createShape().getarea();
                        Console.WriteLine("产生了一个正方形，面积为：{0}", squareFactory.createShape().getarea());
                        break;
                    case 3:
                        allarea += tritangleFactory.createShape().getarea();
                        Console.WriteLine("产生了一个三角形，面积为：{0}", tritangleFactory.createShape().getarea());
                        break;


                }
                
            }
            Console.WriteLine("十个形状总面积为：{0}", allarea);

        }
        

        public abstract class Shape
        {
          
            public abstract int getarea();
        }
        public class Rectangle : Shape
        {
            
            public override int getarea()
            {
                Random random = new Random(); //在外面生成对象
                int longline = random.Next(1, 10);
                int shortline = random.Next(1, 10);
                int area = longline * shortline;
               return area;
                throw new NotImplementedException();
            }
        }
        public class Square : Shape
        {

            public override int getarea()
            {
                Random random = new Random(); //在外面生成对象
                int line = random.Next(1, 10);
               
                int area = line * line;

                return area;
                throw new NotImplementedException();

            }
        }
         public class Tritangle : Shape
        {
            
            public override int getarea()
            {
                Random random = new Random(); //在外面生成对象
                int aline = random.Next(6, 10);
                int bline = random.Next(6, 10);
                int cline = random.Next(6, 10);
                double p = (aline +bline + cline )/ 2;
                double area = Math.Sqrt(p * (p - aline) * (p - bline) * (p - cline));
                return (int)area;
                throw new NotImplementedException();
            }
        }
        public abstract class ShapeFactory
        {
            public abstract Shape createShape();
        }
        public class RectangleFactory : ShapeFactory
        {
            public override Shape createShape()
            {
                return new Rectangle();
                throw new NotImplementedException();
            }
        }
        public class SquareFactory : ShapeFactory
        {
            public override Shape createShape()
            {
                return new Square();
                throw new NotImplementedException();
            }
        }
        public class TritangleFactory : ShapeFactory
        {
            public override Shape createShape()
            {
                return new Tritangle();
                throw new NotImplementedException();
            }
        }




    }
}

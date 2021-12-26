using System;

namespace HW9_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*     HW9
             *     Разработать абстрактный класс "Геометрическая Фигура" с методами 
             * "Площадь фигуры" и "Периметр Фигуры". Разработать классы наследники:
             * Треугольник, квадрат, Ромб, прямоугольник, параллелограмм, трапеция,
             * круг, Эллипс. Реализовать конструкторы, которые однозначно определяют
             * объекты днных классов.
             *      Реализовать класс "Составноая фигура", который может состоять 
             * из любого количества "Геометрических фигур". Для данного класса 
             * определить метод нахождения площади фигуры. Создать диаграмму 
             * взаимоотношений классов.
             * 
             *      HW10
             *      Для предыдущего ДЗ на наследование геометрических фигур реализовать 
             *  2 интерфейса:  IDrawable и IPrintable. Первый имеет метод draw для 
             *  отрисовки фигуры на консоли (псевдографика), второй print для печати 
             *  в консоли. Фигуры, которые хотите рисовать, должны имплементить первый 
             *  интерфейс, остальные второй.
             *  
             *  Сделать класс сцена с массивом фигур базового 
             *  типа (абстрактный класс из предыдущего ДЗ). 
             *  
             *  Сделать метод «отрисовать сцену», 
             *  который перебирает все фигуры и пытается привести к нужному интерфейсу 
             *  (используйте as или is) и вызвать нужный метод (draw или print).
             *  
             */

            Figure rect = new Rectangle("ABCD", 3, 5);
            Console.WriteLine(rect);
            Console.WriteLine($"Retangle's {rect.Name} PERIMETER = {rect.Perimeter()}");
            Console.WriteLine($"Retangle's {rect.Name} AREA = {rect.Area()}\n");

            Figure circle = new Circle("O", 9);
            Console.WriteLine(circle);
            Console.WriteLine($"Circle's {circle.Name} PERIMETER = {circle.Perimeter()}");
            Console.WriteLine($"Circle's {circle.Name} AREA = {circle.Area()}\n");

            Figure ellipse = new Ellipse("A", 4, 8);
            Console.WriteLine(ellipse);
            Console.WriteLine($"Ellipse's {ellipse.Name} PERIMETER = {ellipse.Perimeter()}");
            Console.WriteLine($"Ellipse's {ellipse.Name} AREA = {ellipse.Area()}\n");

            Figure square = new Square("EFGH", 5);
            Console.WriteLine(square);
            Console.WriteLine($"Square's {square.Name} PERIMETER = {square.Perimeter()}");
            Console.WriteLine($"Square's {square.Name} AREA = {square.Area()}\n");

            Figure trapezoid = new Trapezoid("IJKL", 2, 4, 5, 7);
            Console.WriteLine(trapezoid);
            Console.WriteLine($"Trapezoid's {trapezoid.Name} PERIMETER = {trapezoid.Perimeter()}");
            Console.WriteLine($"Trapezoid's {trapezoid.Name} AREA = {trapezoid.Area()}\n");

            Figure triangle = new Triangle("MNO", 3, 4, 7);
            Console.WriteLine(triangle);
            Console.WriteLine($"Triangle's {triangle.Name} PERIMETER = {triangle.Perimeter()}");
            Console.WriteLine($"Triangle's {triangle.Name} AREA = {triangle.Area()} \n");

            Figure parallelogram = new Parallelogram("PQRS", 4, 8, 6);
            Console.WriteLine(parallelogram);
            Console.WriteLine($"Parallelogram's {parallelogram.Name} PERIMETER = {parallelogram.Perimeter()}");
            Console.WriteLine($"Parallelogram's {parallelogram.Name} AREA = {parallelogram.Area()} \n");

            Figure rhombus = new Rhombus("TUVW", 6, 10);
            Console.WriteLine(rhombus);
            Console.WriteLine($"Rhombus's {rhombus.Name} PERIMETER = {rhombus.Perimeter()}");
            Console.WriteLine($"Rhombus's {rhombus.Name} AREA = {rhombus.Area()}\n");


            Scene pool = new Scene();
            pool.AddFigure(rect);
            pool.AddFigure(circle);
            pool.AddFigure(ellipse);
            pool.AddFigure(square);
            pool.AddFigure(trapezoid);
            pool.AddFigure(triangle);
            pool.AddFigure(parallelogram);
            pool.AddFigure(rhombus);

            

            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("\n\nSCENE PRINT:\n");
            pool.DrawScene();
            Console.WriteLine("-----------------------------------------------------------");
            
            
            Console.WriteLine($"\nTotal Perimeter = {pool.GetTotalPerimeter()}");
            Console.WriteLine($"\nTotal Area = {pool.GetTotalArea()}");

        }
    }
}

using System;

namespace CW_20211226
{
    class Program
    {
        static void Main(string[] args)
        {
            //ComplexNum firstNum = new ComplexNum(0,0);
            //ComplexNum secondNum = new ComplexNum(2,1);

            //ComplexNum a;
            //double b = 10;
            //a = b;

            //Console.WriteLine(a);



            //Point3D p = new Point3D("P", 1.1, 2.2, 3.3);
            //Console.WriteLine(p);
            //Console.WriteLine($"X = {p[0]}");
            //Console.WriteLine($"Y = {p[1]}");
            //Console.WriteLine($"Z = {p[2]}");
            //p[1] = 4;
            //Console.WriteLine(p);


            Point3D p1= new Point3D("P1", 1, 1, 1);
            Point3D p2= new Point3D("P2", 2,2,2);
            Point3D p3= new Point3D("P3", 3,3,3);

            Curve line = new Curve("C");
            line.AddPoint(p1);
            line.AddPoint(p2);
            line.AddPoint(p3);

            Console.WriteLine(line);

            Console.WriteLine(line[0]);
            Console.WriteLine(line[0,2]);
        }
    }
}

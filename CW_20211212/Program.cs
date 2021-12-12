using System;

namespace CW_20211212
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure figure1 = new Rectangle("ABCD", 4, 5);
            //Console.WriteLine(figure1);
            //Console.WriteLine(figure1.P());
            //Console.WriteLine(figure1.S());
            Figure figure2 = new Circle("RD", 1/Math.PI);
            //Console.WriteLine(figure2);
            //Console.WriteLine(figure2.P());
            //Console.WriteLine(figure2.S());
            Figure figure3 = new Circle("BIG CIRCLE", 200);
            Figure figure4 = new Rectangle("BIG RECTANGLE", 10, 20);

            FigurePool pool = new FigurePool();
            Console.WriteLine(pool);
            pool.AddFigure(figure1);
           // Console.WriteLine(pool.ToString());
            pool.AddFigure(figure2);
            //Console.WriteLine(pool.ToString());
            pool.AddFigure(figure3);
            pool.AddFigure(figure4);
            pool.Print();
            pool.ConsoleDraw();
            //Console.WriteLine($"Common P = {pool.getTotalP()}");
            //Console.WriteLine($"Common S = {pool.getTotalS()}");



            //IConsolePrintable printable = new Rectangle("DCRF", 3,2);
            //printable.Print();
            //IConsoleDrawable drawable = new Rectangle("ABCD", 4,6);
            //drawable.ConsoleDraw();
        }
    }
}

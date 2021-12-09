using System;

namespace HW7_CSharp
{
    class Program
    {
        

        static ComplexNum ComplexAddition(ComplexNum _firstComplexNum, ComplexNum _secondComplexNum)
        {
            ComplexNum complexSumResult = new ComplexNum();
            complexSumResult.numA = _firstComplexNum.numA + _secondComplexNum.numA;
            complexSumResult.numB = _firstComplexNum.numB + _secondComplexNum.numB;
            return complexSumResult;
        }
        static ComplexNum ComplexSubtraction(ComplexNum _firstComplexNum, ComplexNum _secondComplexNum)
        {
            ComplexNum complexSubtractionResult = new ComplexNum();
            complexSubtractionResult.numA = _firstComplexNum.numA - _secondComplexNum.numA;
            complexSubtractionResult.numB = _firstComplexNum.numB - _secondComplexNum.numB;
            return complexSubtractionResult;
        }
        
        static ComplexNum ComplexMultiplication(ComplexNum _firstComplexNum, ComplexNum _secondComplexNum)
        {
            ComplexNum complexMultiplicationResult = new ComplexNum();
            complexMultiplicationResult.numA = _firstComplexNum.numA * _secondComplexNum.numA -
                                               _firstComplexNum.numB * _secondComplexNum.numB;
            complexMultiplicationResult.numB = _firstComplexNum.numA * _secondComplexNum.numB +
                                               _firstComplexNum.numB * _secondComplexNum.numA;
            return complexMultiplicationResult;
        }
        static ComplexNum ComplexDivision(ComplexNum _firstComplexNum, ComplexNum _secondComplexNum)
        {
            ComplexNum complexNumDivisionResult = new ComplexNum();
            complexNumDivisionResult.numA = (_firstComplexNum.numA * _secondComplexNum.numA +
                                             _firstComplexNum.numB * _secondComplexNum.numB) /
                                             (Math.Pow(_secondComplexNum.numA, 2) +
                                              Math.Pow(_secondComplexNum.numB, 2));
            complexNumDivisionResult.numB = (_firstComplexNum.numB * _secondComplexNum.numA -
                                             _firstComplexNum.numA * _secondComplexNum.numB) /
                                             (Math.Pow(_secondComplexNum.numA, 2) +
                                              Math.Pow(_secondComplexNum.numB, 2));
            return complexNumDivisionResult;
        }







        static void Main(string[] args)
        {
            //  1.  Создайте структуру, описывающую комплексное число. Реализуйте арифметические операции
            //      с комплексными числами: сумму, разность, умножение, деление.

            //  2.  Реализовать структуру "Автомобиль" (длина, клирес (высота посадки), объем двигателя,
            //      мощность двигателя, диаметр колес, цвет, тип коробки передач). Создайте функции для
            //      задания значений, отображения значений, поиска значений.

            ComplexNum first = new ComplexNum(4,6);
            ComplexNum second = new ComplexNum(2, -9);
            Console.WriteLine();
            Console.WriteLine($"First complex number  = {first.ToString()}");
            Console.WriteLine($"Second complex number = {second.ToString()}\n");
            Console.WriteLine($"Addition       = {ComplexAddition(first, second).ToString()}");
            Console.WriteLine($"Subtraction    = {ComplexSubtraction(first, second).ToString()}");
            Console.WriteLine($"Multiplication = {ComplexMultiplication(first, second).ToString()}");
            Console.WriteLine($"Division       = {ComplexDivision(first, second).ToString()}");
            Console.WriteLine();




            Auto Car1 = new Auto("First car", 2.4, 0.25, 1.7, 149, 50, CarColor.BLACK, Transmission.MANUAL);

            Console.WriteLine(Car1.ToString());
            Car1.CarName = "Holly";
            Console.WriteLine(Car1.ToString());

        }
    }
}

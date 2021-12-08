using System;

namespace HW7_CSharp
{
    class Program
    {
        struct ComplexNum
        {
            public double numA;
            public double numB;
            static double i = Math.Sqrt(-1);

            public ComplexNum(double _numA, double _numB)
            {
                this.numA = _numA;
                this.numB = _numB;
            }

            public override string ToString()
            {
                return $"{numA} + {numB}i";
            }

        }

        static ComplexNum ComplexSum(ComplexNum _firstComplexNum, ComplexNum _secondComplexNum)
            {
                ComplexNum complexSumResult = new ComplexNum();
                complexSumResult.numA = _firstComplexNum.numA + _secondComplexNum.numA;
                complexSumResult.numB = _firstComplexNum.numB + _secondComplexNum.numB;
                return complexSumResult;
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
            Console.Write(ComplexSum(first, second).ToString());
        
            
        }
    }
}

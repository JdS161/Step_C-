using System;

namespace CW_20211219
{
    class Program
    {
        static void Main(string[] args)
        {
            //-------------------------------------------------------------------------------------------------
            //--------------------------------------OPERATOR OVERLOADS-----------------------------------------
            //-------------------------------------------------------------------------------------------------

            ComplexNum firstCoplexNum = new ComplexNum(1, 2);
            ComplexNum secondCoplexNum = new ComplexNum(3, 4);

            ComplexNum resultComplexNum = firstCoplexNum * secondCoplexNum;
            double num = 10;
            ComplexNum resultComplexNum2 = firstCoplexNum * num;
            double num2 = 20;
            ComplexNum resultComplexNum3 = num2 * secondCoplexNum;

            Console.WriteLine($"{firstCoplexNum} * {secondCoplexNum} = {resultComplexNum}");
            Console.WriteLine($"{firstCoplexNum} * {num} = {resultComplexNum2}");
            Console.WriteLine($"{num2} * {secondCoplexNum} = {resultComplexNum3}");
            Console.WriteLine($"{firstCoplexNum} = {-firstCoplexNum}");


            ComplexNum resultComplexNum4 =firstCoplexNum++;
            ComplexNum resultComplexNum5 =secondCoplexNum--;
            Console.WriteLine($"{firstCoplexNum} = incremented {resultComplexNum4}");
            Console.WriteLine($"{secondCoplexNum} = decremented {resultComplexNum5}");

        }
    }
}

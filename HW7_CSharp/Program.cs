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


        static Auto FillAuto()
        {
            Auto car = new Auto();
            Console.Write("Fill the parameters of he car:\n" +
                              "\nName of the car: ");
            car.CarName = Console.ReadLine();
            Console.Write("Length of the car: ");
            car.CarLength = Convert.ToDouble(Console.ReadLine());
            Console.Write("Clearance of the car: ");
            car.CarClearance = Convert.ToDouble(Console.ReadLine());
            Console.Write("Engine's displacement of the car: ");
            car.CarEngineDisplacement = Convert.ToDouble(Console.ReadLine());
            Console.Write("Engine's power of the car: ");
            car.CarEnginePower = Convert.ToDouble(Console.ReadLine());
            Console.Write("Wheel's diameter of the car: ");
            car.CarWheelDiameter = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Color of the car by choosing one of the following options:" +
                "\n(1)BLACK (2)WHITE (3)GREEN (4)YELLOW (5)BLUE (6)RED (7)CUSTOM: ");
            int colorOption = Convert.ToInt32(Console.ReadLine());
            switch (colorOption)
            {
                case 1:
                    car.CarColor = CarColor.BLACK;
                    break;
                case 2:
                    car.CarColor = CarColor.WHITE;
                    break;
                case 3:
                    car.CarColor = CarColor.GREEN;
                    break;
                case 4:
                    car.CarColor = CarColor.YELLOW;
                    break;
                case 5:
                    car.CarColor = CarColor.BLUE;
                    break;
                case 6:
                    car.CarColor = CarColor.RED;
                    break;
                case 7:
                    car.CarColor = CarColor.CUSTOM;
                    break;
                default:
                    Console.WriteLine("Wrong option choosen.");
                    car.CarColor = CarColor.NONE;
                    break;
            }

            Console.Write("Transmission type of the car by choosing one of the following options:" +
                "\n(1)MANUAL (2)AUTOMATIC (3)SEMI-AUTOMATIC: ");
            int transmissionOption = Convert.ToInt32(Console.ReadLine());
            switch (transmissionOption)
            {
                case 1:
                    car.CarGearBox = Transmission.MANUAL;
                    break;
                case 2:
                    car.CarGearBox = Transmission.AUTOMATIC;
                    break;
                case 3:
                    car.CarGearBox = Transmission.SEMIAUTOMATIC;
                    break;
                default:
                    Console.WriteLine("Wrong option choosen.");
                    car.CarGearBox = Transmission.NONE;
                    break;
            }
            return car;
        }
        static string Search(Auto _auto, int _option)
        {            
            switch (_option)
            {
                case 1:
                    return _auto.CarName.ToString();
                case 2:
                    return _auto.CarLength.ToString();
                case 3:
                    return _auto.CarClearance.ToString();                    
                case 4:
                    return _auto.CarEngineDisplacement.ToString();                    
                case 5:
                    return _auto.CarEnginePower.ToString();                   
                case 6:
                    return _auto.CarWheelDiameter.ToString();                    
                case 7:
                    return _auto.CarColor.ToString();                   
                case 8:
                    return _auto.CarGearBox.ToString();
                default:
                    return "Wrong option selected";
                    
            }            
        }

    

        static void Main(string[] args)
        {
            //  1.  Создайте структуру, описывающую комплексное число. Реализуйте арифметические операции
            //      с комплексными числами: сумму, разность, умножение, деление.
            
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

            //  2.  Реализовать структуру "Автомобиль" (длина, клирес (высота посадки), объем двигателя,
            //      мощность двигателя, диаметр колес, цвет, тип коробки передач). Создайте функции для
            //      задания значений, отображения значений, поиска значений.

            Auto Car1 = new Auto();

            Console.WriteLine(Car1.ToString());
           
            Console.WriteLine();
            Car1 = FillAuto();
            Console.WriteLine(Car1.ToString());

            while (Console.ReadKey().Key != ConsoleKey.Escape)
            {
                System.Console.Clear();
                Console.WriteLine("\nChoose a parameter you want to display:" +
                               "\n(1) - car's name;" +
                               "\n(2) - car's length;" +
                               "\n(3) - car's clearance;" +
                               "\n(4) - car's engine displacement;" +
                               "\n(5) - car's engine power;" +
                               "\n(6) - car's wheel diameter;" +
                               "\n(7) - car's color;" +
                               "\n(8) - car's transmittion type.");

                Console.Write("\nYour selection: ");
                int option = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine(Search(Car1, option));
                Console.WriteLine("\nPress <Esc> for exit, <Enter> to continue...\n");
            }
            
            Console.WriteLine(Car1.ToString());
            Console.ReadKey();

        }
    }
}

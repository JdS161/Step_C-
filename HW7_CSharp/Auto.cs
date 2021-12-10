using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW7_CSharp
{
    enum CarColor
    {
        NONE,
        BLACK,
        WHITE,
        GREEN,
        YELLOW,
        BLUE,
        RED,
        CUSTOM
    }
    enum Transmission
    {
        NONE,
        MANUAL,
        AUTOMATIC,
        SEMIAUTOMATIC
    }
    struct Auto
    {
        private string carName;
        private double carLength;
        private double carClearance;
        private double carEngineDisplacement;
        private double carEnginePower;
        private double carWheelDiameter;
        private CarColor carColor;
        private Transmission carGearBox;

        //Car properties
        public string CarName
        {
            get { return carName; }
            set { carName = value; }
        }
        public double CarLength
        {
            get { return carLength; }
            set { carLength = value; }
        }
        public double CarClearance
        {
            get { return carClearance; }
            set { carClearance = value; }
        }
        public double CarEngineDisplacement
        {
            get { return carEngineDisplacement; }
            set { carEngineDisplacement = value; }
        }
        public double CarEnginePower
        {
            get { return carEnginePower; }
            set { carEnginePower = value; }
        }
        public double CarWheelDiameter
        {
            get { return carWheelDiameter; }
            set { carWheelDiameter = value; }
        }
        public CarColor CarColor
        {
            get { return CarColor; }
            set { carColor = value; }
        }
        public Transmission CarGearBox
        {
            get { return carGearBox; }
            set { carGearBox = value; }
        }

        public Auto(string _carName,
                    double _carLength,
                    double _carClearance,
                    double _carEngineDisplacement,
                    double _carEnginePower,
                    double _carWheelDiameter,
                    CarColor _carColor,
                    Transmission _carGearBox)
        {
            this.carName = _carName;
            this.carLength = _carLength;
            this.carClearance = _carClearance;
            this.carEngineDisplacement = _carEngineDisplacement;
            this.carEnginePower = _carEnginePower;
            this.carWheelDiameter = _carWheelDiameter;
            this.carColor = _carColor;
            this.carGearBox = _carGearBox;
        }

        public override string ToString()
        {
            return  $"\n CAR:" +
                    $"\nName                  = {carName}" +
                    $"\nLength                = {carLength}" +
                    $"\nClearance             = {carClearance}" +
                    $"\nEngine Displacement   = {carEngineDisplacement}" +
                    $"\nEngine Power          = {carEnginePower}" +
                    $"\nWheel Diameter        = {carWheelDiameter}" +
                    $"\nColor                 = {carColor}" +
                    $"\nTransmission          = {carGearBox}";
        }
    }




}

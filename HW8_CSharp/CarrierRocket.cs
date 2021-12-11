using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8_CSharp
{
    enum CarrierType
    {
        NONE,
        SUBORBITAL,
        ORBITAL,
        INTERPLANETARY,
        INTERSTELLAR,
        INTERGALACTIC
    }
    enum CarrierMassType
    {
        NONE,
        SMALL_LIFT,
        MEDIUM_LIFT,
        HEAVY_LIFT,
        SUPER_HEAVY_LIFT
    }
    enum Spacecraft
    {
        NONE,
        ROBOTIC_SATELLITE,
        ROBOTIC_SPACE_PROBE,
        ROBOTIC_CARGO_SPACECRAFT,
        HUMAN_SPACE_CAPSULE,
        HUMAN_SPACE_STATION,
        HUMAN_SPACEPLANE
    }
    enum CountryOfOrigin
    {
        NONE,
        CHINA,
        EU,
        RUSSIA,
        USA,
        USSR
    }

    class CarrierRocket
    {
        private static double escapeSpeed;
        private static int lineKarman = 100000;


        private double carrierWeight;
        private bool carrierPassenger = false;
        private CarrierType carrierType;
        private CarrierMassType carrierMassType;
        private Spacecraft carrierSpacecraft;

        public CarrierRocket()
        {
            CarrierName = "EMPTY";
            CarrierLength = 0;
            CarrierWeight = 0;
            CarrierReusable = false;
            CarrierPrivate = false;
            CarrierType = CarrierType.NONE;
            carrierMassType = CarrierMassType.NONE;
            carrierSpacecraft = Spacecraft.NONE;
            CarrierCountry = CountryOfOrigin.NONE;
        }
        public CarrierRocket(string _name,
                             double _length,
                             double _weight,
                             bool   _reusable,
                             bool   _private,
                             bool   _passenger,
                             CarrierType _carrierType,
                             CountryOfOrigin _country)
        {
            this.CarrierName        = _name;
            this.CarrierLength      = _length;
            this.CarrierWeight      = _weight;
            this.CarrierReusable    = _reusable;
            this.CarrierPrivate     = _private;
            this.CarrierPassenger   = _passenger;
            this.CarrierType        = _carrierType;
            this.CarrierCountry     = _country;
        }

        static CarrierRocket()
        {
            EscapeSpeed = 40270;
        }

        //Properties
        public string CarrierName { get; set; }
        public double CarrierLength { get; set; }
        public double CarrierWeight
        {
            get { return carrierWeight; }
            set
            {
                carrierWeight = value;
                if (value < 2000)
                {
                    carrierMassType = CarrierMassType.SMALL_LIFT;
                }
                else if (value >= 2000 && value < 20000)
                {
                    carrierMassType = CarrierMassType.MEDIUM_LIFT;
                }
                else if (value >= 20000 && value < 50000)
                {
                    carrierMassType = CarrierMassType.HEAVY_LIFT;
                }
                else if (value >= 50000)
                {
                    carrierMassType = CarrierMassType.SUPER_HEAVY_LIFT;
                }
                else
                {
                    carrierMassType = CarrierMassType.NONE;
                }
            }
        }
        public bool CarrierReusable { get; set; } = false;
        public bool CarrierPrivate { get; set; } = false;
        public bool CarrierPassenger
        {
            get { return carrierPassenger; }
            set
            {
                carrierPassenger = value;
                if (carrierPassenger == true)
                {
                    Console.WriteLine("Choose your type of the PASSENGER spacecraft:" +
                        $"\n (1)SPACE_CAPSULE (2)SPACE_STATION (3)SPACEPLANE");
                    int spacecraftOption = Convert.ToInt32(Console.ReadLine());
                    switch (spacecraftOption)
                    {
                        case 1:
                            carrierSpacecraft = Spacecraft.HUMAN_SPACE_CAPSULE;
                            break;
                        case 2:
                            carrierSpacecraft = Spacecraft.HUMAN_SPACE_STATION;
                            break;
                        case 3:
                            carrierSpacecraft = Spacecraft.HUMAN_SPACEPLANE;
                            break;

                        default:
                            carrierSpacecraft = Spacecraft.NONE;
                            break;
                    }
                }
                if (carrierPassenger == false)
                {
                    Console.WriteLine("Choose your type of the ROBOTIC spacecraft:" +
                        $"\n (1)SATELLITE (2)SPACE_PROBE (3)CARGO_SPACECRAFT");
                    int spacecraftOption = Convert.ToInt32(Console.ReadLine());
                    switch (spacecraftOption)
                    {
                        case 1:
                            carrierSpacecraft = Spacecraft.ROBOTIC_SATELLITE;
                            break;
                        case 2:
                            carrierSpacecraft = Spacecraft.ROBOTIC_SPACE_PROBE;
                            break;
                        case 3:
                            carrierSpacecraft = Spacecraft.ROBOTIC_CARGO_SPACECRAFT;
                            break;
                        default:
                            carrierSpacecraft = Spacecraft.NONE;
                            break;
                    }
                }
            }
        }
        public CarrierType CarrierType
        {
            get { return carrierType; }
            set {

                Console.WriteLine("Choose your type of the carrier:" +
                      $"\n (1)SUBORBITAL (2)ORBITAL (3)INTERPLANETARY (4)INTERSTELLAR (5)INTERGALACTIC");
                int carrierTypeOption = Convert.ToInt32(Console.ReadLine());
                switch (carrierTypeOption)
                {
                    case 1:
                        carrierType = CarrierType.SUBORBITAL;
                        break;
                    case 2:
                        carrierType = CarrierType.ORBITAL;
                        break;
                    case 3:
                        carrierType = CarrierType.INTERPLANETARY;
                        break;
                    case 4:
                        carrierType = CarrierType.INTERSTELLAR;
                        break;
                    case 5:
                        carrierType = CarrierType.INTERGALACTIC;
                        break;
                    default:
                        carrierType = CarrierType.NONE;
                        break;
                }
            }
        }
        public CountryOfOrigin CarrierCountry { get; set; } = CountryOfOrigin.NONE;

        public static double EscapeSpeed
            {
            get { return escapeSpeed; }
            set { escapeSpeed = value; }
            }
        public static int LineKarman
        {
            get { return lineKarman; }
        }

        public override string ToString()
        {
            return $"\nLAUNCHER:" +
                   $"\nNAME:          {CarrierName}" +
                   $"\nLENGTH:        {CarrierLength}" +
                   $"\nWEIGHT:        {CarrierWeight} => {carrierMassType}" +
                   $"\nCARRIER TYPE:  {CarrierType}" +
                   $"\nREUSABILITY:   {CarrierReusable}" +
                   $"\nPRIVATE:       {CarrierPrivate}" +
                   $"\nPASSENGER:     {CarrierPassenger} => {carrierSpacecraft}" +
                   $"\nORIGIN:        {CarrierCountry}";
        }

    }
}

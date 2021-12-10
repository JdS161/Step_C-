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
        private double carrierWeight;
        private CarrierType carrierType;
        private CarrierMassType carrierMassType;
        private Spacecraft carrierSpacecraft;
        private CountryOfOrigin carrierCountry;

        public CarrierRocket()
        {
            CarrierName = "EMPTY";
            CarrierLength = 0;
            carrierWeight = 0;
            CarrierReusable = false;
            CarrierPrivate = false;
            carrierType = CarrierType.NONE;
            carrierMassType = CarrierMassType.NONE;
            carrierSpacecraft = Spacecraft.NONE;
            carrierCountry = CountryOfOrigin.NONE;
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
        public Spacecraft CarrierSpacraft { get; set; }
        public CountryOfOrigin CarrierCountry { get; set; } = CountryOfOrigin.NONE;
        public CarrierType CarrierType { get; set; }




    }
}

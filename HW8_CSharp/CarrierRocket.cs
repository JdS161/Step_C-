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
        HEAVE_LIFT,
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
        private string carrierName;
        private double carrierLength;
        private double carrierWeight;
        private bool carrierReusable = false;
        private bool carrierPrivate = false;
        private CarrierType carrierType;
        private CarrierMassType carrierMassType;
        private Spacecraft carrierSpacecraft;
        private CountryOfOrigin carrierCountry;





        public CarrierRocket()
        {
            carrierName = "EMPTY";
            carrierLength = 0;
            carrierWeight = 0;
            carrierReusable = false;
            carrierPrivate = false;
            carrierType = CarrierType.NONE;
            carrierMassType = CarrierMassType.NONE;
            carrierSpacecraft = Spacecraft.NONE;
            carrierCountry = CountryOfOrigin.NONE;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW15_CSharp
{
    enum STATE
    {
        OPERATION,
        SERVICE,
        FAULT
    }
    //EDS - Explosive Detection System
    internal class EDS
    {
        STATE CTState { get; set; }
        bool PowerOn { get; set; } = false;
        bool DoorsClosed { get; set; } = false;
        
        bool GantrySpining { get; set; } =false;
        double GantryVelocity { get; set; }
        bool ConveyorRotating   { get; set; } =false;
        double ConveyorSpeed { get; set; }
        bool XRayOn { get; set; } = false;


        public delegate void OperationDel();
        public static OperationDel operationDel = null;

        public delegate void InServiceDel();
        public static InServiceDel inService = null;


        public delegate void FaultStateDel();
        public static FaultStateDel faultState = null;


        public EDS(STATE _CTState, 
                   bool _powerOn,
                   bool _doorsClosed,
                   bool _gantrySpining,
                   double _gantryVelocity,
                   bool _conveyorRoating,
                   double _conveyorSpeed,
                   bool _XRayOn)
        {
            CTState = _CTState;
            PowerOn = _powerOn;
            DoorsClosed = _doorsClosed;
            GantrySpining = _gantrySpining;
            GantryVelocity = _gantryVelocity;
            ConveyorRotating = _conveyorRoating;
            ConveyorSpeed = _conveyorSpeed;
            XRayOn = _XRayOn;
        }
        public EDS(STATE _CTState)
        {
            CTState = _CTState;
        }
        public static void OperationCondition(EDS _eds)
        {
            if (_eds.CTState == STATE.OPERATION)
            {
                _eds.PowerOn = true;
                _eds.DoorsClosed = true;
                _eds.GantrySpining = true;
                _eds.GantryVelocity = 150;
                _eds.ConveyorRotating = true;
                _eds.ConveyorSpeed = 500;
                _eds.XRayOn = true;
            }
        }


        public static void InServiceCondition(EDS _eds)
        {
            if (_eds.CTState == STATE.SERVICE)
            { 
                _eds.PowerOn = true;
                _eds.DoorsClosed = true;
                _eds.GantrySpining = true;
                _eds.GantryVelocity = 150;
                _eds.ConveyorRotating = true;
                _eds.ConveyorSpeed = 500;
                _eds.XRayOn = false;
            }
        }

        public static void FaultCondition(EDS _eds)
        {

        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СW_20220123_Simulation
{
    //class which simulates firealarm system
    internal class FireSystem
    {
        public delegate void AlarmDelegate();

        public static AlarmDelegate alarm = null;



        public static bool CheckSmockLevel()
        {
            Random random = new Random(DateTime.Now.Millisecond);
            if (random.Next(1, 5) == 3)
            {
                MakeAlarm();
                return true;
            }
            return false;
        }

        public static void MakeAlarm()
        {
            //if (alarm != null) 
            //{
            //    alarm.Invoke();
            //}    

            alarm?.Invoke(); // same behavoiur as the lines above

        }


        //cancellation simuation
        //declaration of the false alarm event
        public static event AlarmDelegate falseAlarm;

        // method, which simlates false alarm

        public static bool CheckFalseAlarm()
        {
            Random random = new Random(DateTime.Now.Millisecond);
            if (random.Next(1, 5) == 3)
            {
                MakeFalseAlarm();
                return true;
            }
            return false; // on fine - NOT a false alarm
        }

        public static void MakeFalseAlarm()

        {
            falseAlarm?.Invoke();
        }
    }
}

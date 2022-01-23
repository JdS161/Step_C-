using System;

namespace СW_20220123_Simulation
{
    internal class Program
    {
        static void TestFireSystem()
        {
            // 1. Create a teacher
            Teacher teacher = new Teacher("Jim Halpert");
            // 2. Create Students
            Student[] students = new Student[]
            {
                new Student("Angela"),
                new Student("Creed"),
                new Student("Kevin")

            };
            //3. Connect objects to firealarm system
            FireSystem.alarm += teacher.Evacuation;
            FireSystem.falseAlarm += teacher.CancelEvacuation;
            foreach (Student student in students)
            {
                FireSystem.alarm += student.Evacuation;
                FireSystem.falseAlarm += student.CancelEvacuation;
            }

            //4. Fire Simulation
            while (FireSystem.CheckSmockLevel() == false) 
            {
                Console.WriteLine("Everything is fine, no smoke");
            }
            Console.WriteLine("Office is ON FIRE!!!");


            // 5. False alarm simulation
            while(FireSystem.CheckFalseAlarm() == false)
            {
                Console.WriteLine("DAMN! We're on Fire!");
            }
            Console.WriteLine("Nah! Nevermind!");
        }

        static void Main(string[] args)
        {
            ////1. Simulation of firealarm system

            //Human human = new Teacher("John Doe");
            //Console.WriteLine(human);
            //human.Evacuation();

            //human = new Student("Mike");
            //Console.WriteLine(human);
            //human.Evacuation();

            TestFireSystem();




        }
    }
}

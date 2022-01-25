using System;

namespace Consultation_20220122
{
    class Program
    {
        static void FictiveException()
        {
            throw new System.Exception("That's a fictive exception");
        }

        static void Wrapper()
        {
            try{
                Console.WriteLine("Wrapper started");
                FictiveException();

            }
            catch(Exception ex)
            {
                Console.WriteLine($"Wrapper cathed {ex.Message}");
            }
            Console.WriteLine("Wrapper ended");
        }
        static void Main()
        {
            // try{
            //     Wrapper();
            // }
            // catch(Exception ex){
            //     Console.WriteLine($"Exception catched:{ex.Message}" );
            // }

            SimpleCalculator.Run();



        }
    }
}
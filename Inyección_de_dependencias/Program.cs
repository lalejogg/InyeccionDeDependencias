using System;

namespace Inyección_de_dependencias
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Motor motor = new Motor();
            Auto auto = new Auto();

            //El constructor se hace fuera de la clase y se pasa como parametro
            auto.motor = motor;
            
            Console.WriteLine(auto.getTorque());


            Console.Read();

        }
    }

    class Motor
    {
        public int Torque()
        {
            try
            {
                return 1;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {

            }

        }



    }

    class Auto
    {
        public Motor motor { get; set; }

        public int getTorque()
        {
            return motor.Torque();
        }

    }
}

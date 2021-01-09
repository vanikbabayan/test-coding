using System;

namespace test_coding
{
    class Program
    {
        static void Main(string[] args)
        {
            Car avto = new Car();
            avto.Model = "BMW";
            avto.Series = "X6";
            avto.Color = "white";
            
            while(true)
            { 
                Console.Write("Insert the speet of the car to go: ");
                ConsoleKeyInfo key = Console.ReadKey();

                if(key.Key == ConsoleKey.UpArrow)
                {
                    avto.Boost();
                } else if(key.Key == ConsoleKey.DownArrow)
                {
                    avto.FallTheSpeed();
                }
                Console.WriteLine("The car is going at speed: " + avto.Speed);
            }
        }
    }

    public class Car
    {
        public string Model {get; set;}
        public string Series { get;set; }
        public int Speed {get; set;}
        public string Color {get; set;}
        public int Weight {get; set;}

        public void Drive(int speed)
        {
            if(speed > 200) {
                Console.WriteLine("Stop axper jan.");
            }
            else {
                this.Speed = speed;
            }
        }

        public void Boost()
        {
            if(this.Speed + 2 > 200)
            {
                Console.WriteLine("Stop axper jan.");
                return;
            }
            this.Speed += 2;
        }

        public void FallTheSpeed()
        {
            this.Speed -= 2;
        }

        public void StopTheCar()
        {
            Drive(0);
        }
    }

}

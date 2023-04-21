using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car

            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable

            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()

            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            var lot = new Carlot();

            Car car1 = new Car();
            car1.Year = 2019;
            car1.Make = "Tesla";
            car1.Model = "Model 3";
            car1.EngineNoise = "quiet";
            car1.HonkNoise = "beep";
            car1.IsDriveable = true;

            lot.Car.Add(car1);
            

            Car car2 = new Car()
            /*var car2 = new Car()*/
            {
                Year = 2004,
                Make = "Toyota",
                Model = "Prius",
                EngineNoise = "eeeh",
                HonkNoise = "beep..beep",
                IsDriveable = true
            };
            lot.Car.Add(car2);


            Car car3 = new Car(2023, "Audi", "Q7", "vroom", "beeeeeep", true);
            lot.Car.Add(car3);


            car1.MakeEngineNoise(car1.EngineNoise);
            car2.MakeEngineNoise(car2.EngineNoise);
            car3.MakeEngineNoise(car3.EngineNoise);


            car1.MakeHonkNoise(car1.HonkNoise);
            car2.MakeHonkNoise(car2.HonkNoise);
            car3.MakeHonkNoise(car3.HonkNoise);





            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            foreach (var item in lot.Car)
            {
                Console.WriteLine(item.Year);
                Console.WriteLine(item.Make);
                Console.WriteLine(item.Model);
                item.MakeEngineNoise(item.EngineNoise);
                item.MakeHonkNoise(item.HonkNoise);
                Console.WriteLine();
            }

        }
    }
}

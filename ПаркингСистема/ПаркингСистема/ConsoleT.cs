using System;

namespace ПаркингСистема
{
        internal class ConsoleT : Terminal
        {
            private bool isRunning;
            private readonly Assistant assistant;

            public ConsoleT(Assistant assistant)
            {
                this.assistant = assistant;
                this.isRunning = false;
            }


            public void Start()
            {
                this.isRunning = true;
                while (this.isRunning)
                {
                    this.ReadCommand();
                }
            }

            public void WriteLine(string message)
            {
                Console.WriteLine(message);
            }

            public string ReadLine()
            {
                return Console.ReadLine();
            }

            public void WriteLine(string message, params string[] parameters)
            {
                Console.WriteLine(message, parameters);
            }

            private void ReadCommand()
            {
                string[] commandParams = this.ReadLine().Split(" ");
                string command = commandParams[0];
                Vehicle vehicle = new Car();
                switch (command)
                {
                    case "Паркинг":
                        {
                            string parkingName = commandParams[1];
                            int carCap = int.Parse(commandParams[2]);
                            int busCap = int.Parse(commandParams[3]);
                            int truckCap = int.Parse(commandParams[4]);
                            this.assistant.AddParking(parkingName, carCap, busCap, truckCap);
                        }
                        break;
                    case "Кола":
                    case "Бус":
                    case "Камион":
                        vehicle = command switch
                        {
                            "Кола" => new Car(),
                            "Бус" => new Bus(),
                            "Камион" => new Truck(),
                        };
                        string make = commandParams[1];
                        string model = commandParams[2];
                        vehicle.Make = make;
                        vehicle.Model = model;

                        if (!this.assistant.ParkVehicle(vehicle))
                            this.WriteLine(Outputs.NoSpacesAvailableMsg, vehicle.Make, vehicle.Model);

                        break;
                    case "Печат":
                        {
                            string parkingName = commandParams[1];
                            this.WriteLine(this.assistant.PrintParkedVehicles(parkingName));
                            break;
                        }
                    case "Край":
                        this.WriteLine(this.assistant.PrintParkingStatus());
                        this.isRunning = false;
                        break;
                }
            }
        }
    }

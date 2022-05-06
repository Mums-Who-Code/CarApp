// ------------------------------------------------
// Copyright (c) MumsWhoCode. All rights reserved.
// ------------------------------------------------

using CarApp.ConsoleApp.Models.Cars;

namespace CarApp.ConsoleApp.Brokers.Storages
{
    internal partial class StorageBroker : IStorageBroker
    {
        List<Car> Cars = new List<Car>();

        public Car InsertCar(Car car)
        {
            Cars.Add(car);

            return car;
        }
    }
}
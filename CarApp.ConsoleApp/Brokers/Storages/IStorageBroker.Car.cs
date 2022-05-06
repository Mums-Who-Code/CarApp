// ------------------------------------------------
// Copyright (c) MumsWhoCode. All rights reserved.
// ------------------------------------------------

using CarApp.ConsoleApp.Models.Cars;

namespace CarApp.ConsoleApp.Brokers.Storages
{
    internal partial interface IStorageBroker
    {
        Car InsertCar(Car car);
    }
}